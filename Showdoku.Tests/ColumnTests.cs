using FluentAssertions;
using System;
using Xunit;

namespace Showdoku
{
	public class ColumnTests
	{
		[Fact]
		public void Creating_a_column_throws_if_no_cells_are_provided()
		{
			// Arrange
			Column column;

			// Act
			Action act = () =>
			{
				column = new Column(null);
			};

			// Assert
			act.Should().Throw<ArgumentNullException>();
		}

		[Fact]
		public void Creating_a_column_throws_if_fewer_than_nine_cells_are_provided()
		{
			// Arrange
			Column column;
			var grid = new Grid();
			var cells = new Cell[8]
			{
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid)
			};

			// Act
			Action act = () =>
			{
				column = new Column(cells);
			};

			// Assert
			act.Should().Throw<ArgumentException>();
		}

		[Fact]
		public void Creating_a_column_throws_if_more_than_nine_cells_are_provided()
		{
			// Arrange
			Column column;
			var grid = new Grid();
			var cells = new Cell[10]
			{
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid)
			};

			// Act
			Action act = () =>
			{
				column = new Column(cells);
			};

			// Assert
			act.Should().Throw<ArgumentException>();
		}

		[Fact]
		public void Creating_a_column_throws_if_any_provided_cells_are_missing()
		{
			// Arrange
			Column column;
			var grid = new Grid();
			var cells = new Cell[9]
			{
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				new Cell(grid),
				null
			};

			// Act
			Action act = () =>
			{
				column = new Column(cells);
			};

			// Assert
			act.Should().Throw<ArgumentException>();
		}

		[Fact]
		public void All_columns_contain_nine_cells()
		{
			// Arrange
			// Act
			var grid = new Grid();

			// Assert
			foreach (Column column in grid.Columns)
			{
				column.Cells.Length.Should().Be(9);
			}
		}

		[Fact]
		public void All_columns_contain_expected_cells()
		{
			// Arrange
			// Act
			var grid = new Grid();

			// Assert
			grid.Columns[0].Cells[0].Should().Be(grid.Cells[0, 0]);
			grid.Columns[0].Cells[1].Should().Be(grid.Cells[0, 1]);
			grid.Columns[0].Cells[2].Should().Be(grid.Cells[0, 2]);
			grid.Columns[0].Cells[3].Should().Be(grid.Cells[0, 3]);
			grid.Columns[0].Cells[4].Should().Be(grid.Cells[0, 4]);
			grid.Columns[0].Cells[5].Should().Be(grid.Cells[0, 5]);
			grid.Columns[0].Cells[6].Should().Be(grid.Cells[0, 6]);
			grid.Columns[0].Cells[7].Should().Be(grid.Cells[0, 7]);
			grid.Columns[0].Cells[8].Should().Be(grid.Cells[0, 8]);

			grid.Columns[1].Cells[0].Should().Be(grid.Cells[1, 0]);
			grid.Columns[1].Cells[1].Should().Be(grid.Cells[1, 1]);
			grid.Columns[1].Cells[2].Should().Be(grid.Cells[1, 2]);
			grid.Columns[1].Cells[3].Should().Be(grid.Cells[1, 3]);
			grid.Columns[1].Cells[4].Should().Be(grid.Cells[1, 4]);
			grid.Columns[1].Cells[5].Should().Be(grid.Cells[1, 5]);
			grid.Columns[1].Cells[6].Should().Be(grid.Cells[1, 6]);
			grid.Columns[1].Cells[7].Should().Be(grid.Cells[1, 7]);
			grid.Columns[1].Cells[8].Should().Be(grid.Cells[1, 8]);

			grid.Columns[2].Cells[0].Should().Be(grid.Cells[2, 0]);
			grid.Columns[2].Cells[1].Should().Be(grid.Cells[2, 1]);
			grid.Columns[2].Cells[2].Should().Be(grid.Cells[2, 2]);
			grid.Columns[2].Cells[3].Should().Be(grid.Cells[2, 3]);
			grid.Columns[2].Cells[4].Should().Be(grid.Cells[2, 4]);
			grid.Columns[2].Cells[5].Should().Be(grid.Cells[2, 5]);
			grid.Columns[2].Cells[6].Should().Be(grid.Cells[2, 6]);
			grid.Columns[2].Cells[7].Should().Be(grid.Cells[2, 7]);
			grid.Columns[2].Cells[8].Should().Be(grid.Cells[2, 8]);

			grid.Columns[3].Cells[0].Should().Be(grid.Cells[3, 0]);
			grid.Columns[3].Cells[1].Should().Be(grid.Cells[3, 1]);
			grid.Columns[3].Cells[2].Should().Be(grid.Cells[3, 2]);
			grid.Columns[3].Cells[3].Should().Be(grid.Cells[3, 3]);
			grid.Columns[3].Cells[4].Should().Be(grid.Cells[3, 4]);
			grid.Columns[3].Cells[5].Should().Be(grid.Cells[3, 5]);
			grid.Columns[3].Cells[6].Should().Be(grid.Cells[3, 6]);
			grid.Columns[3].Cells[7].Should().Be(grid.Cells[3, 7]);
			grid.Columns[3].Cells[8].Should().Be(grid.Cells[3, 8]);

			grid.Columns[4].Cells[0].Should().Be(grid.Cells[4, 0]);
			grid.Columns[4].Cells[1].Should().Be(grid.Cells[4, 1]);
			grid.Columns[4].Cells[2].Should().Be(grid.Cells[4, 2]);
			grid.Columns[4].Cells[3].Should().Be(grid.Cells[4, 3]);
			grid.Columns[4].Cells[4].Should().Be(grid.Cells[4, 4]);
			grid.Columns[4].Cells[5].Should().Be(grid.Cells[4, 5]);
			grid.Columns[4].Cells[6].Should().Be(grid.Cells[4, 6]);
			grid.Columns[4].Cells[7].Should().Be(grid.Cells[4, 7]);
			grid.Columns[4].Cells[8].Should().Be(grid.Cells[4, 8]);

			grid.Columns[5].Cells[0].Should().Be(grid.Cells[5, 0]);
			grid.Columns[5].Cells[1].Should().Be(grid.Cells[5, 1]);
			grid.Columns[5].Cells[2].Should().Be(grid.Cells[5, 2]);
			grid.Columns[5].Cells[3].Should().Be(grid.Cells[5, 3]);
			grid.Columns[5].Cells[4].Should().Be(grid.Cells[5, 4]);
			grid.Columns[5].Cells[5].Should().Be(grid.Cells[5, 5]);
			grid.Columns[5].Cells[6].Should().Be(grid.Cells[5, 6]);
			grid.Columns[5].Cells[7].Should().Be(grid.Cells[5, 7]);
			grid.Columns[5].Cells[8].Should().Be(grid.Cells[5, 8]);

			grid.Columns[6].Cells[0].Should().Be(grid.Cells[6, 0]);
			grid.Columns[6].Cells[1].Should().Be(grid.Cells[6, 1]);
			grid.Columns[6].Cells[2].Should().Be(grid.Cells[6, 2]);
			grid.Columns[6].Cells[3].Should().Be(grid.Cells[6, 3]);
			grid.Columns[6].Cells[4].Should().Be(grid.Cells[6, 4]);
			grid.Columns[6].Cells[5].Should().Be(grid.Cells[6, 5]);
			grid.Columns[6].Cells[6].Should().Be(grid.Cells[6, 6]);
			grid.Columns[6].Cells[7].Should().Be(grid.Cells[6, 7]);
			grid.Columns[6].Cells[8].Should().Be(grid.Cells[6, 8]);

			grid.Columns[7].Cells[0].Should().Be(grid.Cells[7, 0]);
			grid.Columns[7].Cells[1].Should().Be(grid.Cells[7, 1]);
			grid.Columns[7].Cells[2].Should().Be(grid.Cells[7, 2]);
			grid.Columns[7].Cells[3].Should().Be(grid.Cells[7, 3]);
			grid.Columns[7].Cells[4].Should().Be(grid.Cells[7, 4]);
			grid.Columns[7].Cells[5].Should().Be(grid.Cells[7, 5]);
			grid.Columns[7].Cells[6].Should().Be(grid.Cells[7, 6]);
			grid.Columns[7].Cells[7].Should().Be(grid.Cells[7, 7]);
			grid.Columns[7].Cells[8].Should().Be(grid.Cells[7, 8]);

			grid.Columns[8].Cells[0].Should().Be(grid.Cells[8, 0]);
			grid.Columns[8].Cells[1].Should().Be(grid.Cells[8, 1]);
			grid.Columns[8].Cells[2].Should().Be(grid.Cells[8, 2]);
			grid.Columns[8].Cells[3].Should().Be(grid.Cells[8, 3]);
			grid.Columns[8].Cells[4].Should().Be(grid.Cells[8, 4]);
			grid.Columns[8].Cells[5].Should().Be(grid.Cells[8, 5]);
			grid.Columns[8].Cells[6].Should().Be(grid.Cells[8, 6]);
			grid.Columns[8].Cells[7].Should().Be(grid.Cells[8, 7]);
			grid.Columns[8].Cells[8].Should().Be(grid.Cells[8, 8]);
		}

		[Fact]
		public void A_column_containing_only_solved_cells_is_solved()
		{
			// Arrange
			Grid grid = new Grid();

			// Act
			grid.Cells[0, 0].Solve(1);
			grid.Cells[0, 1].Solve(2);
			grid.Cells[0, 2].Solve(3);
			grid.Cells[0, 3].Solve(4);
			grid.Cells[0, 4].Solve(5);
			grid.Cells[0, 5].Solve(6);
			grid.Cells[0, 6].Solve(7);
			grid.Cells[0, 7].Solve(8);
			grid.Cells[0, 8].Solve(9);

			// Assert
			grid.Columns[0].IsSolved().Should().BeTrue();
		}

		[Fact]
		public void A_column_containing_any_unsolved_cells_is_unsolved()
		{
			// Arrange
			var grid = new Grid();

			// Act
			grid.Cells[0, 0].Solve(1);
			grid.Cells[0, 1].Solve(2);
			grid.Cells[0, 2].Solve(3);
			grid.Cells[0, 3].Solve(4);
			grid.Cells[0, 4].Solve(5);
			grid.Cells[0, 5].Solve(6);
			grid.Cells[0, 6].Solve(7);
			grid.Cells[0, 7].Solve(8);

			// Assert
			grid.Columns[0].IsSolved().Should().BeFalse();
		}
	}
}
