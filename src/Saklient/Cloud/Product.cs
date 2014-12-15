using Util = Saklient.Util;
using Model_ServerPlan = Saklient.Cloud.Models.Model_ServerPlan;
using Model_DiskPlan = Saklient.Cloud.Models.Model_DiskPlan;
using Model_RouterPlan = Saklient.Cloud.Models.Model_RouterPlan;
using Model_LicenseInfo = Saklient.Cloud.Models.Model_LicenseInfo;
using Client = Saklient.Cloud.Client;

namespace Saklient.Cloud
{

	/// <summary>商品情報にアクセスするためのモデルを集めたクラス。
	/// </summary>
	public class Product
	{
		
		internal Model_ServerPlan _Server;
		
		internal Model_ServerPlan Get_server()
		{
			return this._Server;
		}
		
		/// <summary>サーバプラン情報。
		/// </summary>
		public Model_ServerPlan Server
		{
			get { return this.Get_server(); }
		}
		
		internal Model_DiskPlan _Disk;
		
		internal Model_DiskPlan Get_disk()
		{
			return this._Disk;
		}
		
		/// <summary>ディスクプラン情報。
		/// </summary>
		public Model_DiskPlan Disk
		{
			get { return this.Get_disk(); }
		}
		
		internal Model_RouterPlan _Router;
		
		internal Model_RouterPlan Get_router()
		{
			return this._Router;
		}
		
		/// <summary>ルータ帯域プラン情報。
		/// </summary>
		public Model_RouterPlan Router
		{
			get { return this.Get_router(); }
		}
		
		internal Model_LicenseInfo _License;
		
		internal Model_LicenseInfo Get_license()
		{
			return this._License;
		}
		
		/// <summary>ライセンス種別情報。
		/// </summary>
		public Model_LicenseInfo License
		{
			get { return this.Get_license(); }
		}
		
		/// <summary>
		/// 
		/// <param name="client" />
		/// </summary>
		public Product(Client client)
		{
			this._Server = new Model_ServerPlan(client);
			this._Disk = new Model_DiskPlan(client);
			this._Router = new Model_RouterPlan(client);
			this._License = new Model_LicenseInfo(client);
		}
		
	}
	
}
