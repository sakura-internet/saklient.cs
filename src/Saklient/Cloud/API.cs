using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Product = Saklient.Cloud.Product;
using Facility = Saklient.Cloud.Facility;
using Model_Icon = Saklient.Cloud.Models.Model_Icon;
using Model_Server = Saklient.Cloud.Models.Model_Server;
using Model_Disk = Saklient.Cloud.Models.Model_Disk;
using Model_Appliance = Saklient.Cloud.Models.Model_Appliance;
using Model_Archive = Saklient.Cloud.Models.Model_Archive;
using Model_CommonServiceItem = Saklient.Cloud.Models.Model_CommonServiceItem;
using Model_IsoImage = Saklient.Cloud.Models.Model_IsoImage;
using Model_Iface = Saklient.Cloud.Models.Model_Iface;
using Model_Swytch = Saklient.Cloud.Models.Model_Swytch;
using Model_Router = Saklient.Cloud.Models.Model_Router;
using Model_Bridge = Saklient.Cloud.Models.Model_Bridge;
using Model_Ipv6Net = Saklient.Cloud.Models.Model_Ipv6Net;
using Model_Script = Saklient.Cloud.Models.Model_Script;
using Model_License = Saklient.Cloud.Models.Model_License;

namespace Saklient.Cloud
{

	/// <summary>さくらのクラウドAPIクライアントを利用する際、最初にアクセスすべきルートとなるクラス。
	/// 
	/// <seealso cref="API.Authorize" />
	/// </summary>
	public class API
	{
		
		internal Client _Client;
		
		internal Client Get_client()
		{
			return this._Client;
		}
		
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		internal Product _Product;
		
		internal Product Get_product()
		{
			return this._Product;
		}
		
		/// <summary>商品情報にアクセスするためのモデルを集めたオブジェクト。
		/// </summary>
		public Product Product
		{
			get { return this.Get_product(); }
		}
		
		internal Facility _Facility;
		
		internal Facility Get_facility()
		{
			return this._Facility;
		}
		
		/// <summary>設備情報にアクセスするためのモデルを集めたオブジェクト。
		/// </summary>
		public Facility Facility
		{
			get { return this.Get_facility(); }
		}
		
		internal Model_Icon _Icon;
		
		internal Model_Icon Get_icon()
		{
			return this._Icon;
		}
		
		/// <summary>アイコンにアクセスするためのモデル。
		/// </summary>
		public Model_Icon Icon
		{
			get { return this.Get_icon(); }
		}
		
		internal Model_Server _Server;
		
		internal Model_Server Get_server()
		{
			return this._Server;
		}
		
		/// <summary>サーバにアクセスするためのモデル。
		/// </summary>
		public Model_Server Server
		{
			get { return this.Get_server(); }
		}
		
		internal Model_Disk _Disk;
		
		internal Model_Disk Get_disk()
		{
			return this._Disk;
		}
		
		/// <summary>ディスクにアクセスするためのモデル。
		/// </summary>
		public Model_Disk Disk
		{
			get { return this.Get_disk(); }
		}
		
		internal Model_Appliance _Appliance;
		
		internal Model_Appliance Get_appliance()
		{
			return this._Appliance;
		}
		
		/// <summary>アプライアンスにアクセスするためのモデル。
		/// </summary>
		public Model_Appliance Appliance
		{
			get { return this.Get_appliance(); }
		}
		
		internal Model_Archive _Archive;
		
		internal Model_Archive Get_archive()
		{
			return this._Archive;
		}
		
		/// <summary>アーカイブにアクセスするためのモデル。
		/// </summary>
		public Model_Archive Archive
		{
			get { return this.Get_archive(); }
		}
		
		internal Model_IsoImage _IsoImage;
		
		internal Model_IsoImage Get_isoImage()
		{
			return this._IsoImage;
		}
		
		/// <summary>ISOイメージにアクセスするためのモデル。
		/// </summary>
		public Model_IsoImage IsoImage
		{
			get { return this.Get_isoImage(); }
		}
		
		internal Model_Iface _Iface;
		
		internal Model_Iface Get_iface()
		{
			return this._Iface;
		}
		
		/// <summary>インタフェースにアクセスするためのモデル。
		/// </summary>
		public Model_Iface Iface
		{
			get { return this.Get_iface(); }
		}
		
		internal Model_Swytch _Swytch;
		
