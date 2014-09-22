using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Resource = Saklient.Cloud.Resources.Resource;
using QueryParams = Saklient.Cloud.Models.QueryParams;
using SaklientException = Saklient.Errors.SaklientException;

namespace Saklient.Cloud.Models
{

	/**
	 * @ignore
	 * @module saklient.cloud.models.Model
	 * @class Model
	 * @constructor
	 */
	public class Model
	{
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_client
		 * @type Client
		 * @internal
		 * @ignore
		 */
		internal Client _client;
		
		/**
		 * @method Get_client
		 * @internal
		 * @ignore
		 * @return {Client}
		 */
		internal Client Get_client()
		{
			return this._client;
		}
		
		/**
		 * @property Client
		 * @type Client
		 * @readOnly
		 * @public
		 */
		public Client Client
		{
			get { return this.Get_client(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_query
		 * @type QueryParams
		 * @internal
		 * @ignore
		 */
		internal QueryParams _query;
		
		/**
		 * @method Get_query
		 * @internal
		 * @ignore
		 * @return {QueryParams}
		 */
		internal QueryParams Get_query()
		{
			return this._query;
		}
		
		/**
		 * @property Query
		 * @type QueryParams
		 * @readOnly
		 * @public
		 */
		public QueryParams Query
		{
			get { return this.Get_query(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_total
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _total;
		
		/**
		 * @method Get_total
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_total()
		{
			return this._total;
		}
		
		/**
		 * @property Total
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? Total
		{
			get { return this.Get_total(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_count
		 * @type long?
		 * @internal
		 * @ignore
		 */
		internal long? _count;
		
		/**
		 * @method Get_count
		 * @internal
		 * @ignore
		 * @return {long?}
		 */
		internal long? Get_count()
		{
			return this._count;
		}
		
		/**
		 * @property Count
		 * @type long?
		 * @readOnly
		 * @public
		 */
		public long? Count
		{
			get { return this.Get_count(); }
		}
		
		/**
		 * @private
		 * @method _apiPath
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _apiPath()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _rootKey
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _rootKey()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _rootKeyM
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _rootKeyM()
		{
			return null;
		}
		
		/**
		 * @private
		 * @method _className
		 * @internal
		 * @ignore
		 * @return {string}
		 */
		internal virtual string _className()
		{
			return null;
		}
		
		/**
		 * @constructor
		 * @public
		 * @param {Client} client
		 */
		public Model(Client client)
		{
			this._client = client;
			this._reset();
		}
		
		/**
		 * 次に取得するリストの開始オフセットを指定します。
		 * 
		 * @private
		 * @method _offset
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {long} offset オフセット
		 * @return {Model} this
		 */
		internal Model _offset(long offset)
		{
			this._query.Begin = offset;
			return this;
		}
		
		/**
		 * 次に取得するリストの上限レコード数を指定します。
		 * 
		 * @private
		 * @method _limit
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {long} count 上限レコード数
		 * @return {Model} this
		 */
		internal Model _limit(long count)
		{
			this._query.Count = count;
			return this;
		}
		
		/**
		 * 次に取得するリストのソートカラムを指定します。
		 * 
		 * @private
		 * @method _sort
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} column カラム名
		 * @param {bool} reverse=false
		 * @return {Model} this
		 */
		internal Model _sort(string column, bool reverse=false)
		{
			string op = reverse ? "-" : "";
			(this._query.Sort as System.Collections.IList).Add(op + column);
			return this;
		}
		
		/**
		 * Web APIのフィルタリング設定を直接指定します。
		 * 
		 * @private
		 * @method _filterBy
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} key キー
		 * @param {object} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model}
		 */
		internal Model _filterBy(string key, object value, bool multiple=false)
		{
			object filter = this._query.Filter;
			if (multiple) {
				if (!(filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					(filter as System.Collections.Generic.Dictionary<string, object>)[key] = new System.Collections.Generic.List<object> {  };
				}
				System.Collections.Generic.List<object> values = ((System.Collections.Generic.List<object>)((filter as System.Collections.Generic.Dictionary<string, object>)[key]));
				(values as System.Collections.IList).Add(value);
			}
			else {
				if ((filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					throw new SaklientException("filter_duplicated", "The same filter key can be specified only once (by calling the same method 'withFooBar')");
				}
				(filter as System.Collections.Generic.Dictionary<string, object>)[key] = value;
			}
			return this;
		}
		
		/**
		 * 次のリクエストのために設定されているステートをすべて破棄します。
		 * 
		 * @private
		 * @method _reset
		 * @chainable
		 * @internal
		 * @ignore
		 * @return {Model} this
		 */
		internal Model _reset()
		{
			this._query = new QueryParams();
			this._total = 0;
			this._count = 0;
			return this;
		}
		
		/**
		 * 新規リソース作成用のオブジェクトを用意します。
		 * 
		 * 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
		 * 
		 * @private
		 * @method _create
		 * @internal
		 * @ignore
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _create()
		{
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._client, null, false };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
		}
		
		/**
		 * 指定したIDを持つ唯一のリソースを取得します。
		 * 
		 * @private
		 * @method _getById
		 * @internal
		 * @ignore
		 * @param {string} id
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _getById(string id)
		{
			object query = this._query.Build();
			this._reset();
			object result = this._client.Request("GET", this._apiPath() + "/" + Util.UrlEncode(id), query);
			this._total = 1;
			this._count = 1;
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._client, result, true };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @private
		 * @method _find
		 * @internal
		 * @ignore
		 * @return {System.Collections.Generic.List<Resource>} リソースオブジェクトの配列
		 */
		internal System.Collections.Generic.List<Resource> _find()
		{
			object query = this._query.Build();
			this._reset();
			object result = this._client.Request("GET", this._apiPath(), query);
			this._total = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Total"]);
			this._count = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Count"]);
			System.Collections.Generic.List<Resource> data = new System.Collections.Generic.List<Resource> {  };
			System.Collections.Generic.List<object> records = ((System.Collections.Generic.List<object>)((result as System.Collections.Generic.Dictionary<string, object>)[this._rootKeyM()]));
			for (int __it1=0; __it1 < (records as System.Collections.IList).Count; __it1++) {
				var record = records[__it1];
				System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._client, record, false };
				Resource i = ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
				(data as System.Collections.IList).Add(i);
			}
			return ((System.Collections.Generic.List<Resource>)(data));
		}
		
		/**
		 * リソースの検索リクエストを実行し、唯一のリソースを取得します。
		 * 
		 * @private
		 * @method _findOne
		 * @internal
		 * @ignore
		 * @return {Resource} リソースオブジェクト
		 */
		internal Resource _findOne()
		{
			object query = this._query.Build();
			this._reset();
			object result = this._client.Request("GET", this._apiPath(), query);
			this._total = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Total"]);
			this._count = System.Convert.ToInt64((result as System.Collections.Generic.Dictionary<string, object>)["Count"]);
			if (this._total == 0) {
				return null;
			}
			System.Collections.Generic.List<object> records = ((System.Collections.Generic.List<object>)((result as System.Collections.Generic.Dictionary<string, object>)[this._rootKeyM()]));
			System.Collections.Generic.List<object> a = new System.Collections.Generic.List<object> { this._client, records[System.Convert.ToInt32(0)], false };
			return ((Resource)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
		}
		
		/**
		 * 指定した文字列を名前に含むリソースに絞り込みます。
		 * 
		 * 大文字・小文字は区別されません。
		 * 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _withNameLike
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} name
		 * @return {Model}
		 */
		internal Model _withNameLike(string name)
		{
			return this._filterBy("Name", name);
		}
		
		/**
		 * 指定したタグを持つリソースに絞り込みます。
		 * 
		 * 複数のタグを指定する場合は withTags() を利用してください。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _withTag
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {string} tag
		 * @return {Model}
		 */
		internal Model _withTag(string tag)
		{
			return this._filterBy("Tags.Name", new System.Collections.Generic.List<object> { tag });
		}
		
		/**
		 * 指定したすべてのタグを持つリソースに絞り込みます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _withTags
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {System.Collections.Generic.List<string>} tags
		 * @return {Model}
		 */
		internal Model _withTags(System.Collections.Generic.List<string> tags)
		{
			return this._filterBy("Tags.Name", new System.Collections.Generic.List<object> { tags });
		}
		
		/**
		 * 指定したDNFに合致するタグを持つリソースに絞り込みます。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _withTagDnf
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {System.Collections.Generic.List<System.Collections.Generic.List<string>>} dnf
		 * @return {Model}
		 */
		internal Model _withTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return this._filterBy("Tags.Name", dnf);
		}
		
		/**
		 * 名前でソートします。
		 * 
		 * @private
		 * @todo Implement test case
		 * @method _sortByName
		 * @chainable
		 * @internal
		 * @ignore
		 * @param {bool} reverse=false
		 * @return {Model}
		 */
		internal Model _sortByName(bool reverse=false)
		{
			return this._sort("Name", reverse);
		}
		
	}
	
}
