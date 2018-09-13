using Util = Saklient.Util;

namespace Saklient.Cloud.Enums
{

	/// <summary>ストレージのクラスを表す列挙子。
	/// </summary>
	public class EStorageClass
	{
		
		static System.Collections.Generic.Dictionary<string, long?> _map_ = new System.Collections.Generic.Dictionary<string, long?>()
		{
			{ ISCSI1204, 110 }
		};
		
		/// <summary>ISCSI1204
		/// </summary>
		public static string ISCSI1204 = "iscsi1204";
		
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
