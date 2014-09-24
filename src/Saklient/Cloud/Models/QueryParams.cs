using Util = Saklient.Util;

namespace Saklient.Cloud.Models
{

	/// <summary>
	/// 
	/// </summary>
	public class QueryParams
	{
		
		public long Begin;
		
		public long Count;
		
		public object Filter;
		
		public System.Collections.Generic.List<string> Sort;
		
		public QueryParams()
		{
			this.Begin = 0;
			this.Count = 0;
			this.Filter = new System.Collections.Generic.Dictionary<string, object> {};
			this.Sort = new System.Collections.Generic.List<string> {  };
		}
		
		public object Build()
		{
			return new System.Collections.Generic.Dictionary<string, object> {
				{ "From", this.Begin },
				{ "Count", this.Count },
				{ "Filter", this.Filter },
				{ "Sort", this.Sort }
			};
		}
		
	}
	
}
