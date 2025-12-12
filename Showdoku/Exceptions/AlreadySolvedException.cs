using System;

namespace Showdoku.Exceptions
{
    /// <summary>
    /// The exception thrown if a cell has already been solved.
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="AlreadySolvedException"/> class with the
    /// specified error message.
    /// </remarks>
    /// <param name="message">
    /// The message associated with the exception.
    /// </param>
    public class AlreadySolvedException(string message) : Exception(message)
	{
    }
}
