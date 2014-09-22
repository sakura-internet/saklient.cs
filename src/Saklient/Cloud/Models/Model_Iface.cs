using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
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
	public class Model_Iface : Model
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
			return "/interface";
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
			return "Interface";
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
			return "Interfaces";
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
			return "Iface";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Iface} this
		 */
		public Model_Iface Offset(long offset)
		{
			return ((Model_Iface)(this._Offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Iface} this
		 */
		public Model_Iface Limit(long count)
		{
			return ((Model_Iface)(this._Limit(count)));
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
		 * @return {Model_Iface}
		 */
		public Model_Iface FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Iface)(this._FilterBy(key, value, multiple)));
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
			return ((Model_Iface)(this._Reset()));
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
			return ((Iface)(this._Create()));
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
			return ((Iface)(this._GetById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Iface>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Iface> Find()
		{
			return Util.CastArray(this._Find(), ((Iface)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Iface(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