		internal Model_Swytch Get_swytch()
		{
			return this._Swytch;
		}
		
		/// <summary>スイッチにアクセスするためのモデル。
		/// </summary>
		public Model_Swytch Swytch
		{
			get { return this.Get_swytch(); }
		}
		
		internal Model_Router _Router;
		
		internal Model_Router Get_router()
		{
			return this._Router;
		}
		
		/// <summary>ルータにアクセスするためのモデル。
		/// </summary>
		public Model_Router Router
		{
			get { return this.Get_router(); }
		}
		
		internal Model_Bridge _Bridge;
		
		internal Model_Bridge Get_bridge()
		{
			return this._Bridge;
		}
		
		/// <summary>ブリッジにアクセスするためのモデル。
		/// </summary>
		public Model_Bridge Bridge
		{
			get { return this.Get_bridge(); }
		}
		
		internal Model_Ipv6Net _Ipv6Net;
		
		internal Model_Ipv6Net Get_ipv6Net()
		{
			return this._Ipv6Net;
		}
		
		/// <summary>IPv6ネットワークにアクセスするためのモデル。
		/// </summary>
		public Model_Ipv6Net Ipv6Net
		{
			get { return this.Get_ipv6Net(); }
		}
		
		internal Model_Script _Script;
		
		internal Model_Script Get_script()
		{
			return this._Script;
		}
		
		/// <summary>スクリプトにアクセスするためのモデル。
		/// </summary>
		public Model_Script Script
		{
			get { return this.Get_script(); }
		}
		
		internal Model_CommonServiceItem _CommonServiceItem;
		
		internal Model_CommonServiceItem Get_commonServiceItem()
		{
			return this._CommonServiceItem;
		}
		
		/// <summary>共通サービス契約にアクセスするためのモデル。
		/// </summary>
		public Model_CommonServiceItem CommonServiceItem
		{
			get { return this.Get_commonServiceItem(); }
		}
		
		internal Model_License _License;
		
		internal Model_License Get_license()
		{
			return this._License;
		}
		
		/// <summary>ライセンスにアクセスするためのモデル。
		/// </summary>
		public Model_License License
		{
			get { return this.Get_license(); }
		}

        /// <summary>
        /// </summary>
        /// <param name="client" />
        internal API(Client client)
		{
			this._Client = client;
			this._Product = new Product(client);
			this._Facility = new Facility(client);
			this._Icon = new Model_Icon(client);
			this._Server = new Model_Server(client);
			this._Disk = new Model_Disk(client);
			this._Appliance = new Model_Appliance(client);
			this._Archive = new Model_Archive(client);
			this._IsoImage = new Model_IsoImage(client);
			this._Iface = new Model_Iface(client);
			this._Swytch = new Model_Swytch(client);
			this._Router = new Model_Router(client);
			this._Bridge = new Model_Bridge(client);
			this._Ipv6Net = new Model_Ipv6Net(client);
			this._Script = new Model_Script(client);
			this._CommonServiceItem = new Model_CommonServiceItem(client);
			this._License = new Model_License(client);
		}

        /// <summary>指定した認証情報を用いてアクセスを行うAPIクライアントを作成します。
        /// 必要な認証情報は、コントロールパネル右上にあるアカウントのプルダウンから
        /// 「設定」を選択し、「APIキー」のページにて作成できます。
        /// </summary>
        /// <param name="token">ACCESS TOKEN</param>
        /// <param name="secret">ACCESS TOKEN SECRET</param>
        /// <param name="zone">ゾーン名</param>
        /// <returns>APIクライアント</returns>
        public static API Authorize(string token, string secret, string zone=null)
		{
			Client c = new Client(token, secret);
			API ret = new API(c);
			return zone != null ? ret.InZone(zone) : ret;
		}

        /// <summary>認証情報を引き継ぎ、指定したゾーンへのアクセスを行うAPIクライアントを作成します。
        /// </summary>
        /// <param name="name">ゾーン名</param>
        /// <returns>APIクライアント</returns>
        public API InZone(string name)
		{
			API ret = new API(this._Client.CloneInstance());
			string suffix = "";
			if (name == "is1x" || name == "is1y") {
				suffix = "-test";
			}
			ret._Client.SetApiRoot("https://secure.sakura.ad.jp/cloud" + suffix + "/");
			ret._Client.SetApiRootSuffix("zone/" + name);
			return ret;
		}
		
	}
	
}
