using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>
	/// 
	/// </summary>
	public class IfaceActivitySample
	{
		
		internal System.DateTime _At;
		
		public System.DateTime Get_at()
		{
			return this._At;
		}
		
		/// <summary>記録日時
		/// </summary>
		public System.DateTime At
		{
			get { return this.Get_at(); }
		}
		
		internal bool _IsAvailable;
		
		public bool Get_isAvailable()
		{
			return this._IsAvailable;
		}
		
		/// <summary>有効な値のとき真
		/// </summary>
		public bool IsAvailable
		{
			get { return this.Get_isAvailable(); }
		}
		
		internal double _Send;
		
		public double Get_send()
		{
			return this._Send;
		}
		
		/// <summary>送信[byte/sec]
		/// </summary>
		public double Send
		{
			get { return this.Get_send(); }
		}
		
		internal double _Receive;
		
		public double Get_receive()
		{
			return this._Receive;
		}
		
		/// <summary>受信[byte/sec]
		/// </summary>
		public double Receive
		{
			get { return this.Get_receive(); }
		}
		
		/// <summary>
		/// <param name="atStr" />
		/// <param name="data" />
		/// </summary>
		public IfaceActivitySample(string atStr, object data)
		{
			this._At = ((System.DateTime)(Util.Str2date(atStr)));
			this._IsAvailable = true;
			object v = null;
			v = (data as System.Collections.Generic.Dictionary<string, object>)["Send"];
			if (v == null) {
				this._IsAvailable = false;
			}
			else {
				this._Send = ((double)(v));
			}
			v = (data as System.Collections.Generic.Dictionary<string, object>)["Receive"];
			if (v == null) {
				this._IsAvailable = false;
			}
			else {
				this._Receive = ((double)(v));
			}
		}
		
	}
	
}
