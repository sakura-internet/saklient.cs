using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Appliance = Saklient.Cloud.Resources.Appliance;
using LbVirtualIp = Saklient.Cloud.Resources.LbVirtualIp;
using Swytch = Saklient.Cloud.Resources.Swytch;
using Ipv4Net = Saklient.Cloud.Resources.Ipv4Net;
using EApplianceClass = Saklient.Cloud.Enums.EApplianceClass;

namespace Saklient.Cloud.Resources
{

	/// <summary>ロードバランサの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class LoadBalancer : Appliance
	{
		
		internal System.Collections.Generic.List<LbVirtualIp> _VirtualIps;
		
		public System.Collections.Generic.List<LbVirtualIp> Get_virtualIps()
		{
			return this._VirtualIps;
		}
		
		/// <summary>仮想IPアドレス <see cref="Saklient.Cloud.Resources.LbVirtualIp" /> の配列
		/// </summary>
		public System.Collections.Generic.List<LbVirtualIp> VirtualIps
		{
			get { return this.Get_virtualIps(); }
		}
		
		public string Get_defaultRoute()
		{
			return ((string)(Util.GetByPath(this.RawAnnotation, "Network.DefaultRoute")));
		}
		
		public string Set_defaultRoute(string v)
		{
			Util.SetByPath(this.RawAnnotation, "Network.DefaultRoute", v);
			return v;
		}
		
		/// <summary>デフォルトルート
		/// </summary>
		public string DefaultRoute
		{
			get { return this.Get_defaultRoute(); }
			set { this.Set_defaultRoute(value); }
		}
		
		public long Get_maskLen()
		{
			string maskLen = Util.GetByPath(this.RawAnnotation, "Network.NetworkMaskLen").ToString();
			if (maskLen == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return (long)System.Convert.ToInt64(""+maskLen);
		}
		
		public long Set_maskLen(long v)
		{
			Util.SetByPath(this.RawAnnotation, "Network.NetworkMaskLen", v);
			return v;
		}
		
		/// <summary>マスク長
		/// </summary>
		public long MaskLen
		{
			get { return this.Get_maskLen(); }
			set { this.Set_maskLen(value); }
		}
		
		public long Get_vrid()
		{
			string vrid = Util.GetByPath(this.RawAnnotation, "VRRP.VRID").ToString();
			if (vrid == null) {
				throw new SaklientException("invalid_data", "Data of the resource is invalid");
			}
			return (long)System.Convert.ToInt64(""+vrid);
		}
		
		public long Set_vrid(long v)
		{
			Util.SetByPath(this.RawAnnotation, "VRRP.VRID", v);
			return v;
		}
		
		/// <summary>VRID
		/// </summary>
		public long Vrid
		{
			get { return this.Get_vrid(); }
			set { this.Set_vrid(value); }
		}
		
		public LoadBalancer(Client client, object obj, bool wrapped=false) : base(client, obj, wrapped)
		{
			/*!base!*/;
			if (this.RawAnnotation == null) {
				this.RawAnnotation = new System.Collections.Generic.Dictionary<string, object> {};
			}
		}
		
		internal override void _OnAfterApiDeserialize(object r, object root)
		{
			if (this.RawAnnotation == null) {
				this.RawAnnotation = new System.Collections.Generic.Dictionary<string, object> {};
			}
			this._VirtualIps = new System.Collections.Generic.List<LbVirtualIp> {  };
			object settings = this.RawSettings;
			if (settings != null) {
				object lb = (settings as System.Collections.Generic.Dictionary<string, object>)["LoadBalancer"];
				if (lb == null) {
					lb = new System.Collections.Generic.List<object> {  };
				}
				System.Collections.Generic.List<object> vips = ((System.Collections.Generic.List<object>)(lb));
				for (int __it1=0; __it1 < (vips as System.Collections.IList).Count; __it1++) {
					var vip = vips[__it1];
					(this._VirtualIps as System.Collections.IList).Add(new LbVirtualIp(vip));
				}
			}
		}
		
		internal override void _OnBeforeApiSerialize(bool withClean)
		{
			System.Collections.Generic.List<object> lb = new System.Collections.Generic.List<object> {  };
			for (int __it1=0; __it1 < (this._VirtualIps as System.Collections.IList).Count; __it1++) {
				var vip = this._VirtualIps[__it1];
				(lb as System.Collections.IList).Add(vip.ToRawSettings());
			}
			if (this.RawSettings == null) {
				this.RawSettings = new System.Collections.Generic.Dictionary<string, object> {};
			}
			(this.RawSettings as System.Collections.Generic.Dictionary<string, object>)["LoadBalancer"] = lb;
			if (this.IsNew) {
				this.Clazz = EApplianceClass.LOADBALANCER;
			}
		}

        /// <summary>
        /// </summary>
        /// <param name="swytch" />
        /// <param name="vrid" />
        /// <param name="realIps" />
        /// <param name="isHighSpec" />
        public LoadBalancer SetInitialParams(Swytch swytch, long vrid, System.Collections.Generic.List<string> realIps, bool isHighSpec=false)
		{
			object annot = this.RawAnnotation;
			this.Vrid = vrid;
			Util.SetByPath(annot, "Switch.ID", swytch._Id());
			if (swytch.Ipv4Nets != null && 0 < swytch.Ipv4Nets.Count) {
				Ipv4Net net = swytch.Ipv4Nets[System.Convert.ToInt32(0)];
				this.DefaultRoute = ((string)(net.DefaultRoute));
				this.MaskLen = System.Convert.ToInt64(net.MaskLen);
			}
			else {
				this.DefaultRoute = ((string)(swytch.UserDefaultRoute));
				this.MaskLen = System.Convert.ToInt64(swytch.UserMaskLen);
			}
			System.Collections.Generic.List<object> servers = new System.Collections.Generic.List<object> {  };
			for (int __it1=0; __it1 < (realIps as System.Collections.IList).Count; __it1++) {
				var ip = realIps[__it1];
				(servers as System.Collections.IList).Add(new System.Collections.Generic.Dictionary<string, object> { { "IPAddress", ip } });
			}
			Util.SetByPath(annot, "Servers", servers);
			this.PlanId = isHighSpec ? 2 : 1;
			return this;
		}
		
		public LoadBalancer ClearVirtualIps()
		{
			while (0 < this._VirtualIps.Count) {
				Util.Pop(this._VirtualIps);
			}
			return this;
		}

        /// <summary>仮想IPアドレス設定を追加します。
        /// </summary>
        /// <param name="settings">設定オブジェクト</param>
        public LbVirtualIp AddVirtualIp(object settings=null)
		{
			LbVirtualIp ret = new LbVirtualIp(settings);
			(this._VirtualIps as System.Collections.IList).Add(ret);
			return ret;
		}

        /// <summary>指定したIPアドレスにマッチする仮想IPアドレス設定を取得します。
        /// </summary>
        /// <param name="address" />
        public LbVirtualIp GetVirtualIpByAddress(string address)
		{
			for (int __it1=0; __it1 < (this._VirtualIps as System.Collections.IList).Count; __it1++) {
				var vip = this._VirtualIps[__it1];
				if (vip.VirtualIpAddress == address) {
					return vip;
				}
			}
			return null;
		}
		
		/// <summary>監視対象サーバのステータスを最新の状態に更新します。
		/// </summary>
		public LoadBalancer ReloadStatus()
		{
			object result = this.RequestRetry("GET", this._ApiPath() + "/" + Util.UrlEncode(this._Id()) + "/status");
			if (result != null && (result as System.Collections.Generic.Dictionary<string, object>).ContainsKey("LoadBalancer")) {
				System.Collections.Generic.List<object> vips = ((System.Collections.Generic.List<object>)((result as System.Collections.Generic.Dictionary<string, object>)["LoadBalancer"]));
				for (int __it1=0; __it1 < (vips as System.Collections.IList).Count; __it1++) {
					var vipDyn = vips[__it1];
					string vipStr = ((string)((vipDyn as System.Collections.Generic.Dictionary<string, object>)["VirtualIPAddress"]));
					LbVirtualIp vip = this.GetVirtualIpByAddress(vipStr);
					if (vip == null) {
						continue;
					}
					vip.UpdateStatus(((System.Collections.Generic.List<object>)((vipDyn as System.Collections.Generic.Dictionary<string, object>)["Servers"])));
				}
			}
			return this;
		}
		
	}
	
}
