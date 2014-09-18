using Util = Saklient.Util;

namespace Saklient.Cloud.Models
{

	/**
	 * @ignore
	 * @module saklient.cloud.models.QueryParams
	 * @class QueryParams
	 * @constructor
	 */
	public class QueryParams
	{
		
		/**
		 * @member saklient.cloud.models.QueryParams#Begin
		 * @type long
		 * @public
		 */
		public long Begin;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Count
		 * @type long
		 * @public
		 */
		public long Count;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Filter
		 * @type object
		 * @public
		 */
		public object Filter;
		
		/**
		 * @member saklient.cloud.models.QueryParams#Sort
		 * @type System.Collections.Generic.List<string>
		 * @public
		 */
		public System.Collections.Generic.List<string> Sort;
		
		/**
		 * @constructor
		 * @public
		 */
		public QueryParams()
		{
			this.Begin = 0;
			this.Count = 0;
			this.Filter = new System.Collections.Generic.Dictionary<string, object> {};
			this.Sort = new System.Collections.Generic.List<string> {  };
		}
		
		/**
		 * @method Build
		 * @public
		 * @return {object}
		 */
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
