using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.BoundingRectWithAnotherRange;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.CellWithRowWithColumn;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Clear;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsAfter;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsAfterWithCount;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsBefore;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnsBeforeWithCount;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ColumnWithColumn;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Delete;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.EntireColumn;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.EntireRow;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Insert;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.IntersectionWithAnotherRange;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastCell;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastColumn;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.LastRow;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Merge;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.OffsetRangeWithRowOffsetWithColumnOffset;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.ResizedRangeWithDeltaRowsWithDeltaColumns;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsAbove;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsAboveWithCount;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsBelow;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowsBelowWithCount;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.RowWithRow;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.Unmerge;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.UsedRange;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.UsedRangeWithValuesOnly;
using ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange.VisibleView;
using Microsoft.Kiota.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace ApiSdk.Users.Item.Insights.Trending.Item.Resource.WorkbookRange {
    /// <summary>Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange</summary>
    public class WorkbookRangeRequestBuilder {
        public ClearRequestBuilder Clear { get =>
            new ClearRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Current path for the request</summary>
        private string CurrentPath { get; set; }
        public DeleteRequestBuilder Delete { get =>
            new DeleteRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        public InsertRequestBuilder Insert { get =>
            new InsertRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Whether the current path is a raw URL</summary>
        private bool IsRawUrl { get; set; }
        public MergeRequestBuilder Merge { get =>
            new MergeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>Path segment to use to build the URL for the current request builder</summary>
        private string PathSegment { get; set; }
        /// <summary>The http core service to use to execute the requests.</summary>
        private IRequestAdapter RequestAdapter { get; set; }
        public UnmergeRequestBuilder Unmerge { get =>
            new UnmergeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.boundingRect(anotherRange='{anotherRange}')
        /// <param name="anotherRange">Usage: anotherRange={anotherRange}</param>
        /// </summary>
        public BoundingRectWithAnotherRangeRequestBuilder boundingRectWithAnotherRange(string anotherRange) {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new BoundingRectWithAnotherRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, anotherRange, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.cell(row={row},column={column})
        /// <param name="column">Usage: column={column}</param>
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public CellWithRowWithColumnRequestBuilder cellWithRowWithColumn(int? row, int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new CellWithRowWithColumnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, row, column, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsAfter()
        /// </summary>
        public ColumnsAfterRequestBuilder columnsAfter() {
            return new ColumnsAfterRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsAfter(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public ColumnsAfterWithCountRequestBuilder columnsAfterWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new ColumnsAfterWithCountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, count, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsBefore()
        /// </summary>
        public ColumnsBeforeRequestBuilder columnsBefore() {
            return new ColumnsBeforeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.columnsBefore(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public ColumnsBeforeWithCountRequestBuilder columnsBeforeWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new ColumnsBeforeWithCountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, count, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.column(column={column})
        /// <param name="column">Usage: column={column}</param>
        /// </summary>
        public ColumnWithColumnRequestBuilder columnWithColumn(int? column) {
            _ = column ?? throw new ArgumentNullException(nameof(column));
            return new ColumnWithColumnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, column, false);
        }
        /// <summary>
        /// Instantiates a new WorkbookRangeRequestBuilder and sets the default values.
        /// <param name="currentPath">Current path for the request</param>
        /// <param name="isRawUrl">Whether the current path is a raw URL</param>
        /// <param name="requestAdapter">The http core service to use to execute the requests.</param>
        /// </summary>
        public WorkbookRangeRequestBuilder(string currentPath, IRequestAdapter requestAdapter, bool isRawUrl = true) {
            if(string.IsNullOrEmpty(currentPath)) throw new ArgumentNullException(nameof(currentPath));
            _ = requestAdapter ?? throw new ArgumentNullException(nameof(requestAdapter));
            PathSegment = "/microsoft.graph.workbookRange";
            RequestAdapter = requestAdapter;
            CurrentPath = currentPath;
            IsRawUrl = isRawUrl;
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.entireColumn()
        /// </summary>
        public EntireColumnRequestBuilder entireColumn() {
            return new EntireColumnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.entireRow()
        /// </summary>
        public EntireRowRequestBuilder entireRow() {
            return new EntireRowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.intersection(anotherRange='{anotherRange}')
        /// <param name="anotherRange">Usage: anotherRange={anotherRange}</param>
        /// </summary>
        public IntersectionWithAnotherRangeRequestBuilder intersectionWithAnotherRange(string anotherRange) {
            if(string.IsNullOrEmpty(anotherRange)) throw new ArgumentNullException(nameof(anotherRange));
            return new IntersectionWithAnotherRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, anotherRange, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastCell()
        /// </summary>
        public LastCellRequestBuilder lastCell() {
            return new LastCellRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastColumn()
        /// </summary>
        public LastColumnRequestBuilder lastColumn() {
            return new LastColumnRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.lastRow()
        /// </summary>
        public LastRowRequestBuilder lastRow() {
            return new LastRowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.offsetRange(rowOffset={rowOffset},columnOffset={columnOffset})
        /// <param name="columnOffset">Usage: columnOffset={columnOffset}</param>
        /// <param name="rowOffset">Usage: rowOffset={rowOffset}</param>
        /// </summary>
        public OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder offsetRangeWithRowOffsetWithColumnOffset(int? rowOffset, int? columnOffset) {
            _ = columnOffset ?? throw new ArgumentNullException(nameof(columnOffset));
            _ = rowOffset ?? throw new ArgumentNullException(nameof(rowOffset));
            return new OffsetRangeWithRowOffsetWithColumnOffsetRequestBuilder(CurrentPath + PathSegment , RequestAdapter, rowOffset, columnOffset, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.resizedRange(deltaRows={deltaRows},deltaColumns={deltaColumns})
        /// <param name="deltaColumns">Usage: deltaColumns={deltaColumns}</param>
        /// <param name="deltaRows">Usage: deltaRows={deltaRows}</param>
        /// </summary>
        public ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder resizedRangeWithDeltaRowsWithDeltaColumns(int? deltaRows, int? deltaColumns) {
            _ = deltaColumns ?? throw new ArgumentNullException(nameof(deltaColumns));
            _ = deltaRows ?? throw new ArgumentNullException(nameof(deltaRows));
            return new ResizedRangeWithDeltaRowsWithDeltaColumnsRequestBuilder(CurrentPath + PathSegment , RequestAdapter, deltaRows, deltaColumns, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsAbove()
        /// </summary>
        public RowsAboveRequestBuilder rowsAbove() {
            return new RowsAboveRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsAbove(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public RowsAboveWithCountRequestBuilder rowsAboveWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new RowsAboveWithCountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, count, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsBelow()
        /// </summary>
        public RowsBelowRequestBuilder rowsBelow() {
            return new RowsBelowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.rowsBelow(count={count})
        /// <param name="count">Usage: count={count}</param>
        /// </summary>
        public RowsBelowWithCountRequestBuilder rowsBelowWithCount(int? count) {
            _ = count ?? throw new ArgumentNullException(nameof(count));
            return new RowsBelowWithCountRequestBuilder(CurrentPath + PathSegment , RequestAdapter, count, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.row(row={row})
        /// <param name="row">Usage: row={row}</param>
        /// </summary>
        public RowWithRowRequestBuilder rowWithRow(int? row) {
            _ = row ?? throw new ArgumentNullException(nameof(row));
            return new RowWithRowRequestBuilder(CurrentPath + PathSegment , RequestAdapter, row, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.usedRange()
        /// </summary>
        public UsedRangeRequestBuilder usedRange() {
            return new UsedRangeRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.usedRange(valuesOnly={valuesOnly})
        /// <param name="valuesOnly">Usage: valuesOnly={valuesOnly}</param>
        /// </summary>
        public UsedRangeWithValuesOnlyRequestBuilder usedRangeWithValuesOnly(bool? valuesOnly) {
            _ = valuesOnly ?? throw new ArgumentNullException(nameof(valuesOnly));
            return new UsedRangeWithValuesOnlyRequestBuilder(CurrentPath + PathSegment , RequestAdapter, valuesOnly, false);
        }
        /// <summary>
        /// Builds and executes requests for operations under \users\{user-id}\insights\trending\{trending-id}\resource\microsoft.graph.workbookRange\microsoft.graph.visibleView()
        /// </summary>
        public VisibleViewRequestBuilder visibleView() {
            return new VisibleViewRequestBuilder(CurrentPath + PathSegment , RequestAdapter, false);
        }
    }
}
