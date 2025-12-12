using System;

namespace Showdoku.Exceptions
{
    /// <summary>
    /// The exception thrown if an attempted solution is not valid.
    /// </summary>
    /// <remarks>
    /// Initialises a new instance of the <see cref="InvalidSolutionException"/> class with the
    /// specified error message.
    /// </remarks>
    /// <param name="message">
    /// The message associated with the exception.
    /// </param>
    /// <param name="attemptedSolution">
    /// The attempted solution.
    /// </param>
    public class InvalidSolutionException(string message, int attemptedSolution) : Exception(message)
	{
        /// <summary>
        /// Gets the attempted solution.
        /// </summary>
        public int AttemptedSolution { get; } = attemptedSolution;
    }
}
