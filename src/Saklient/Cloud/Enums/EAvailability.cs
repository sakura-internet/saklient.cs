using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * リソースの有効性を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EAvailability
	 * @class EAvailability
	 */
	class EAvailability
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Selectable", 69 },
			{ "Migrating", 70 },
			{ "Precreate", 71 },
			{ "Replicating", 72 },
			{ "Transfering", 73 },
			{ "Stopped", 75 },
			{ "Failed", 78 },
			{ "Charged", 79 },
			{ "Uploading", 80 },
			{ "Available", 100 }
		};
		
		/**
		 * @property Selectable
		 * @default "Selectable"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Selectable = "Selectable";
		
		/**
		 * @property Migrating
		 * @default "Migrating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Migrating = "Migrating";
		
		/**
		 * @property Precreate
		 * @default "Precreate"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Precreate = "Precreate";
		
		/**
		 * @property Replicating
		 * @default "Replicating"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Replicating = "Replicating";
		
		/**
		 * @property Transfering
		 * @default "Transfering"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Transfering = "Transfering";
		
		/**
		 * @property Stopped
		 * @default "Stopped"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Stopped = "Stopped";
		
		/**
		 * @property Failed
		 * @default "Failed"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Failed = "Failed";
		
		/**
		 * @property Charged
		 * @default "Charged"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Charged = "Charged";
		
		/**
		 * @property Uploading
		 * @default "Uploading"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Uploading = "Uploading";
		
		/**
		 * @property Available
		 * @default "Available"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Available = "Available";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EAvailability._map_[lhs];
			int? r = EAvailability._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
