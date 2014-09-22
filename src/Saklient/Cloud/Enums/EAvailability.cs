using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * リソースの有効性を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EAvailability
	 * @class EAvailability
	 */
	public class EAvailability
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ "selectable", 69 },
			{ "migrating", 70 },
			{ "precreate", 71 },
			{ "replicating", 72 },
			{ "transfering", 73 },
			{ "stopped", 75 },
			{ "failed", 78 },
			{ "charged", 79 },
			{ "uploading", 80 },
			{ "available", 100 }
		};
		
		/**
		 * @property SELECTABLE
		 * @default "selectable"
		 * @type string
		 * @static
		 * @public
		 */
		public static string SELECTABLE = "selectable";
		
		/**
		 * @property MIGRATING
		 * @default "migrating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string MIGRATING = "migrating";
		
		/**
		 * @property PRECREATE
		 * @default "precreate"
		 * @type string
		 * @static
		 * @public
		 */
		public static string PRECREATE = "precreate";
		
		/**
		 * @property REPLICATING
		 * @default "replicating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string REPLICATING = "replicating";
		
		/**
		 * @property TRANSFERING
		 * @default "transfering"
		 * @type string
		 * @static
		 * @public
		 */
		public static string TRANSFERING = "transfering";
		
		/**
		 * @property STOPPED
		 * @default "stopped"
		 * @type string
		 * @static
		 * @public
		 */
		public static string STOPPED = "stopped";
		
		/**
		 * @property FAILED
		 * @default "failed"
		 * @type string
		 * @static
		 * @public
		 */
		public static string FAILED = "failed";
		
		/**
		 * @property CHARGED
		 * @default "charged"
		 * @type string
		 * @static
		 * @public
		 */
		public static string CHARGED = "charged";
		
		/**
		 * @property UPLOADING
		 * @default "uploading"
		 * @type string
		 * @static
		 * @public
		 */
		public static string UPLOADING = "uploading";
		
		/**
		 * @property AVAILABLE
		 * @default "available"
		 * @type string
		 * @static
		 * @public
		 */
		public static string AVAILABLE = "available";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = lhs!=null && _map_.ContainsKey(lhs) ? _map_[lhs] : null;
			long? r = rhs!=null && _map_.ContainsKey(rhs) ? _map_[rhs] : null;
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
