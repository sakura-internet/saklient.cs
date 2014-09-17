using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * ディスクの接続方式を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EDiskConnection
	 * @class EDiskConnection
	 */
	class EDiskConnection
	{
		
		static System.Collections.Generic.Dictionary<string, int> _map_ = new System.Collections.Generic.Dictionary<string, int>()
		{
			{ "Ide", 100 },
			{ "Virtio", 300 }
		};
		
		/**
		 * @property Ide
		 * @default "Ide"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Ide = "Ide";
		
		/**
		 * @property Virtio
		 * @default "Virtio"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Virtio = "Virtio";
		
		public static int? Compare(string lhs, string rhs)
		{
			int? l = EDiskConnection._map_[lhs];
			int? r = EDiskConnection._map_[rhs];
			if (l==null || r==null) return null;
			int ret = (int)l - (int)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
