using System;
using xyLOGIX.Core.Debug;
using xyLOGIX.Data.Paginators.Constants;
using xyLOGIX.Data.Paginators.Interfaces;

namespace xyLOGIX.Data.Paginators.Factories
{
   /// <summary>
   /// Creates instances of objects that implement the
   /// <see
   ///     cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
   /// interface.
   /// </summary>
   public static class GetScrapedDataPaginator
    {
       /// <summary>
       /// Creates an instance of an object implementing the
       /// <see
       ///     cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
       /// interface
       /// which corresponds to the value specified in <paramref name="type" />,
       /// and returns a reference to it.
       /// </summary>
       /// <param name="type">
       /// One of the
       /// <see
       ///     cref="T:xyLOGIX.Data.Paginators.Factories.PaginatorType" />
       /// values that
       /// describes what type of object you want.
       /// </param>
       /// <returns>
       /// A reference to the instance of the object that implements the
       /// <see
       ///     cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
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
       ///     cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
       /// interface and
       /// which corresponds to the value passed in the <paramref name="type" />
       /// parameter.
       /// </exception>
       public static IScrapedDataPaginator OfType(PaginatorType type)
        {
            // write the name of the current class and method we are now entering,
            // into the log
            DebugUtils.WriteLine(DebugLevel.Debug, "In GetScrapedDataPaginator.OfType");

            // Dump the parameter type to the log
            DebugUtils.WriteLine(
                DebugLevel.Debug, $"GetScrapedDataPaginator.OfType: type = '{type}'"
            );

            IScrapedDataPaginator result;

            switch (type)
            {
                case PaginatorType.UrlPaginator:
                    result = new UrlBasedPaginator();
                    break;

                default:
                    throw new ArgumentOutOfRangeException(
                        nameof(type), type,
                        $"We currently do not support the pagination strategy '{type}'."
                    );
            }

            return result;
        }
    }
}