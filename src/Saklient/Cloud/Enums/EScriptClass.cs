using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/**
	 * スクリプトのクラスを表す列挙子。
	 * 
	 * @module saklient.cloud.enums.EScriptClass
	 * @class EScriptClass
	 */
	public class EScriptClass
	{
		
		static System.Collections.Generic.Dictionary<string, long> _map_ = new System.Collections.Generic.Dictionary<string, long>()
		{
			{ "shell", 200 },
			{ "ansible", 300 }
		};
		
		/**
		 * @property Shell
		 * @default "shell"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Shell = "shell";
		
		/**
		 * @property Ansible
		 * @default "ansible"
		 * @type string
		 * @static
		 * @public
		 */
		public static string Ansible = "ansible";
		
		public static long? Compare(string lhs, string rhs)
		{
			long? l = EScriptClass._map_[lhs];
			long? r = EScriptClass._map_[rhs];
			if (l==null || r==null) return null;
			long ret = (long)l - (long)r;
			return 0 < ret ? 1 : (ret < 0 ? -1 : 0);
		}
		
	}
	
}
