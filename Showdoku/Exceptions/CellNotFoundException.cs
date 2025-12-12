using System;

namespace Showdoku.Exceptions
{
    /// <summary>
    /// The exception thrown if a cell cannot be found.
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="CellNotFoundException"/> class with the
    /// specified error message.
    /// </remarks>
    /// <param name="message">
    /// The message associated with the exception.
    /// </param>
    public class CellNotFoundException(string message) : Exception(message)
	{
    }
}
