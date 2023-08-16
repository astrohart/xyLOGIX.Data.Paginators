<a name='assembly'></a>
# xyLOGIX.Data.Paginators

## Contents

- [PaginatorBase](#T-xyLOGIX-Data-Paginators-PaginatorBase 'xyLOGIX.Data.Paginators.PaginatorBase')
  - [SyncRoot](#F-xyLOGIX-Data-Paginators-PaginatorBase-SyncRoot 'xyLOGIX.Data.Paginators.PaginatorBase.SyncRoot')
  - [CurrentPage](#P-xyLOGIX-Data-Paginators-PaginatorBase-CurrentPage 'xyLOGIX.Data.Paginators.PaginatorBase.CurrentPage')
  - [IsInitialized](#P-xyLOGIX-Data-Paginators-PaginatorBase-IsInitialized 'xyLOGIX.Data.Paginators.PaginatorBase.IsInitialized')
  - [PageSize](#P-xyLOGIX-Data-Paginators-PaginatorBase-PageSize 'xyLOGIX.Data.Paginators.PaginatorBase.PageSize')
  - [PageUrl](#P-xyLOGIX-Data-Paginators-PaginatorBase-PageUrl 'xyLOGIX.Data.Paginators.PaginatorBase.PageUrl')
  - [Pagination](#P-xyLOGIX-Data-Paginators-PaginatorBase-Pagination 'xyLOGIX.Data.Paginators.PaginatorBase.Pagination')
  - [TotalEntries](#P-xyLOGIX-Data-Paginators-PaginatorBase-TotalEntries 'xyLOGIX.Data.Paginators.PaginatorBase.TotalEntries')
  - [TotalPages](#P-xyLOGIX-Data-Paginators-PaginatorBase-TotalPages 'xyLOGIX.Data.Paginators.PaginatorBase.TotalPages')
  - [CommonConstruct()](#M-xyLOGIX-Data-Paginators-PaginatorBase-CommonConstruct 'xyLOGIX.Data.Paginators.PaginatorBase.CommonConstruct')
  - [First()](#M-xyLOGIX-Data-Paginators-PaginatorBase-First 'xyLOGIX.Data.Paginators.PaginatorBase.First')
  - [GoToPage(page)](#M-xyLOGIX-Data-Paginators-PaginatorBase-GoToPage-System-Int32- 'xyLOGIX.Data.Paginators.PaginatorBase.GoToPage(System.Int32)')
  - [HavingPagination(pagination)](#M-xyLOGIX-Data-Paginators-PaginatorBase-HavingPagination-xyLOGIX-Data-Paginators-Models-Pagination- 'xyLOGIX.Data.Paginators.PaginatorBase.HavingPagination(xyLOGIX.Data.Paginators.Models.Pagination)')
  - [HavingStartingPagination()](#M-xyLOGIX-Data-Paginators-PaginatorBase-HavingStartingPagination 'xyLOGIX.Data.Paginators.PaginatorBase.HavingStartingPagination')
  - [Last()](#M-xyLOGIX-Data-Paginators-PaginatorBase-Last 'xyLOGIX.Data.Paginators.PaginatorBase.Last')
  - [Next()](#M-xyLOGIX-Data-Paginators-PaginatorBase-Next 'xyLOGIX.Data.Paginators.PaginatorBase.Next')
  - [OnFormatPageURL(pageNumber)](#M-xyLOGIX-Data-Paginators-PaginatorBase-OnFormatPageURL-System-Int32- 'xyLOGIX.Data.Paginators.PaginatorBase.OnFormatPageURL(System.Int32)')
  - [OnPageChanged(e)](#M-xyLOGIX-Data-Paginators-PaginatorBase-OnPageChanged-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs- 'xyLOGIX.Data.Paginators.PaginatorBase.OnPageChanged(xyLOGIX.Data.Paginators.Events.PageChangedEventArgs)')
  - [Prev()](#M-xyLOGIX-Data-Paginators-PaginatorBase-Prev 'xyLOGIX.Data.Paginators.PaginatorBase.Prev')
- [Resources](#T-xyLOGIX-Data-Paginators-Properties-Resources 'xyLOGIX.Data.Paginators.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Properties.Resources.ResourceManager')
- [UrlBasedPaginator](#T-xyLOGIX-Data-Paginators-UrlBasedPaginator 'xyLOGIX.Data.Paginators.UrlBasedPaginator')
  - [#ctor()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor 'xyLOGIX.Data.Paginators.UrlBasedPaginator.#ctor')
  - [#ctor(pagination)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor-xyLOGIX-Data-Paginators-Models-Pagination- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.#ctor(xyLOGIX.Data.Paginators.Models.Pagination)')
  - [#ctor(pagination,urlExpression)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor-xyLOGIX-Data-Paginators-Models-Pagination,System-Func{System-Int32,System-String}- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.#ctor(xyLOGIX.Data.Paginators.Models.Pagination,System.Func{System.Int32,System.String})')
  - [CurrentPage](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-CurrentPage 'xyLOGIX.Data.Paginators.UrlBasedPaginator.CurrentPage')
  - [IsInitialized](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-IsInitialized 'xyLOGIX.Data.Paginators.UrlBasedPaginator.IsInitialized')
  - [PageSize](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-PageSize 'xyLOGIX.Data.Paginators.UrlBasedPaginator.PageSize')
  - [PageUrl](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-PageUrl 'xyLOGIX.Data.Paginators.UrlBasedPaginator.PageUrl')
  - [Pagination](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-Pagination 'xyLOGIX.Data.Paginators.UrlBasedPaginator.Pagination')
  - [TotalEntries](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-TotalEntries 'xyLOGIX.Data.Paginators.UrlBasedPaginator.TotalEntries')
  - [TotalPages](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-TotalPages 'xyLOGIX.Data.Paginators.UrlBasedPaginator.TotalPages')
  - [UrlExpression](#P-xyLOGIX-Data-Paginators-UrlBasedPaginator-UrlExpression 'xyLOGIX.Data.Paginators.UrlBasedPaginator.UrlExpression')
  - [AndUrlFormat(expression)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-AndUrlFormat-System-Func{System-Int32,System-String}- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.AndUrlFormat(System.Func{System.Int32,System.String})')
  - [CommonConstruct()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-CommonConstruct 'xyLOGIX.Data.Paginators.UrlBasedPaginator.CommonConstruct')
  - [First()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-First 'xyLOGIX.Data.Paginators.UrlBasedPaginator.First')
  - [GoToPage(page)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-GoToPage-System-Int32- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.GoToPage(System.Int32)')
  - [Last()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Last 'xyLOGIX.Data.Paginators.UrlBasedPaginator.Last')
  - [Next()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Next 'xyLOGIX.Data.Paginators.UrlBasedPaginator.Next')
  - [OnFormatPageURL(pageNumber)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-OnFormatPageURL-System-Int32- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.OnFormatPageURL(System.Int32)')
  - [OnPageChanged(e)](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-OnPageChanged-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs- 'xyLOGIX.Data.Paginators.UrlBasedPaginator.OnPageChanged(xyLOGIX.Data.Paginators.Events.PageChangedEventArgs)')
  - [Prev()](#M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Prev 'xyLOGIX.Data.Paginators.UrlBasedPaginator.Prev')

<a name='T-xyLOGIX-Data-Paginators-PaginatorBase'></a>
## PaginatorBase `type`

##### Namespace

xyLOGIX.Data.Paginators

##### Summary

Defines the events, methods, properties, and behaviors for all Paginator object.

<a name='F-xyLOGIX-Data-Paginators-PaginatorBase-SyncRoot'></a>
### SyncRoot `constants`

##### Summary

Reference to an instance of an object that serves as a
thread-synchronization root object.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Gets or sets an integer describing the current page.

##### Remarks

The value of this property can be changed using the
[First](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First')
,
[Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev') ,
[GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage')
,
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next') ,
or
[Last](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
methods in a robust, fault-tolerant, and thread-safe manner.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Gets a value indicating whether the paginator is initialized.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-PageSize'></a>
### PageSize `property`

##### Summary

Gets an integer describing the total number of entries on a page.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-PageUrl'></a>
### PageUrl `property`

##### Summary

Gets a string containing the URL of the current page.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-Pagination'></a>
### Pagination `property`

##### Summary

Gets a reference to a
[Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination')
object that
defines the pagination parameters, such as current page, page size,
total entries, etc.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-TotalEntries'></a>
### TotalEntries `property`

##### Summary

Gets an integer describing the total number of entries in the entire listing.

<a name='P-xyLOGIX-Data-Paginators-PaginatorBase-TotalPages'></a>
### TotalPages `property`

##### Summary

Gets an integer describing the total number of pages.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-CommonConstruct'></a>
### CommonConstruct() `method`

##### Summary

Specifies common initialization code for all constructors.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-First'></a>
### First() `method`

##### Summary

Navigates to the first page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the
[GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage')
method internally.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-GoToPage-System-Int32-'></a>
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

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-HavingPagination-xyLOGIX-Data-Paginators-Models-Pagination-'></a>
### HavingPagination(pagination) `method`

##### Summary

Specifies the pagination strategy to be utilized with this object in
a fluent manner.

##### Returns

Reference to the instance of the object that called this method for
fluent use.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagination | [xyLOGIX.Data.Paginators.Models.Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') | Reference to an instance of
[Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination')
that specifies
the pagination strategy to be utilized. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [ArgumentNullException](#T-ArgumentNullException 'ArgumentNullException') | Thrown if the required parameter, `pagination`, is
passed a `null` value. |

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-HavingStartingPagination'></a>
### HavingStartingPagination() `method`

##### Summary

Initializes this paginator to start with default settings for
Current Page (= 1), Page Size (= 0), and Total Entries (= 0).

##### Returns

Reference to the same instance of the object that called this
method, for fluent use.

##### Parameters

This method has no parameters.

##### Remarks

This method simply initializes a new pagination parameter object and
sets the
[Pagination](#P-xyLOGIX-Data-Paginators-PaginatorBase-Pagination 'xyLOGIX.Data.Paginators.PaginatorBase.Pagination')
property
to it.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-Last'></a>
### Last() `method`

##### Summary

Navigates to the last page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the
[GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage')
method internally.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-Next'></a>
### Next() `method`

##### Summary

Navigates to the next page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the
[GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage')
method internally.

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-OnFormatPageURL-System-Int32-'></a>
### OnFormatPageURL(pageNumber) `method`

##### Summary

Invokes the expression, if any, attached to the
[_urlExpression](#F-                 CoinMarketCap-Data-Scraper-Interfaces-CoinMarketCapPagination-_urlExpression '                 CoinMarketCap.Data.Scraper.Interfaces.CoinMarketCapPagination._urlExpression')
delegate.

##### Returns

String containing the

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pageNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Page number of the
current page. |

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-OnPageChanged-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-'></a>
### OnPageChanged(e) `method`

##### Summary

Raises the
[](#E-xyLOGIX-Data-Paginators-IPaginator-PageChanged 'xyLOGIX.Data.Paginators.IPaginator.PageChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Data.Paginators.Events.PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs') | A
[PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs')
that
contains the event data. |

<a name='M-xyLOGIX-Data-Paginators-PaginatorBase-Prev'></a>
### Prev() `method`

##### Summary

Navigates to the previous page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the
[GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage')
method internally.

<a name='T-xyLOGIX-Data-Paginators-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Paginators-UrlBasedPaginator'></a>
## UrlBasedPaginator `type`

##### Namespace

xyLOGIX.Data.Paginators

##### Summary

Object that provides services for accessing paginated data from a data source.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor'></a>
### #ctor() `constructor`

##### Summary

Constructs a new instance of [UrlBasedPaginator](#T-xyLOGIX-Data-Paginators-UrlBasedPaginator 'xyLOGIX.Data.Paginators.UrlBasedPaginator') and returns a
reference to it.

##### Parameters

This constructor has no parameters.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor-xyLOGIX-Data-Paginators-Models-Pagination-'></a>
### #ctor(pagination) `constructor`

##### Summary

Constructs a new instance of [CoinMarketCapPagination](#T-CoinMarketCap-Data-Scraper-CoinMarketCapPagination 'CoinMarketCap.Data.Scraper.CoinMarketCapPagination') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagination | [xyLOGIX.Data.Paginators.Models.Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') | (Required.) Reference to an instance of a [Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') object that
provides the pagination data, such as current page, page size, total
entries, etc. |

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-#ctor-xyLOGIX-Data-Paginators-Models-Pagination,System-Func{System-Int32,System-String}-'></a>
### #ctor(pagination,urlExpression) `constructor`

##### Summary

Constructs a new instance of [CoinMarketCapPagination](#T-CoinMarketCap-Data-Scraper-CoinMarketCapPagination 'CoinMarketCap.Data.Scraper.CoinMarketCapPagination') and
returns a reference to it.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pagination | [xyLOGIX.Data.Paginators.Models.Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') | (Required.) Reference to an instance of a [Pagination](#T-xyLOGIX-Data-Paginators-Models-Pagination 'xyLOGIX.Data.Paginators.Models.Pagination') object that
provides the pagination data, such as current page, page size, total
entries, etc. |
| urlExpression | [System.Func{System.Int32,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Int32,System.String}') | (Required.) Lambda expression that specifies how to format the URL
associated with the current page of data. |

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-CurrentPage'></a>
### CurrentPage `property`

##### Summary

Gets or sets an integer describing the current page.

##### Remarks

The value of this property can be changed using the [First](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First') , [Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev') , [GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage') ,
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next') ,
or [Last](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
methods in a robust, fault-tolerant, and thread-safe manner.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-IsInitialized'></a>
### IsInitialized `property`

##### Summary

Gets a value indicating whether the paginator is initialized.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-PageSize'></a>
### PageSize `property`

##### Summary

Gets an integer describing the total number of entries on a page.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-PageUrl'></a>
### PageUrl `property`

##### Summary

Gets a string containing the URL of the current page.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-Pagination'></a>
### Pagination `property`

##### Summary

Gets a reference to a [Pagination](#T-xyLOGIX-Data-Paginators-Pagination 'xyLOGIX.Data.Paginators.Pagination') object.

##### Remarks

This is the object that contains the page size, etc.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-TotalEntries'></a>
### TotalEntries `property`

##### Summary

Gets an integer describing the total number of entries in the entire listing.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-TotalPages'></a>
### TotalPages `property`

##### Summary

Gets an integer describing the total number of pages.

<a name='P-xyLOGIX-Data-Paginators-UrlBasedPaginator-UrlExpression'></a>
### UrlExpression `property`

##### Summary

Gets an expression that tells us how to format the URL for each page.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-AndUrlFormat-System-Func{System-Int32,System-String}-'></a>
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

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-CommonConstruct'></a>
### CommonConstruct() `method`

##### Summary

Specifies common initialization code for all constructors.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-First'></a>
### First() `method`

##### Summary

Navigates to the first page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-GoToPage-System-Int32-'></a>
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

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Last'></a>
### Last() `method`

##### Summary

Navigates to the last page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Next'></a>
### Next() `method`

##### Summary

Navigates to the next page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-OnFormatPageURL-System-Int32-'></a>
### OnFormatPageURL(pageNumber) `method`

##### Summary

Invokes the expression, if any, attached to the [_urlExpression](#F-CoinMarketCap-Data-Scraper-Interfaces-CoinMarketCapPagination-_urlExpression 'CoinMarketCap.Data.Scraper.Interfaces.CoinMarketCapPagination._urlExpression') delegate.

##### Returns

String containing the

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| pageNumber | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Page number of the
current page. |

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-OnPageChanged-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-'></a>
### OnPageChanged(e) `method`

##### Summary

Raises the [](#E-xyLOGIX-Data-Paginators-IPaginator-PageChanged 'xyLOGIX.Data.Paginators.IPaginator.PageChanged') event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [xyLOGIX.Data.Paginators.Events.PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs') | A [PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs')
that contains the event data. |

<a name='M-xyLOGIX-Data-Paginators-UrlBasedPaginator-Prev'></a>
### Prev() `method`

##### Summary

Navigates to the previous page in a thread-safe manner.

##### Returns

String containing the URL of the new page.

##### Parameters

This method has no parameters.

##### Remarks

Implementers of this method should call the [GoToPage](#M-xyLOGIX-Data-Paginators-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.IPaginator.GoToPage') method internally.
