<a name='assembly'></a>
# xyLOGIX.Data.Paginators.Interfaces

## Contents

- [IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
  - [CurrentPage](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-CurrentPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.CurrentPage')
  - [IsInitialized](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-IsInitialized 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.IsInitialized')
  - [PageSize](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageSize 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageSize')
  - [PageUrl](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageUrl 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageUrl')
  - [Pagination](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Pagination 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Pagination')
  - [TotalEntries](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-TotalEntries 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.TotalEntries')
  - [TotalPages](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-TotalPages 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.TotalPages')
  - [First()](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First')
  - [GoToPage(page)](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage-System-Int32- 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage(System.Int32)')
  - [HavingPagination(pagination)](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-HavingPagination-xyLOGIX-Data-Paginators-Models-Pagination- 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.HavingPagination(xyLOGIX.Data.Paginators.Models.Pagination)')
  - [HavingStartingPagination()](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-HavingStartingPagination 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.HavingStartingPagination')
  - [Last()](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
  - [Next()](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next')
  - [Prev()](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev')
- [IUrlPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IUrlPaginator 'xyLOGIX.Data.Paginators.Interfaces.IUrlPaginator')
  - [AndUrlFormat(expression)](#M-xyLOGIX-Data-Paginators-Interfaces-IUrlPaginator-AndUrlFormat-System-Func{System-Int32,System-String}- 'xyLOGIX.Data.Paginators.Interfaces.IUrlPaginator.AndUrlFormat(System.Func{System.Int32,System.String})')
- [Resources](#T-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources 'xyLOGIX.Data.Paginators.Interfaces.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Interfaces.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Interfaces.Properties.Resources.ResourceManager')

<a name='T-xyLOGIX-Data-Paginators-Interfaces-IPaginator'></a>
## IPaginator `type`

##### Namespace

xyLOGIX.Data.Paginators.Interfaces

##### Summary

Defines the public-exposed methods and properties of an object that
manages the pagination of scraped data.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Gets or sets an integer describing the current page.

##### Remarks

The value of this property can be changed using the [First](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First') , [Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev') , [GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage') ,
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next') ,
or [Last](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
methods in a robust, fault-tolerant, and thread-safe manner.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Gets a value indicating whether the paginator is initialized.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageSize'></a>
### PageSize `property`

##### Summary

Gets an integer describing the total number of entries on a page.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageUrl'></a>
### PageUrl `property`

##### Summary

Gets a string containing the URL of the current page.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Pagination'></a>
### Pagination `property`

##### Summary

Gets a reference to a [Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') object that
defines the pagination parameters, such as current page, page size,
total entries, etc.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-TotalEntries'></a>
### TotalEntries `property`

##### Summary

Gets an integer describing the total number of entries in the entire listing.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-TotalPages'></a>
### TotalPages `property`

##### Summary

Gets an integer describing the total number of pages.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First'></a>
### First() `method`

##### Summary

Navigates to the first page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage-System-Int32-'></a>
### GoToPage(page) `method`

##### Summary

Attempts the paginator to the desired `page` in a
robust, fault-tolerant, and thread-safe manner.

##### Returns

String containing the URL of the new page, or blank if a problem
occurred. This method will not go beyond the bounds of the current
range of pages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| page | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (Required.) A positive number, in between and including 1 and the
total number of pages, that indicates to which page you wish to navigate. |

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-HavingPagination-xyLOGIX-Data-Paginators-Models-Pagination-'></a>
### HavingPagination(pagination) `method`

##### Summary

Specifies the pagination strategy to be utilized with this object in a
fluent manner.

##### Returns

Reference to the instance of the object that called this method for
fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagination | [xyLOGIX.Data.Paginators.Models.Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') | Reference to an instance of [Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') that specifies
the pagination strategy to be utilized. |

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-HavingStartingPagination'></a>
### HavingStartingPagination() `method`

##### Summary

Initializes this paginator to start with default settings for Current
Page (= 1), Page Size (= 0), and Total Entries (= 0).

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method simply initializes a new pagination parameter object and
sets the [Pagination](#P-xyLOGIX-Data-Paginators-PaginatorBase-Pagination 'xyLOGIX.Data.Paginators.PaginatorBase.Pagination') property
to it.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last'></a>
### Last() `method`

##### Summary

Navigates to the last page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next'></a>
### Next() `method`

##### Summary

Navigates to the next page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev'></a>
### Prev() `method`

##### Summary

Navigates to the previous page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='T-xyLOGIX-Data-Paginators-Interfaces-IUrlPaginator'></a>
## IUrlPaginator `type`

##### Namespace

xyLOGIX.Data.Paginators.Interfaces

##### Summary

Defines the public-exposed methods and properties of a url-based
paginator object.

##### Remarks

These objects change the URL route to match the current page, i.e.,
`https://localhost:45665/houses/2/` for page 2 of a houses list.

<a name='M-xyLOGIX-Data-Paginators-Interfaces-IUrlPaginator-AndUrlFormat-System-Func{System-Int32,System-String}-'></a>
### AndUrlFormat(expression) `method`

##### Summary

Initializes the lambda expression that specifies how to format URL
routes for the various pages.

##### Returns

Reference to the same instance of the object that called this method,
for fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| expression | [System.Func{System.Int32,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Int32,System.String}') | A [Func](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func') delegate, that takes an integer
parameter and returns a string, that specifies how to format URLs for
each page. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullExpression](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullExpression 'System.ArgumentNullExpression') | Thrown if the `expression` parameter is passed a
`null` value. |

<a name='T-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Interfaces.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Interfaces-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.
