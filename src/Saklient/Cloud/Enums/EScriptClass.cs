using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>スクリプトのクラスを表す列挙子。
	/// </summary>
	public class EScriptClass
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ SHELL, 200 },
			{ ANSIBLE, 300 }
		};
		
		/// <summary>SHELL
		/// </summary>
		public static string SHELL = "shell";
		
		/// <summary>ANSIBLE
		/// </summary>
		public static string ANSIBLE = "ansible";
		
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
