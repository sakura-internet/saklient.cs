using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * アプライアンスのクラスを表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EApplianceClass
	 * @class EApplianceClass
	 */
	public class EApplianceClass
	{
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
		{
			{ "loadbalancer", 10 },
			{ "vpcrouter", 20 }
		};
		
		/**
		 * @property Loadbalancer
		 * @default "loadbalancer"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Loadbalancer = "loadbalancer";
		
		/**
		 * @property Vpcrouter
		 * @default "vpcrouter"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Vpcrouter = "vpcrouter";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EApplianceClass._map_[lhs];
			long? r = EApplianceClass._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
