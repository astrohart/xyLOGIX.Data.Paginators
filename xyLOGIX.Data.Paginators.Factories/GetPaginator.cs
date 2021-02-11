﻿using System;
using xyLOGIX.Data.Paginators.Interfaces;

namespace xyLOGIX.Data.Paginators.Factories
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

   /// <summary>
   /// Creates instances of objects that implement the
   /// <see
   ///    cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginator" />
   /// interface.
   /// </summary>
   public static class GetPaginator
   {
      /// <summary>
      /// Creates an instance of an object implementing the
      /// <see
      ///    cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginator" />
      /// interface
      /// which corresponds to the value specified in <paramref name="type" />,
      /// and returns a reference to it.
      /// </summary>
      /// <param name="type">
      /// One of the
      /// <see
      ///    cref="T:xyLOGIX.Data.Paginators.Factories.PaginatorType" />
      /// values that
      /// describes what type of object you want.
      /// </param>
      /// <returns>
      /// A reference to the instance of the object that implements the
      /// <see
      ///    cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginator" />
      /// interface
      /// which corresponds to the value specified in <paramref name="type" />.
      /// </returns>
      /// <remarks>
      /// This method will throw an exception if there are no types implemented
      /// that correspond to the value of <paramref name="type" />.
      /// </remarks>
      /// <exception cref="T:System.ArgumentOutOfRangeException">
      /// Thrown if there is no corresponding concrete type defined that
      /// implements the
      /// <see
      ///    cref="T:xyLOGIX.Data.Paginators.Interfaces.IPaginator" />
      /// interface and
      /// which corresponds to the value passed in the <paramref name="type" />
      /// parameter.
      /// </exception>
      public static IPaginator For(PaginatorType type)
      {
         IPaginator result;

         switch (type)
         {
            // TODO: Add cases here to construct objects based on the enumeration value passed.

            case PaginatorType.Unknown:
            default:
               throw new ArgumentOutOfRangeException(nameof(type), type, null);
         }

         return result;
      }
   }
}