using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using Iface = Saklient.Cloud.Resources.Iface;

namespace Saklient.Cloud.Models
{

	/**
	 * インタフェースを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Iface
	 * @class Model_Iface
	 * @constructor
	 * @extends Model
	 */
	class Model_Iface : Model
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
			return "/interface";
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
			return "Interface";
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
			return "Interfaces";
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
			return "Iface";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_Iface} this
		 */
		public Model_Iface Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_Iface)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_Iface} this
		 */
		public Model_Iface Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_Iface)(dynamic)(this._limit(count)));
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @method FilterBy
		 * @chainable
		 * @public
		 * @param {string} key キー
		 * @param {dynamic} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model_Iface}
		 */
		public Model_Iface FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_Iface)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Iface} this
		 */
		public Model_Iface Reset()
		{
			return ((Model_Iface)(dynamic)(this._reset()));
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @method Create
		 * @public
		 * @return {Iface} リソースオブジェクト
		 */
		public Iface Create()
		{
			return ((Iface)(dynamic)(this._create()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Iface} リソースオブジェクト
		 */
		public Iface GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((Iface)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {Iface[]} リソースオブジェクトの配列
		 */
		public Iface[] Find()
		{
			return Util.CastArray(this._find(), ((Iface)(dynamic)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Iface(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
	}
	
}
