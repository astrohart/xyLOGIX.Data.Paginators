namespace xyLOGIX.Data.Paginators.Constants
{
   /// <summary>
   /// Values describing the type of Paginator you want.
   /// </summary>
   public enum PaginatorType
   {
      /// <summary>
      /// Moves between pages merely by altering the request route (URL).
      /// </summary>
      UrlPaginator,

      /// <summary>
      /// Moves between the pages of data returned by an API by making special
      /// calls to methods.
      /// </summary>
      ApiPaginator,

      /// <summary>
      /// Unknown strategy type.
      /// </summary>
      Unknown = -1
   }
}