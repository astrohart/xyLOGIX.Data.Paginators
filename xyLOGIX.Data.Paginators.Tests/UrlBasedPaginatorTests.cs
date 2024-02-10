using NUnit.Framework;
using NUnit.Framework.Legacy;
using PostSharp.Patterns.Threading;
using System;
using xyLOGIX.Data.Paginators.Constants;
using xyLOGIX.Data.Paginators.Events;
using xyLOGIX.Data.Paginators.Factories;
using xyLOGIX.Data.Paginators.Interfaces;
using xyLOGIX.Data.Paginators.Models;

namespace xyLOGIX.Data.Paginators.Tests
{
    /// <summary>
    /// Provides unit tests for the
    /// <see cref="T:xyLOGIX.Data.Paginators.Paginator" /> class.
    /// </summary>
    [TestFixture, ExplicitlySynchronized]
    public class UrlBasedPaginatorTests
    {
        /// <summary> Sets up the initial conditions for all the unit tests. </summary>
        /// <remarks>
        /// This particular implementation instantiates a paginator object and
        /// places a reference to it in the
        /// <see cref="F:xyLOGIX.Data.Paginators.Tests.UrlBasedPaginatorTests._paginator" />
        /// field.
        /// </remarks>
        [SetUp]
        public void Initialize()
        {
            Assert.DoesNotThrow(
                () => _paginator = GetScrapedDataPaginator
                                   .OfType(PaginatorType.UrlPaginator)
                                   .HavingPagination(
                                       new Pagination(
                                           1, VALID_PAGE_SIZE,
                                           VALID_TOTAL_ENTRIES
                                       )
                                   )
                                   .AndUrlFormat(
                                       new Func<int, string>(
                                           page
                                               => $"https://coinmarketcap.com/{page}/"
                                       )
                                   ) as IUrlPaginator
            );
            ClassicAssert.IsNotNull(_paginator);

            _paginator.PageChanged += OnPaginatorPageChanged;

            ClassicAssert.AreEqual(
                41, _paginator.TotalPages
            ); // prior to initialization of paginator, TotalPages shall default to 1
        }

        private const string VALID_COINMARKETCAP_PAGE_1_URL =
            "https://coinmarketcap.com/1/";

        private const string VALID_COINMARKETCAP_PAGE_10_URL =
            "https://coinmarketcap.com/10/";

        private const string VALID_COINMARKETCAP_PAGE_11_URL =
            "https://coinmarketcap.com/11/";

        private const string VALID_COINMARKETCAP_PAGE_9_URL =
            "https://coinmarketcap.com/9/";

        private const int VALID_PAGE_SIZE = 100;

        private const int VALID_TOTAL_ENTRIES = 4096;

        /// <summary>
        /// Reference to an instance of an object that implements the
        /// <see cref="T:xyLOGIX.Data.Paginators.Interfaces.IScrapedDataPaginator" />
        /// interface and which provides pagination services.
        /// </summary>
        private IScrapedDataPaginator _paginator;

