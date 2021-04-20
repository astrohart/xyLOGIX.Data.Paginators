using System;

namespace xyLOGIX.Data.Paginators.Interfaces
{
   /// <summary>
   /// Defines the public-exposed methods and properties of a url-based
   /// paginator object.
   /// </summary>
   /// <remarks>
   /// These objects change the URL route to match the current page, i.e.,
   /// <c>https://localhost:45665/houses/2/</c> for page 2 of a houses list.
   /// </remarks>
   public interface IUrlPaginator : IPaginator
   {
      /// <summary>
      /// Initializes the lambda expression that specifies how to format URL
      /// routes for the various pages.
      /// </summary>
      /// <param name="expression">
      /// A <see cref="T:System.Func"/> delegate, that takes an integer
      /// parameter and returns a string, that specifies how to format URLs for
      /// each page.
      /// </param>
      /// <returns>
      /// Reference to the same instance of the object that called this method,
      /// for fluent use.
      /// </returns>
      /// <exception cref="T:System.ArgumentNullExpression">
      /// Thrown if the <paramref name="expression"/> parameter is passed a
      /// <see langword="null" /> value.
      /// </exception>
      dynamic AndUrlFormat(Func<int, string> expression);
   }
}