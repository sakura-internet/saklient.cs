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
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _apiPath()
		{
			return "/product/disk";
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKey()
		{
			return "DiskPlan";
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _rootKeyM()
		{
			return "DiskPlans";
		}
		
		/**
		 * @private
		 * @method _className
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal override string _className()
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
			Util.ValidateType(offset, "long");
			return ((Model_DiskPlan)(this._offset(offset)));
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
			Util.ValidateType(count, "long");
			return ((Model_DiskPlan)(this._limit(count)));
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
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "object");
			Util.ValidateType(multiple, "bool");
			return ((Model_DiskPlan)(this._filterBy(key, value, multiple)));
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
			return ((Model_DiskPlan)(this._reset()));
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
			Util.ValidateType(id, "string");
			return ((DiskPlan)(this._getById(id)));
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
			return Util.CastArray(this._find(), ((DiskPlan)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_DiskPlan(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Saklient.Cloud.Client");
			this._hdd = null;
			this._ssd = null;
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model_DiskPlan#_hdd
		 * @type DiskPlan
		 * @internal
		 * @ignore
		 */
		internal DiskPlan _hdd;
		
		/**
		 * @method Get_hdd
		 * @internal
		 * @ignore
		 * @return {DiskPlan}
		 */
		internal DiskPlan Get_hdd()
		{
			if (this._hdd == null) {
				this._hdd = this.GetById("2");
			};
			return this._hdd;
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
		 * @member saklient.cloud.models.Model_DiskPlan#_ssd
		 * @type DiskPlan
		 * @internal
		 * @ignore
		 */
		internal DiskPlan _ssd;
		
		/**
		 * @method Get_ssd
		 * @internal
		 * @ignore
		 * @return {DiskPlan}
		 */
		internal DiskPlan Get_ssd()
		{
			if (this._ssd == null) {
				this._ssd = this.GetById("4");
			};
			return this._ssd;
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
