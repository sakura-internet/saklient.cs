using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * ディスクの接続方式を表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EDiskConnection
	 * @class EDiskConnection
	 */
	public class EDiskConnection
	{
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
		{
			{ "ide", 100 },
			{ "virtio", 300 }
		};
		
		/**
		 * @property Ide
		 * @default "ide"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Ide = "ide";
		
		/**
		 * @property Virtio
		 * @default "virtio"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Virtio = "virtio";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EDiskConnection._map_[lhs];
			long? r = EDiskConnection._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
