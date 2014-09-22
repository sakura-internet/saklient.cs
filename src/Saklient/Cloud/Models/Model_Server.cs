using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Server = Saklient.Cloud.Resources.Server;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;

namespace Saklient.Cloud.Models
{

	/**
	 * サーバを検索・作成するための機能を備えたクラス。
	 * 
	 * @module saklient.cloud.models.Model_Server
	 * @class Model_Server
	 * @constructor
	 * @extends Model
	 */
	public class Model_Server : Model
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
			return "/server";
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
			return "Server";
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
			return "Servers";
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
			return "Server";
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @method Offset
		 * @chainable
		 * @public
		 * @param {long} offset オフセット
		 * @return {Model_Server} this
		 */
		public Model_Server Offset(long offset)
		{
			return ((Model_Server)(this._Offset(offset)));
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @method Limit
		 * @chainable
		 * @public
		 * @param {long} count 上限レコード数
		 * @return {Model_Server} this
		 */
		public Model_Server Limit(long count)
		{
			return ((Model_Server)(this._Limit(count)));
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
		 * @return {Model_Server}
		 */
		public Model_Server FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Server)(this._FilterBy(key, value, multiple)));
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @method Reset
		 * @chainable
		 * @public
		 * @return {Model_Server} this
		 */
		public Model_Server Reset()
		{
			return ((Model_Server)(this._Reset()));
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @method Create
		 * @public
		 * @return {Server} リソースオブジェクト
		 */
		public Server Create()
		{
			return ((Server)(this._Create()));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @method GetById
		 * @public
		 * @param {string} id
		 * @return {Server} リソースオブジェクト
		 */
		public Server GetById(string id)
		{
			return ((Server)(this._GetById(id)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @method Find
		 * @public
		 * @return {System.Collections.Generic.List<Server>} リソースオブジェクトの配列
		 */
		public System.Collections.Generic.List<Server> Find()
		{
			return Util.CastArray(this._Find(), ((Server)(null)));
		}
		
		/**
		 * 指定した文字列を名前に含むリソースに絞り込みます。
		 * 
		 * 大文字・小文字は区別されません。
		 * 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		 * 
		 * @todo Implement test case
		 * @method WithNameLike
		 * @chainable
		 * @public
		 * @param {string} name
		 * @return {Model_Server}
		 */
		public Model_Server WithNameLike(string name)
		{
			return ((Model_Server)(this._WithNameLike(name)));
		}
		
		/**
		 * 指定したタグを持つリソースに絞り込みます。
		 * 
		 * 複数のタグを指定する場合は withTags() を利用してください。
		 * 
		 * @todo Implement test case
		 * @method WithTag
		 * @chainable
		 * @public
		 * @param {string} tag
		 * @return {Model_Server}
		 */
		public Model_Server WithTag(string tag)
		{
			return ((Model_Server)(this._WithTag(tag)));
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTags
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model_Server}
		 */
		public Model_Server WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Server)(this._WithTags(tags)));
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @todo Implement test case
		 * @method WithTagDnf
		 * @chainable
		 * @public
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model_Server}
		 */
		public Model_Server WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Server)(this._WithTagDnf(dnf)));
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @todo Implement test case
		 * @method SortByName
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Server}
		 */
		public Model_Server SortByName(bool reverse=false)
		{
			return ((Model_Server)(this._SortByName(reverse)));
		}
		
		/**
		 * @ignore
		 * @constructor
		 * @param {Client} client
		 */
		public Model_Server(Client client) : base(client)
		{
			/*!base!*/;
		}
		
		/**
		 * 指定したプランのサーバに絞り込みます。
		 * 
		 * @method WithPlan
		 * @chainable
		 * @public
		 * @param {ServerPlan} plan
		 * @return {Model_Server}
		 */
		public Model_Server WithPlan(ServerPlan plan)
		{
			this._FilterBy("ServerPlan.ID", new System.Collections.Generic.List<object> { plan._Id() });
			return this;
		}
		
		/**
		 * インスタンスが指定した状態にあるサーバに絞り込みます。
		 * 
		 * @method WithStatus
		 * @chainable
		 * @public
		 * @param {string} status
		 * @return {Model_Server}
		 */
		public Model_Server WithStatus(string status)
		{
			this._FilterBy("Instance.Status", new System.Collections.Generic.List<object> { status });
			return this;
		}
		
		/**
		 * インスタンスが起動中のサーバに絞り込みます。
		 * 
		 * @method WithStatusUp
		 * @chainable
		 * @public
		 * @return {Model_Server}
		 */
		public Model_Server WithStatusUp()
		{
			return this.WithStatus(EServerInstanceStatus.Up);
		}
		
		/**
		 * インスタンスが停止中のサーバに絞り込みます。
		 * 
		 * @method WithStatusDown
		 * @chainable
		 * @public
		 * @return {Model_Server}
		 */
		public Model_Server WithStatusDown()
		{
			return this.WithStatus(EServerInstanceStatus.Down);
		}
		
		/**
		 * 指定したISOイメージが挿入されているサーバに絞り込みます。
		 * 
		 * @method WithIsoImage
		 * @chainable
		 * @public
		 * @param {IsoImage} iso
		 * @return {Model_Server}
		 */
		public Model_Server WithIsoImage(IsoImage iso)
		{
			this._FilterBy("Instance.CDROM.ID", new System.Collections.Generic.List<object> { iso._Id() });
			return this;
		}
		
		/**
		 * 仮想コア数でソートします。
		 * 
		 * @method SortByCpu
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Server}
		 */
		public Model_Server SortByCpu(bool reverse=false)
		{
			this._Sort("ServerPlan.CPU", reverse);
			return this;
		}
		
		/**
		 * メモリ容量でソートします。
		 * 
		 * @method SortByMemory
		 * @chainable
		 * @public
		 * @param {bool} reverse=false
		 * @return {Model_Server}
		 */
		public Model_Server SortByMemory(bool reverse=false)
		{
			this._Sort("ServerPlan.MemoryMB", reverse);
			return this;
		}
		
	}
	
}
