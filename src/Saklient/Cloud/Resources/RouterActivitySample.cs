using Util = Saklient.Util;

namespace Saklient.Cloud.Resources
{

	/// <summary>
	/// 
	/// </summary>
	public class RouterActivitySample
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
		
		internal double _Outgoing;
		
		public double Get_outgoing()
		{
			return this._Outgoing;
		}
		
		/// <summary>送信[BPS]
		/// </summary>
		public double Outgoing
		{
			get { return this.Get_outgoing(); }
		}
		
		internal double _Incoming;
		
		public double Get_incoming()
		{
			return this._Incoming;
		}
		
		/// <summary>受信[BPS]
		/// </summary>
		public double Incoming
		{
			get { return this.Get_incoming(); }
		}
		
		/// <summary>
		/// <param name="atStr" />
		/// <param name="data" />
		/// </summary>
		public RouterActivitySample(string atStr, object data)
		{
			this._At = ((System.DateTime)(Util.Str2date(atStr)));
			this._IsAvailable = true;
			object v = null;
			v = (data as System.Collections.Generic.Dictionary<string, object>)["Out"];
			if (v == null) {
				this._IsAvailable = false;
			}
			else {
				this._Outgoing = ((double)(v));
			}
			v = (data as System.Collections.Generic.Dictionary<string, object>)["In"];
			if (v == null) {
				this._IsAvailable = false;
			}
			else {
				this._Incoming = ((double)(v));
			}
		}
		
	}
	
}
