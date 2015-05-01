using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>IPv4ネットワークのIPアドレス範囲。
	/// </summary>
	public class Ipv4Range
	{
		
		internal string _First;
		
		public string Get_first()
		{
			return this._First;
		}
		
		/// <summary>開始アドレス
		/// </summary>
		public string First
		{
			get { return this.Get_first(); }
		}
		
		internal string _Last;
		
		public string Get_last()
		{
			return this._Last;
		}
		
		/// <summary>終了アドレス
		/// </summary>
		public string Last
		{
			get { return this.Get_last(); }
		}
		
		internal System.Collections.Generic.List<string> _AsArray;
		
		public System.Collections.Generic.List<string> Get_asArray()
		{
			System.Collections.Generic.List<string> ret = new System.Collections.Generic.List<string> {  };
			long i = Util.Ip2long(this._First);
			long i1 = Util.Ip2long(this._Last);
			while (i <= i1) {
				(ret as System.Collections.IList).Add(Util.Long2ip(i));
				i++;
			}
			return ret;
		}
		
		/// <summary>この範囲に属するIPv4アドレスの一覧を取得します。
		/// </summary>
		public System.Collections.Generic.List<string> AsArray
		{
			get { return this.Get_asArray(); }
		}
		
		public Ipv4Range(object obj=null)
		{
			if (obj == null) {
				obj = new System.Collections.Generic.Dictionary<string, object> {};
			}
			object first = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Min", "min" });
			this._First = null;
			if (first != null) {
				this._First = ((string)(first));
			}
			if (this._First != null && this._First == "") {
				this._First = null;
			}
			object last = Util.GetByPathAny(new System.Collections.Generic.List<object> { obj }, new System.Collections.Generic.List<string> { "Max", "max" });
			this._Last = null;
			if (last != null) {
				this._Last = ((string)(last));
			}
			if (this._Last != null && this._Last == "") {
				this._Last = null;
			}
		}
		
	}
	
}
