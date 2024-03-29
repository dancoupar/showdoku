﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Showdoku
{
	/// <summary>
	/// A horizontal row containing 9 cells.
	/// </summary>
	public class Row : CellCollection
	{
		/// <summary>
		/// Creates a new row of 9 cells.
		/// </summary>
		/// <param name="cells">
		/// An array of 9 cells that the row is to contain.
		/// </param>
		/// <exception cref="ArgumentNullException">
		/// Thrown if the specified array is null.
		/// </exception>
		/// <exception cref="ArgumentException">
		/// Thrown if the specified array does not contain 9 elements, or if any elements are null.
		/// </exception>
		public Row(Cell[] cells)
		{
			this.Cells = cells ?? throw new ArgumentNullException(nameof(cells), "Argument cannot be null.");

			if (cells.Length != 9)
			{
				throw new ArgumentException("Array must contain 9 elements.", nameof(cells));
			}

			if (cells.Any((c) => c == null))
			{
				throw new ArgumentException("Array cannot contain null elements.");
			}
		}

		/// <summary>
		/// Gets an array of all 9 cells in this row.
		/// </summary>
		public Cell[] Cells
		{
			get;
		}

		/// <summary>
		/// Returns an enumerator that iterates through each of the cells within this row.
		/// </summary>
		/// <returns>
		/// An enumerator that can be used to iterate through the cells within this row.
		/// </returns>
		public override IEnumerator<Cell> GetEnumerator()
		{
			foreach (Cell cell in this.Cells)
			{
				yield return cell;
			}
		}

		/// <summary>
		/// Returns a string representation of the row.
		/// </summary>
		public override string ToString()
		{
			var builder = new StringBuilder();

			void addLineBreak()
			{
				for (int i = 0; i < 31; i++)
				{
					builder.Append('—');
				}

				builder.AppendLine();
			};

			addLineBreak();			

			for (int x1 = 0; x1 < 3; x1++)
			{
				builder.Append('|');

				for (int x2 = 0; x2 < 3; x2++)
				{
					Cell cell = this.Cells[x2 + 3 * x1];

					if (cell.IsSolved())
					{
						builder.Append($" {cell.Solution.Value} ");
					}
					else
					{
						builder.Append("   ");
					}
				}
			}

			builder.AppendLine("|");
			addLineBreak();

			return builder.ToString();
		}
	}
}
