using Util = Saklient.Util;

namespace Saklient.Cloud.Models
{

	/**
	 * @ignore
	 * @module saklient.cloud.models.QueryParams
	 * @class QueryParams
	 * @constructor
	 */
	class QueryParams
	{
		
		/**
		 * @member saklient.cloud.models.QueryParams#Begin
		 * @type int
		 * @public
		 */
		public int Begin;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Count
		 * @type int
		 * @public
		 */
		public int Count;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Filter
		 * @type dynamic
		 * @public
		 */
		public dynamic Filter;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Sort
		 * @type dynamic[]
		 * @public
		 */
		public dynamic[] Sort;
		
		/**
		 * @constructor
		 * @public
		 */
		public QueryParams()
		{
			this.Begin = 0;
			this.Count = 0;
			this.Filter = new System.Collections.Generic.Dictionary<string, object> {};
			this.Sort = new dynamic[] {  };
		}
		
		/**
		 * @method Build
		 * @public
		 * @return {dynamic}
		 */
		public dynamic Build()
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
