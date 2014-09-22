using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
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
	public class Model_Ipv6Net : Model
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
			return "/ipv6net";
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
			return "IPv6Net";
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
			return "IPv6Nets";
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
			return "IPv6Net";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Ipv6Net} this
		 */
		public Model_Ipv6Net Offset(long offset)
		{
			return ((Model_Ipv6Net)(this._Offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Ipv6Net} this
		 */
		public Model_Ipv6Net Limit(long count)
		{
			return ((Model_Ipv6Net)(this._Limit(count)));
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
		 * @return {Model_Ipv6Net}
		 */
		public Model_Ipv6Net FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Ipv6Net)(this._FilterBy(key, value, multiple)));
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
			return ((Model_Ipv6Net)(this._Reset()));
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
			return ((Ipv6Net)(this._GetById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Ipv6Net>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Ipv6Net> Find()
		{
			return Util.CastArray(this._Find(), ((Ipv6Net)(null)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Ipv6Net(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
