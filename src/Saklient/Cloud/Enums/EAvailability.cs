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
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
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
		 * @property Selectable
		 * @default "selectable"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Selectable = "selectable";
		
		/**
		 * @property Migrating
		 * @default "migrating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Migrating = "migrating";
		
		/**
		 * @property Precreate
		 * @default "precreate"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Precreate = "precreate";
		
		/**
		 * @property Replicating
		 * @default "replicating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Replicating = "replicating";
		
		/**
		 * @property Transfering
		 * @default "transfering"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Transfering = "transfering";
		
		/**
		 * @property Stopped
		 * @default "stopped"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Stopped = "stopped";
		
		/**
		 * @property Failed
		 * @default "failed"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Failed = "failed";
		
		/**
		 * @property Charged
		 * @default "charged"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Charged = "charged";
		
		/**
		 * @property Uploading
		 * @default "uploading"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Uploading = "uploading";
		
		/**
		 * @property Available
		 * @default "available"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Available = "available";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EAvailability._map_[lhs];
			long? r = EAvailability._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
