using System;
namespace hotels_api.Models.QueryParamters
{
	public class QueryParameters
	{
		private int _pageSize = 15;
        public int PageNumber { get; set; }
        public int StartIndex { get; set; }

		public int PageSize
		{
			get
			{
				return _pageSize;
			}
			set
			{
				_pageSize = value;
			}
		}

	}

	public class PageResult<T>
	{
		public int TotalCount { get; set; }
		public int PageNumber { get; set; }
		public int RecordNumber { get; set; }
		public List<T>? Items { get; set; }

	}
}
