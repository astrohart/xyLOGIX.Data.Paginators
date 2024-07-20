using PostSharp.Patterns.Threading;
using System;

namespace xyLOGIX.Data.Paginators.Events
{
    /// <summary>
    /// Information for a <c>UrlExpressionRequested</c> event.
    /// </summary>
    [ExplicitlySynchronized]
    public class UrlExpressionRequestedEventArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of
        /// <see cref="T:xyLOGIX.Data.Paginators.Events.UrlExpressionRequestedEventArgs" />
        /// and
        /// returns a reference to it.
        /// </summary>
        /// <param name="currentPage">
        /// (Required.) Integer value specifying the number of the current page of data
        /// that is to be requested from the server.
        /// </param>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        /// Thrown if a negative quantity is passed for the value of the
        /// <paramref name="currentPage" /> parameter.
        /// </exception>
        public UrlExpressionRequestedEventArgs(int currentPage)
        {
            if (currentPage < 0)
                throw new ArgumentOutOfRangeException(
                    nameof(currentPage),
                    "Current page cannot be a negative number."
                );

            CurrentPage = currentPage;
        }

        /// <summary>
        /// Gets an integer that is set to the number of the current page.
        /// </summary>
        public int CurrentPage { get; }
    }
}