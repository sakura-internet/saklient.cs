using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using DiskPlan = Saklient.Cloud.Resources.DiskPlan;

namespace Saklient.Cloud.Models
{

	/// <summary>ディスクプランを検索するための機能を備えたクラス。
	/// </summary>
	public class Model_DiskPlan : Model
	{
		
		internal override string _ApiPath()
		{
			return "/product/disk";
		}
		
		internal override string _RootKey()
		{
			return "DiskPlan";
		}
		
		internal override string _RootKeyM()
		{
			return "DiskPlans";
		}
		
		internal override string _ClassName()
		{
			return "DiskPlan";
		}
		
		/// <summary>次に取得するリストの開始オフセットを指定します。
		/// 
		/// <param name="offset">オフセット</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_DiskPlan Offset(long offset)
		{
			return ((Model_DiskPlan)(this._Offset(offset)));
		}
		
		/// <summary>次に取得するリストの上限レコード数を指定します。
		/// 
		/// <param name="count">上限レコード数</param>
		/// <returns>this</returns>
		/// </summary>
		public Model_DiskPlan Limit(long count)
		{
			return ((Model_DiskPlan)(this._Limit(count)));
		}
		
		/// <summary>Web APIのフィルタリング設定を直接指定します。
		/// 
		/// <param name="key">キー</param>
		/// <param name="value">値</param>
		/// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
		/// </summary>
		public Model_DiskPlan FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_DiskPlan)(this._FilterBy(key, value, multiple)));
		}
		
		/// <summary>次のリクエストのために設定されているステートをすべて破棄します。
		/// 
		/// <returns>this</returns>
		/// </summary>
		public Model_DiskPlan Reset()
		{
			return ((Model_DiskPlan)(this._Reset()));
		}
		
		/// <summary>指定したIDを持つ唯一のリソースを取得します。
		/// 
		/// <param name="id" />
		/// <returns>リソースオブジェクト</returns>
		/// </summary>
		public DiskPlan GetById(string id)
		{
			return ((DiskPlan)(this._GetById(id)));
		}
		
		/// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
		/// 
		/// <returns>リソースオブジェクトの配列</returns>
		/// </summary>
		public System.Collections.Generic.List<DiskPlan> Find()
		{
			return Util.CastArray(this._Find(), ((DiskPlan)(null)));
		}
		
		public Model_DiskPlan(Client client) : base(client)
		{
			/*!base!*/;
			this._Hdd = null;
			this._Ssd = null;
		}
		
		internal DiskPlan _Hdd;
		
		internal DiskPlan Get_hdd()
		{
			if (this._Hdd == null) {
				this._Hdd = this.GetById("2");
			}
			return this._Hdd;
		}
		
		/// <summary>標準プラン
		/// </summary>
		public DiskPlan Hdd
		{
			get { return this.Get_hdd(); }
		}
		
		internal DiskPlan _Ssd;
		
		internal DiskPlan Get_ssd()
		{
			if (this._Ssd == null) {
				this._Ssd = this.GetById("4");
			}
			return this._Ssd;
		}
		
		/// <summary>SSDプラン
		/// </summary>
		public DiskPlan Ssd
		{
			get { return this.Get_ssd(); }
		}
		
	}
	
}
