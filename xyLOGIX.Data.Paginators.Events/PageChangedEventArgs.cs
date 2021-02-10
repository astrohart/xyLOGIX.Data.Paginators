using System;

namespace xyLOGIX.Data.Paginators.Events
{
   /// <summary>
   /// Defines the data that is passed by all events of type <see
   /// cref="T:xyLOGIX.Data.Paginators.Events.PageChangedEventHandler"/> .
   /// </summary>
   public class PageChangedEventArgs : EventArgs
   {
      /// <summary>
      /// Creates a new instance of <see
      /// cref="T:xyLOGIX.Data.Paginators.Events.PageChangedEventArgs"/> and
      /// returns a reference to it.
      /// </summary>
      /// <param name="currentPage">
      /// (Required.) Integer describing the new page that the paginator has
      /// been set to. Must be a positive value starting from 1.
      /// </param>
      /// <param name="totalPages">
      /// (Required.) Integer describing the total page count of the paginator
      /// object. Must be a positive value starting from 1.
      /// </param>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// Thrown if either the <paramref name="totalPages"/> or <paramref
      /// name="currentPage"/> parameters are zero or negative, or if <paramref
      /// name="currentPage"/> is greater than <paramref name="totalPages"/>.
      /// </exception>
      public PageChangedEventArgs(int currentPage, int totalPages)
      {
         if (totalPages <= 0)
            throw new ArgumentOutOfRangeException(nameof(totalPages));
         if (currentPage <= 0 || currentPage > totalPages)
            throw new ArgumentOutOfRangeException(nameof(currentPage));
         CurrentPage = currentPage;
         TotalPages = totalPages;
      }

      /// <summary>
      /// Gets a value that describes the current page that the paginator has
      /// been set to.
      /// </summary>
      /// <remarks>
      /// This value is always 1 or higher.
      /// </remarks>
      public int CurrentPage { get; }

      /// <summary>
      /// Gets a value that describes the total count of pages in the paginator.
      /// </summary>
      /// <remarks>
      /// This value is always 1 or higher.
      /// </remarks>
      public int TotalPages { get; }
   }
}