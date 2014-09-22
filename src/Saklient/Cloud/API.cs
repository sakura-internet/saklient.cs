using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Product = Saklient.Cloud.Product;
using Model_Icon = Saklient.Cloud.Models.Model_Icon;
using Model_Server = Saklient.Cloud.Models.Model_Server;
using Model_Disk = Saklient.Cloud.Models.Model_Disk;
using Model_Appliance = Saklient.Cloud.Models.Model_Appliance;
using Model_Archive = Saklient.Cloud.Models.Model_Archive;
using Model_IsoImage = Saklient.Cloud.Models.Model_IsoImage;
using Model_Iface = Saklient.Cloud.Models.Model_Iface;
using Model_Swytch = Saklient.Cloud.Models.Model_Swytch;
using Model_Router = Saklient.Cloud.Models.Model_Router;
using Model_Ipv6Net = Saklient.Cloud.Models.Model_Ipv6Net;
using Model_Script = Saklient.Cloud.Models.Model_Script;

namespace Saklient.Cloud
{

	/**
	 * さくらのクラウドAPIクライアントを利用する際、最初にアクセスすべきルートとなるクラス。
	 * 
	 * @see API.authorize
	 * @module saklient.cloud.API
	 * @class API
	 * @constructor
	 */
	public class API
	{
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _Client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._Client;
		}
		
		/**
		 * @ignore
		 * @property Client
		 * @type Client
		 * @readOnly
		 */
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Product
		 * @type Product
		 * @internal
		 * @ignore
		 */
		internal Product _Product;
		
		/**
		 * @method Get_product
		 * @internal
		 * @ignore
		 * @return {Product}
		 */
		internal Product Get_product()
		{
			return this._Product;
		}
		
