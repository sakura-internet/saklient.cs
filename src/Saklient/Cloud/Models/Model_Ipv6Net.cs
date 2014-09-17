using Util = Saklient.Util;
using Model = Saklient.Cloud.Models.Model;
using Ipv6Net = Saklient.Cloud.Resources.Ipv6Net;

namespace Saklient.Cloud.Models
{

	/**
	 * IPv6ネットワークを検索するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Ipv6Net
	 * @class Model_Ipv6Net
	 * @constructor
	 * @extends Model
	 */
	class Model_Ipv6Net : Model
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
			return "/ipv6net";
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
			return "IPv6Net";
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
			return "IPv6Nets";
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
			return "IPv6Net";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {int} offset オフセット
		 * @return {Model_Ipv6Net} this
		 */
		public Model_Ipv6Net Offset(int offset)
		{
			Util.ValidateType(offset, "int");
			return ((Model_Ipv6Net)(dynamic)(this._offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {int} count 上限レコード数
		 * @return {Model_Ipv6Net} this
		 */
		public Model_Ipv6Net Limit(int count)
		{
			Util.ValidateType(count, "int");
			return ((Model_Ipv6Net)(dynamic)(this._limit(count)));
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
		 * @return {Model_Ipv6Net}
		 */
		public Model_Ipv6Net FilterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			return ((Model_Ipv6Net)(dynamic)(this._filterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Ipv6Net} this
		 */
		public Model_Ipv6Net Reset()
		{
			return ((Model_Ipv6Net)(dynamic)(this._reset()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Ipv6Net} リソースオブジェクト
		 */
		public Ipv6Net GetById(string id)
		{
			Util.ValidateType(id, "string");
			return ((Ipv6Net)(dynamic)(this._getById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {Ipv6Net[]} リソースオブジェクトの配列
		 */
		public Ipv6Net[] Find()
		{
			return Util.CastArray(this._find(), ((Ipv6Net)(dynamic)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Ipv6Net(Client client) : base(client)
		{
			/*!base!*/;
			Util.ValidateType(client, "Client");
		}
		
	}
	
}