        /// <summary>
        /// Gets a formatted, valid URL for the final page worth of CoinMarketCap
        /// data.
        /// </summary>
        private string VALID_COINMARKETCAP_FINAL_PAGE_URL
            => $"https://coinmarketcap.com/{_paginator.TotalPages}/";

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> method
        /// moves to the last page from the penultimate (i.e., next-to-last) page.
        /// </summary>
        [Test]
        public void Test_CallingNext_FromPenultimatePage_MovesToLast()
        {
            _paginator.GoToPage(_paginator.TotalPages - 1);
            ClassicAssert.AreEqual(_paginator.Next(), _paginator.Last());
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> method
        /// stays on the last page if that's the page the paginator is already pointing at.
        /// </summary>
        [Test]
        public void Test_CallingNext_OnLastPage_StaysThere()
        {
            _paginator.Last();
            ClassicAssert.AreEqual(_paginator.Next(), _paginator.Last());
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" /> method
        /// stays on the first page if that's where the paginator is currently pointing.
        /// </summary>
        [Test]
        public void Test_CallingPrev_OnFirstPage_StaysThere()
        {
            _paginator.First();
            ClassicAssert.AreEqual(_paginator.Prev(), _paginator.First());
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" /> method
        /// moves the paginator to the first page when called from page 2.
        /// </summary>
        [Test]
        public void Test_CallingPrev_OnSecondPage_MovesToFirst()
        {
            _paginator.GoToPage(2);
            ClassicAssert.AreEqual(_paginator.Prev(), _paginator.First());
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.First" /> method
        /// sends us to the first page of data by returning the URL for that page.
        /// </summary>
        [Test]
        public void Test_FirstMethod_SendsMeToFirstPage()
        {
            ClassicAssert.AreEqual(VALID_COINMARKETCAP_PAGE_1_URL, _paginator.First());
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage" /> method
        /// sends us to the first page of data by returning the URL for that page, if we
        /// try to advance the paginator to a page number less than to page 1.
        /// </summary>
        [Test]
        public void Test_GoingBeforeBeginningOfPageRange_SendsMeToFirstPage()
        {
            ClassicAssert.AreEqual(
                _paginator.GoToPage(int.MinValue), _paginator.First()
            );
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.GoToPage" /> method
        /// sends us to the final page of data by returning the URL for that page, if we
        /// try to advance the paginator past the end of the range of valid page number
        /// values.
        /// </summary>
        [Test]
        public void Test_GoingPastEndOfPageRange_SendsMeToFinalPage()
        {
            ClassicAssert.AreEqual(
                _paginator.GoToPage(int.MaxValue), _paginator.Last()
            );
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Last" /> method
        /// sends us to the final page of data by returning the URL for that page.
        /// </summary>
        [Test]
        public void Test_LastMethod_SendsMeToFinalPage()
        {
            ClassicAssert.AreEqual(
                VALID_COINMARKETCAP_FINAL_PAGE_URL, _paginator.Last()
            );
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Next" /> method
        /// sends us to the page 11 of the data when starting from page 10. page of data by
        /// returning the URL for that page.
        /// </summary>
        [Test]
        public void Test_NextMethod_SendsMeToPage11_FromPage10()
        {
            _paginator.GoToPage(10); // first, go to page 10...
            ClassicAssert.AreEqual(VALID_COINMARKETCAP_PAGE_11_URL, _paginator.Next());
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="P:xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageUrl" /> property
        /// returns a value that is valid to access page 10 of CoinMarketCap.com data.
        /// </summary>
        [Test]
        public void Test_Page10_URL_HasCorrectFormat()
        {
            _paginator.GoToPage(10);
            ClassicAssert.AreEqual(
                VALID_COINMARKETCAP_PAGE_10_URL, _paginator.PageUrl
            );
            Reset();
        }

        /// <summary>
        /// Asserts the
        /// <see cref="M:xyLOGIX.Data.Paginators.Interfaces.IPaginator.Prev" /> method
        /// sends us to the page 9 of the data when starting from page 10. page of data by
        /// returning the URL for that page.
        /// </summary>
        [Test]
        public void Test_PrevMethod_SendsMeToPage9_FromPage10()
        {
            _paginator.GoToPage(10); // first, go to page 10...
            ClassicAssert.AreEqual(VALID_COINMARKETCAP_PAGE_9_URL, _paginator.Prev());
            Reset();
        }

        /// <summary>
        /// Handles the
        /// <see cref="E:xyLOGIX.Data.Paginators.Interfaces.IPaginator.PageChanged" />
        /// event.
        /// </summary>
        /// <param name="sender">
        /// Reference to an instance of the object that raised the
        /// event.
        /// </param>
        /// <param name="e">
        /// An <see cref="T:System.EventArgs" /> that contains the event
        /// data.
        /// </param>
        /// <remarks> This method dumps the new page information to the console. </remarks>
        [EntryPoint]        
        private static void OnPaginatorPageChanged(
            object sender,
            PageChangedEventArgs e
        )
        {
            ClassicAssert.IsTrue(e.TotalPages > 0 && e.TotalPages < int.MaxValue);
            ClassicAssert.IsTrue(
                e.CurrentPage > 0 && e.CurrentPage <= e.TotalPages &&
                e.CurrentPage < int.MaxValue
            );
            Console.WriteLine(
                $"Now turning to page {e.CurrentPage} of {e.TotalPages} pages."
            );
        }

        /// <summary> Moves the testing paginator object back to the first page of data. </summary>
        private void Reset()
            => Assert.DoesNotThrow(() => _paginator.First());
    }
}