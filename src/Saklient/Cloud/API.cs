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
		 * @member saklient.cloud.API#_client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._client;
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
		 * @member saklient.cloud.API#_product
		 * @type Product
		 * @internal
		 * @ignore
		 */
		internal Product _product;
		
		/**
		 * @method Get_product
		 * @internal
		 * @ignore
		 * @return {Product}
		 */
		internal Product Get_product()
		{
			return this._product;
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
		 * @member saklient.cloud.API#_icon
		 * @type Model_Icon
		 * @internal
		 * @ignore
		 */
		internal Model_Icon _icon;
		
		/**
		 * @method Get_icon
		 * @internal
		 * @ignore
		 * @return {Model_Icon}
		 */
		internal Model_Icon Get_icon()
		{
			return this._icon;
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
		 * @member saklient.cloud.API#_server
		 * @type Model_Server
		 * @internal
		 * @ignore
		 */
		internal Model_Server _server;
		
		/**
		 * @method Get_server
		 * @internal
		 * @ignore
		 * @return {Model_Server}
		 */
		internal Model_Server Get_server()
		{
			return this._server;
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
		 * @member saklient.cloud.API#_disk
		 * @type Model_Disk
		 * @internal
		 * @ignore
		 */
		internal Model_Disk _disk;
		
		/**
		 * @method Get_disk
		 * @internal
		 * @ignore
		 * @return {Model_Disk}
		 */
		internal Model_Disk Get_disk()
		{
			return this._disk;
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
		 * @member saklient.cloud.API#_appliance
		 * @type Model_Appliance
		 * @internal
		 * @ignore
		 */
		internal Model_Appliance _appliance;
		
		/**
		 * @method Get_appliance
		 * @internal
		 * @ignore
		 * @return {Model_Appliance}
		 */
		internal Model_Appliance Get_appliance()
		{
			return this._appliance;
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
		 * @member saklient.cloud.API#_archive
		 * @type Model_Archive
		 * @internal
		 * @ignore
		 */
		internal Model_Archive _archive;
		
		/**
		 * @method Get_archive
		 * @internal
		 * @ignore
		 * @return {Model_Archive}
		 */
		internal Model_Archive Get_archive()
		{
			return this._archive;
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
		 * @member saklient.cloud.API#_isoImage
		 * @type Model_IsoImage
		 * @internal
		 * @ignore
		 */
		internal Model_IsoImage _isoImage;
		
		/**
		 * @method Get_isoImage
		 * @internal
		 * @ignore
		 * @return {Model_IsoImage}
		 */
		internal Model_IsoImage Get_isoImage()
		{
			return this._isoImage;
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
		 * @member saklient.cloud.API#_iface
		 * @type Model_Iface
		 * @internal
		 * @ignore
		 */
		internal Model_Iface _iface;
		
		/**
		 * @method Get_iface
		 * @internal
		 * @ignore
		 * @return {Model_Iface}
		 */
		internal Model_Iface Get_iface()
		{
			return this._iface;
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
		 * @member saklient.cloud.API#_swytch
		 * @type Model_Swytch
		 * @internal
		 * @ignore
		 */
		internal Model_Swytch _swytch;
		
		/**
		 * @method Get_swytch
		 * @internal
		 * @ignore
		 * @return {Model_Swytch}
		 */
		internal Model_Swytch Get_swytch()
		{
			return this._swytch;
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
		 * @member saklient.cloud.API#_router
		 * @type Model_Router
		 * @internal
		 * @ignore
		 */
		internal Model_Router _router;
		
		/**
		 * @method Get_router
		 * @internal
		 * @ignore
		 * @return {Model_Router}
		 */
		internal Model_Router Get_router()
		{
			return this._router;
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
		 * @member saklient.cloud.API#_ipv6Net
		 * @type Model_Ipv6Net
		 * @internal
		 * @ignore
		 */
		internal Model_Ipv6Net _ipv6Net;
		
		/**
		 * @method Get_ipv6Net
		 * @internal
		 * @ignore
		 * @return {Model_Ipv6Net}
		 */
		internal Model_Ipv6Net Get_ipv6Net()
		{
			return this._ipv6Net;
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
		 * @member saklient.cloud.API#_script
		 * @type Model_Script
		 * @internal
		 * @ignore
		 */
		internal Model_Script _script;
		
		/**
		 * @method Get_script
		 * @internal
		 * @ignore
		 * @return {Model_Script}
		 */
		internal Model_Script Get_script()
		{
			return this._script;
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
			Util.ValidateType(client, "Saklient.Cloud.Client");
			this._client = client;
			this._product = new Product(client);
			this._icon = new Model_Icon(client);
			this._server = new Model_Server(client);
			this._disk = new Model_Disk(client);
			this._appliance = new Model_Appliance(client);
			this._archive = new Model_Archive(client);
			this._isoImage = new Model_IsoImage(client);
			this._iface = new Model_Iface(client);
			this._swytch = new Model_Swytch(client);
			this._router = new Model_Router(client);
			this._ipv6Net = new Model_Ipv6Net(client);
			this._script = new Model_Script(client);
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
			Util.ValidateType(token, "string");
			Util.ValidateType(secret, "string");
			Util.ValidateType(zone, "string");
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
			Util.ValidateType(name, "string");
			API ret = new API(this._client.CloneInstance());
			string suffix = "";
			if (name == "is1x" || name == "is1y") {
				suffix = "-test";
			};
			ret._client.SetApiRoot("https://secure.sakura.ad.jp/cloud" + suffix + "/");
			ret._client.SetApiRootSuffix("zone/" + name);
			return ret;
		}
		
	}
	
}
