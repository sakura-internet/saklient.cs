using Util = Saklient.Util;
using Model_ServerPlan = Saklient.Cloud.Models.Model_ServerPlan;
using Model_DiskPlan = Saklient.Cloud.Models.Model_DiskPlan;
using Model_RouterPlan = Saklient.Cloud.Models.Model_RouterPlan;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud
{

	/**
	 * 商品情報にアクセスするためのモデルを集めたクラス。
	 * 
	 * @module saklient.cloud.Product
	 * @class Product
	 * @constructor
	 */
	class Product
	{
		
		/**
		 * @private
		 * @member saklient.cloud.Product#_server
		 * @type Model_ServerPlan
		 * @internal
		 * @ignore
		 */
		internal Model_ServerPlan _server;
		
		/**
		 * @method Get_server
		 * @internal
		 * @ignore
		 * @return {Model_ServerPlan}
		 */
		internal Model_ServerPlan Get_server()
		{
			return this._server;
		}
		
		/**
		 * サーバプラン情報。
		 * 
		 * @property Server
		 * @type Model_ServerPlan
		 * @readOnly
		 * @public
		 */
		public Model_ServerPlan Server
		{
			get { return this.Get_server(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.Product#_disk
		 * @type Model_DiskPlan
		 * @internal
		 * @ignore
		 */
		internal Model_DiskPlan _disk;
		
		/**
		 * @method Get_disk
		 * @internal
		 * @ignore
		 * @return {Model_DiskPlan}
		 */
		internal Model_DiskPlan Get_disk()
		{
			return this._disk;
		}
		
		/**
		 * ディスクプラン情報。
		 * 
		 * @property Disk
		 * @type Model_DiskPlan
		 * @readOnly
		 * @public
		 */
		public Model_DiskPlan Disk
		{
			get { return this.Get_disk(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.Product#_router
		 * @type Model_RouterPlan
		 * @internal
		 * @ignore
		 */
		internal Model_RouterPlan _router;
		
		/**
		 * @method Get_router
		 * @internal
		 * @ignore
		 * @return {Model_RouterPlan}
		 */
		internal Model_RouterPlan Get_router()
		{
			return this._router;
		}
		
		/**
		 * ルータ帯域プラン情報。
		 * 
		 * @property Router
		 * @type Model_RouterPlan
		 * @readOnly
		 * @public
		 */
		public Model_RouterPlan Router
		{
			get { return this.Get_router(); }
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Product(Client client)
		{
			Util.ValidateType(client, "Saklient.Cloud.Client");
			this._server = new Model_ServerPlan(client);
			this._disk = new Model_DiskPlan(client);
			this._router = new Model_RouterPlan(client);
		}
		
	}
	
}