		/**
		 * 商品情報にアクセスするためのモデルを集めたオブジェクト。
		 * 
		 * @property Product
		 * @type Product
		 * @readOnly
		 * @public
		 */
		public Product Product
		{
			get { return this.Get_product(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Icon
		 * @type Model_Icon
		 * @internal
		 * @ignore
		 */
		internal Model_Icon _Icon;
		
		/**
		 * @method Get_icon
		 * @internal
		 * @ignore
		 * @return {Model_Icon}
		 */
		internal Model_Icon Get_icon()
		{
			return this._Icon;
		}
		
		/**
		 * アイコンにアクセスするためのモデル。
		 * 
		 * @property Icon
		 * @type Model_Icon
		 * @readOnly
		 * @public
		 */
		public Model_Icon Icon
		{
			get { return this.Get_icon(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Server
		 * @type Model_Server
		 * @internal
		 * @ignore
		 */
		internal Model_Server _Server;
		
		/**
		 * @method Get_server
		 * @internal
		 * @ignore
		 * @return {Model_Server}
		 */
		internal Model_Server Get_server()
		{
			return this._Server;
		}
		
		/**
		 * サーバにアクセスするためのモデル。
		 * 
		 * @property Server
		 * @type Model_Server
		 * @readOnly
		 * @public
		 */
		public Model_Server Server
		{
			get { return this.Get_server(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Disk
		 * @type Model_Disk
		 * @internal
		 * @ignore
		 */
		internal Model_Disk _Disk;
		
		/**
		 * @method Get_disk
		 * @internal
		 * @ignore
		 * @return {Model_Disk}
		 */
		internal Model_Disk Get_disk()
		{
			return this._Disk;
		}
		
		/**
		 * ディスクにアクセスするためのモデル。
		 * 
		 * @property Disk
		 * @type Model_Disk
		 * @readOnly
		 * @public
		 */
		public Model_Disk Disk
		{
			get { return this.Get_disk(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Appliance
		 * @type Model_Appliance
		 * @internal
		 * @ignore
		 */
		internal Model_Appliance _Appliance;
		
		/**
		 * @method Get_appliance
		 * @internal
		 * @ignore
		 * @return {Model_Appliance}
		 */
		internal Model_Appliance Get_appliance()
		{
			return this._Appliance;
		}
		
		/**
		 * アプライアンスにアクセスするためのモデル。
		 * 
		 * @property Appliance
		 * @type Model_Appliance
		 * @readOnly
		 * @public
		 */
		public Model_Appliance Appliance
		{
			get { return this.Get_appliance(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Archive
		 * @type Model_Archive
		 * @internal
		 * @ignore
		 */
		internal Model_Archive _Archive;
		
		/**
		 * @method Get_archive
		 * @internal
		 * @ignore
		 * @return {Model_Archive}
		 */
		internal Model_Archive Get_archive()
		{
			return this._Archive;
		}
		
		/**
		 * アーカイブにアクセスするためのモデル。
		 * 
		 * @property Archive
		 * @type Model_Archive
		 * @readOnly
		 * @public
		 */
		public Model_Archive Archive
		{
			get { return this.Get_archive(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_IsoImage
		 * @type Model_IsoImage
		 * @internal
		 * @ignore
		 */
		internal Model_IsoImage _IsoImage;
		
		/**
		 * @method Get_isoImage
		 * @internal
		 * @ignore
		 * @return {Model_IsoImage}
		 */
		internal Model_IsoImage Get_isoImage()
		{
			return this._IsoImage;
		}
		
		/**
		 * ISOイメージにアクセスするためのモデル。
		 * 
		 * @property IsoImage
		 * @type Model_IsoImage
		 * @readOnly
		 * @public
		 */
		public Model_IsoImage IsoImage
		{
			get { return this.Get_isoImage(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Iface
		 * @type Model_Iface
		 * @internal
		 * @ignore
		 */
		internal Model_Iface _Iface;
		
		/**
		 * @method Get_iface
		 * @internal
		 * @ignore
		 * @return {Model_Iface}
		 */
		internal Model_Iface Get_iface()
		{
			return this._Iface;
		}
		
		/**
		 * インタフェースにアクセスするためのモデル。
		 * 
		 * @property Iface
		 * @type Model_Iface
		 * @readOnly
		 * @public
		 */
		public Model_Iface Iface
		{
			get { return this.Get_iface(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Swytch
		 * @type Model_Swytch
		 * @internal
		 * @ignore
		 */
		internal Model_Swytch _Swytch;
		
		/**
		 * @method Get_swytch
		 * @internal
		 * @ignore
		 * @return {Model_Swytch}
		 */
		internal Model_Swytch Get_swytch()
		{
			return this._Swytch;
		}
		
		/**
		 * スイッチにアクセスするためのモデル。
		 * 
		 * @property Swytch
		 * @type Model_Swytch
		 * @readOnly
		 * @public
		 */
		public Model_Swytch Swytch
		{
			get { return this.Get_swytch(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Router
		 * @type Model_Router
		 * @internal
		 * @ignore
		 */
		internal Model_Router _Router;
		
		/**
		 * @method Get_router
		 * @internal
		 * @ignore
		 * @return {Model_Router}
		 */
		internal Model_Router Get_router()
		{
			return this._Router;
		}
		
		/**
		 * ルータにアクセスするためのモデル。
		 * 
		 * @property Router
		 * @type Model_Router
		 * @readOnly
		 * @public
		 */
		public Model_Router Router
		{
			get { return this.Get_router(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Ipv6Net
		 * @type Model_Ipv6Net
		 * @internal
		 * @ignore
		 */
		internal Model_Ipv6Net _Ipv6Net;
		
		/**
		 * @method Get_ipv6Net
		 * @internal
		 * @ignore
		 * @return {Model_Ipv6Net}
		 */
		internal Model_Ipv6Net Get_ipv6Net()
		{
			return this._Ipv6Net;
		}
		
		/**
		 * IPv6ネットワークにアクセスするためのモデル。
		 * 
		 * @property Ipv6Net
		 * @type Model_Ipv6Net
		 * @readOnly
		 * @public
		 */
		public Model_Ipv6Net Ipv6Net
		{
			get { return this.Get_ipv6Net(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.API#_Script
		 * @type Model_Script
		 * @internal
		 * @ignore
		 */
		internal Model_Script _Script;
		
		/**
		 * @method Get_script
		 * @internal
		 * @ignore
		 * @return {Model_Script}
		 */
		internal Model_Script Get_script()
		{
			return this._Script;
		}
		
		/**
		 * スクリプトにアクセスするためのモデル。
		 * 
		 * @property Script
		 * @type Model_Script
		 * @readOnly
		 * @public
		 */
		public Model_Script Script
		{
			get { return this.Get_script(); }
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @internal
		 * @param {Client} client
		 */
		internal API(Client client)
		{
			this._Client = client;
			this._Product = new Product(client);
			this._Icon = new Model_Icon(client);
			this._Server = new Model_Server(client);
			this._Disk = new Model_Disk(client);
			this._Appliance = new Model_Appliance(client);
			this._Archive = new Model_Archive(client);
			this._IsoImage = new Model_IsoImage(client);
			this._Iface = new Model_Iface(client);
			this._Swytch = new Model_Swytch(client);
			this._Router = new Model_Router(client);
			this._Ipv6Net = new Model_Ipv6Net(client);
			this._Script = new Model_Script(client);
		}
		
		/**
		 * 指定した認証情報を用いてアクセスを行うAPIクライアントを作成します。
		 * 
		 * 必要な認証情報は、コントロールパネル右上にあるアカウントのプルダウンから
		 * 「設定」を選択し、「APIキー」のページにて作成できます。
		 * 
		 * @method Authorize
		 * @chainable
		 * @static
		 * @public
		 * @param {string} token ACCESS TOKEN
		 * @param {string} secret ACCESS TOKEN SECRET
		 * @param {string} zone=null
		 * @return {API} APIクライアント
		 */
		public static API Authorize(string token, string secret, string zone=null)
		{
			Client c = new Client(token, secret);
			API ret = new API(c);
			return zone != null ? ret.InZone(zone) : ret;
		}
		
		/**
		 * 認証情報を引き継ぎ、指定したゾーンへのアクセスを行うAPIクライアントを作成します。
		 * 
		 * @method InZone
		 * @chainable
		 * @public
		 * @param {string} name ゾーン名
		 * @return {API} APIクライアント
		 */
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
