<a name='assembly'></a>
# xyLOGIX.Data.Paginators.Tests

## Contents

- [Resources](#T-xyLOGIX-Data-Paginators-Tests-Properties-Resources 'xyLOGIX.Data.Paginators.Tests.Properties.Resources')
  - [Culture](#P-xyLOGIX-Data-Paginators-Tests-Properties-Resources-Culture 'xyLOGIX.Data.Paginators.Tests.Properties.Resources.Culture')
  - [ResourceManager](#P-xyLOGIX-Data-Paginators-Tests-Properties-Resources-ResourceManager 'xyLOGIX.Data.Paginators.Tests.Properties.Resources.ResourceManager')
- [UrlBasedPaginatorTests](#T-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests')
  - [_paginator](#F-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-_paginator 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests._paginator')
  - [Initialize()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Initialize 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Initialize')
  - [OnPaginatorPageChanged(sender,e)](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-OnPaginatorPageChanged-System-Object,xyLOGIX-Data-Paginators-Events-PageChangedEventArgs- 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.OnPaginatorPageChanged(System.Object,xyLOGIX.Data.Paginators.Events.PageChangedEventArgs)')
  - [Reset()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Reset 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Reset')
  - [Test_CallingNext_FromPenultimatePage_MovesToLast()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingNext_FromPenultimatePage_MovesToLast 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_CallingNext_FromPenultimatePage_MovesToLast')
  - [Test_CallingNext_OnLastPage_StaysThere()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingNext_OnLastPage_StaysThere 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_CallingNext_OnLastPage_StaysThere')
  - [Test_CallingPrev_OnFirstPage_StaysThere()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingPrev_OnFirstPage_StaysThere 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_CallingPrev_OnFirstPage_StaysThere')
  - [Test_CallingPrev_OnSecondPage_MovesToFirst()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingPrev_OnSecondPage_MovesToFirst 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_CallingPrev_OnSecondPage_MovesToFirst')
  - [Test_FirstMethod_SendsMeToFirstPage()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_FirstMethod_SendsMeToFirstPage 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_FirstMethod_SendsMeToFirstPage')
  - [Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage')
  - [Test_GoingPastEndOfPageRange_SendsMeToFinalPage()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_GoingPastEndOfPageRange_SendsMeToFinalPage 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_GoingPastEndOfPageRange_SendsMeToFinalPage')
  - [Test_LastMethod_SendsMeToFinalPage()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_LastMethod_SendsMeToFinalPage 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_LastMethod_SendsMeToFinalPage')
  - [Test_NextMethod_SendsMeToPage11_FromPage10()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_NextMethod_SendsMeToPage11_FromPage10 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_NextMethod_SendsMeToPage11_FromPage10')
  - [Test_Page10_URL_HasCorrectFormat()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_Page10_URL_HasCorrectFormat 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_Page10_URL_HasCorrectFormat')
  - [Test_PrevMethod_SendsMeToPage9_FromPage10()](#M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_PrevMethod_SendsMeToPage9_FromPage10 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests.Test_PrevMethod_SendsMeToPage9_FromPage10')

<a name='T-xyLOGIX-Data-Paginators-Tests-Properties-Resources'></a>
## Resources `type`

##### Namespace

xyLOGIX.Data.Paginators.Tests.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-xyLOGIX-Data-Paginators-Tests-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-xyLOGIX-Data-Paginators-Tests-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests'></a>
## UrlBasedPaginatorTests `type`

##### Namespace

xyLOGIX.Data.Paginators.Tests

##### Summary

Provides unit tests for the
[Paginator](#T-xyLOGIX-Data-Paginators-Paginator 'xyLOGIX.Data.Paginators.Paginator')
class.

<a name='F-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-_paginator'></a>
### _paginator `constants`

##### Summary

Reference to an instance of an object that implements the
[IPaginator](#T-xyLOGIX-Data-Paginators-Interfaces-IPaginator 'xyLOGIX.Data.Paginators.Interfaces.IPaginator')
interface and
which provides pagination services.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Initialize'></a>
### Initialize() `method`

##### Summary

Sets up the initial conditions for all the unit tests.

##### Parameters

This method has no parameters.

##### Remarks

This particular implementation instantiates a paginator object and
places a reference to it in the
[_paginator](#F-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-_paginator 'xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests._paginator')
field.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-OnPaginatorPageChanged-System-Object,xyLOGIX-Data-Paginators-Events-PageChangedEventArgs-'></a>
### OnPaginatorPageChanged(sender,e) `method`

##### Summary

Handles the
[](#E-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageChanged 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageChanged')
event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Reference to an instance of the object that raised the event. |
| e | [xyLOGIX.Data.Paginators.Events.PageChangedEventArgs](#T-xyLOGIX-Data-Paginators-Events-PageChangedEventArgs 'xyLOGIX.Data.Paginators.Events.PageChangedEventArgs') | An [EventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.EventArgs 'System.EventArgs') that contains the event data. |

##### Remarks

This method dumps the new page information to the console.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Reset'></a>
### Reset() `method`

##### Summary

Moves the testing paginator object back to the first page of data.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingNext_FromPenultimatePage_MovesToLast'></a>
### Test_CallingNext_FromPenultimatePage_MovesToLast() `method`

##### Summary

Asserts the
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next')
method
moves to the last page from the penultimate (i.e., next-to-last) page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingNext_OnLastPage_StaysThere'></a>
### Test_CallingNext_OnLastPage_StaysThere() `method`

##### Summary

Asserts the
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next')
method
stays on the last page if that's the page the paginator is already
pointing at.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingPrev_OnFirstPage_StaysThere'></a>
### Test_CallingPrev_OnFirstPage_StaysThere() `method`

##### Summary

Asserts the
[Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev')
method
stays on the first page if that's where the paginator is currently pointing.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_CallingPrev_OnSecondPage_MovesToFirst'></a>
### Test_CallingPrev_OnSecondPage_MovesToFirst() `method`

##### Summary

Asserts the
[Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev')
method
moves the paginator to the first page when called from page 2.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_FirstMethod_SendsMeToFirstPage'></a>
### Test_FirstMethod_SendsMeToFirstPage() `method`

##### Summary

Asserts the
[First](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-First 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.First')
method
sends us to the first page of data by returning the URL for that page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage'></a>
### Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage() `method`

##### Summary

Asserts the
[GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage')
method sends us to the first page of data by returning the URL for
that page, if we try to advance the paginator to a page number less
than to page 1.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_GoingPastEndOfPageRange_SendsMeToFinalPage'></a>
### Test_GoingPastEndOfPageRange_SendsMeToFinalPage() `method`

##### Summary

Asserts the
[GoToPage](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-GoToPage 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage')
method sends us to the final page of data by returning the URL for
that page, if we try to advance the paginator past the end of the
range of valid page number values.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_LastMethod_SendsMeToFinalPage'></a>
### Test_LastMethod_SendsMeToFinalPage() `method`

##### Summary

Asserts the
[Last](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Last 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last')
method
sends us to the final page of data by returning the URL for that page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_NextMethod_SendsMeToPage11_FromPage10'></a>
### Test_NextMethod_SendsMeToPage11_FromPage10() `method`

##### Summary

Asserts the
[Next](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Next 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next')
method
sends us to the page 11 of the data when starting from page 10. page
of data by returning the URL for that page.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_Page10_URL_HasCorrectFormat'></a>
### Test_Page10_URL_HasCorrectFormat() `method`

##### Summary

Asserts the
[PageUrl](#P-xyLOGIX-Data-Paginators-Interfaces-IPaginator-PageUrl 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageUrl')
property returns a value that is valid to access page 10 of
CoinMarketCap.com data.

##### Parameters

This method has no parameters.

<a name='M-xyLOGIX-Data-Paginators-Tests-UrlBasedPaginatorTests-Test_PrevMethod_SendsMeToPage9_FromPage10'></a>
### Test_PrevMethod_SendsMeToPage9_FromPage10() `method`

##### Summary

Asserts the
[Prev](#M-xyLOGIX-Data-Paginators-Interfaces-IPaginator-Prev 'xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev')
method
sends us to the page 9 of the data when starting from page 10. page of
data by returning the URL for that page.

##### Parameters

This method has no parameters.
