using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using DiskPlan = Saklient.Cloud.Resources.DiskPlan;

namespace Saklient.Cloud.Models
{

	/**
	 * ディスクプランを検索するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_DiskPlan
	 * @class Model_DiskPlan
	 * @constructor
	 * @extends Model
	 */
	public class Model_DiskPlan : Model
	{
		
		/**
		 * @private
		 * @method _ApiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _ApiPath()
		{
			return "/product/disk";
		}
		
		/**
		 * @private
		 * @method _RootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _RootKey()
		{
			return "DiskPlan";
		}
		
		/**
		 * @private
		 * @method _RootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _RootKeyM()
		{
			return "DiskPlans";
		}
		
		/**
		 * @private
		 * @method _ClassName
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _ClassName()
		{
			return "DiskPlan";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_DiskPlan} this
		 */
		public Model_DiskPlan Offset(long offset)
		{
			return ((Model_DiskPlan)(this._Offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_DiskPlan} this
		 */
		public Model_DiskPlan Limit(long count)
		{
			return ((Model_DiskPlan)(this._Limit(count)));
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @method FilterBy
		 * @chainable
		 * @public
		 * @param {string} key キー
		 * @param {object} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model_DiskPlan}
		 */
		public Model_DiskPlan FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_DiskPlan)(this._FilterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_DiskPlan} this
		 */
		public Model_DiskPlan Reset()
		{
			return ((Model_DiskPlan)(this._Reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {DiskPlan} リソースオブジェクト
		 */
		public DiskPlan GetById(string id)
		{
			return ((DiskPlan)(this._GetById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<DiskPlan>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<DiskPlan> Find()
		{
			return Util.CastArray(this._Find(), ((DiskPlan)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_DiskPlan(Client client) : base(client)
		{
			/*!base!*/;
			this._Hdd = null;
			this._Ssd = null;
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model_DiskPlan#_Hdd
		 * @type DiskPlan
		 * @internal
		 * @ignore
		 */
		internal DiskPlan _Hdd;
		
		/**
		 * @method Get_hdd
		 * @internal
		 * @ignore
		 * @return {DiskPlan}
		 */
		internal DiskPlan Get_hdd()
		{
			if (this._Hdd == null) {
				this._Hdd = this.GetById("2");
			}
			return this._Hdd;
		}
		
		/**
		 * 標準プラン
		 * 
		 * @property Hdd
		 * @type DiskPlan
		 * @readOnly
		 * @public
		 */
		public DiskPlan Hdd
		{
			get { return this.Get_hdd(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model_DiskPlan#_Ssd
		 * @type DiskPlan
		 * @internal
		 * @ignore
		 */
		internal DiskPlan _Ssd;
		
		/**
		 * @method Get_ssd
		 * @internal
		 * @ignore
		 * @return {DiskPlan}
		 */
		internal DiskPlan Get_ssd()
		{
			if (this._Ssd == null) {
				this._Ssd = this.GetById("4");
			}
			return this._Ssd;
		}
		
		/**
		 * SSDプラン
		 * 
		 * @property Ssd
		 * @type DiskPlan
		 * @readOnly
		 * @public
		 */
		public DiskPlan Ssd
		{
			get { return this.Get_ssd(); }
		}
		
	}
	
}
