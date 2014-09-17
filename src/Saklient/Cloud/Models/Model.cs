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
	class Model
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
		 * @type int?
		 * @internal
		 * @ignore
		 */
		internal int? _total;
		
		/**
		 * @method Get_total
		 * @internal
		 * @ignore
		 * @return {int?}
		 */
		internal int? Get_total()
		{
			return this._total;
		}
		
		/**
		 * @property Total
		 * @type int?
		 * @readOnly
		 * @public
		 */
		public int? Total
		{
			get { return this.Get_total(); }
		}
		
		/**
		 * @private
		 * @member saklient.cloud.models.Model#_count
		 * @type int?
		 * @internal
		 * @ignore
		 */
		internal int? _count;
		
		/**
		 * @method Get_count
		 * @internal
		 * @ignore
		 * @return {int?}
		 */
		internal int? Get_count()
		{
			return this._count;
		}
		
		/**
		 * @property Count
		 * @type int?
		 * @readOnly
		 * @public
		 */
		public int? Count
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
			Util.ValidateType(client, "Saklient.Cloud.Client");
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
		 * @param {int} offset オフセット
		 * @return {Model} this
		 */
		internal Model _offset(int offset)
		{
			Util.ValidateType(offset, "int");
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
		 * @param {int} count 上限レコード数
		 * @return {Model} this
		 */
		internal Model _limit(int count)
		{
			Util.ValidateType(count, "int");
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
			Util.ValidateType(column, "string");
			Util.ValidateType(reverse, "bool");
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
		 * @param {dynamic} value 値
		 * @param {bool} multiple=false valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。
		 * @return {Model}
		 */
		internal Model _filterBy(string key, dynamic value, bool multiple=false)
		{
			Util.ValidateType(key, "string");
			Util.ValidateType(value, "dynamic");
			Util.ValidateType(multiple, "bool");
			dynamic filter = this._query.Filter;
			if (multiple) {
				if (!(filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					(filter as System.Collections.Generic.Dictionary<string, object>)[key] = new object[] {  };
				};
				dynamic[] values = ((dynamic[])(dynamic)((filter as System.Collections.Generic.Dictionary<string, object>)[key]));
				(values as System.Collections.IList).Add(value);
			}
			else {
				if ((filter as System.Collections.Generic.Dictionary<string, object>).ContainsKey(key)) {
					throw new SaklientException("filter_duplicated", "The same filter key can be specified only once (by calling the same method 'withFooBar')");
				};
				(filter as System.Collections.Generic.Dictionary<string, object>)[key] = value;
			};
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
			dynamic[] a = { this._client, null };
			return ((Resource)(dynamic)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
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
			Util.ValidateType(id, "string");
			dynamic query = this._query.Build();
			this._reset();
			dynamic result = this._client.Request("GET", this._apiPath() + "/" + Util.UrlEncode(id), query);
			this._total = 1;
			this._count = 1;
			return ((Resource)(dynamic)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), new object[] { this._client, result, true })));
		}
		
		/**
		 * リソースの検索リクエストを実行し、結果をリストで取得します。
		 * 
		 * @private
		 * @method _find
		 * @internal
		 * @ignore
		 * @return {Resource[]} リソースオブジェクトの配列
		 */
		internal Resource[] _find()
		{
			dynamic query = this._query.Build();
			this._reset();
			dynamic result = this._client.Request("GET", this._apiPath(), query);
			this._total = ((int)(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)["Total"]));
			this._count = ((int)(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)["Count"]));
			dynamic[] records = ((dynamic[])(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)[this._rootKeyM()]));
			Resource[] data = {  };
			for (int __it1=0; __it1 < (records as System.Collections.IList).Count; __it1++) {
				var record = records[__it1];
				dynamic[] a = { this._client, record };
				Resource i = ((Resource)(dynamic)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), a)));
				(data as System.Collections.IList).Add(i);
			};
			return ((Resource[])(dynamic)(data));
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
			dynamic query = this._query.Build();
			this._reset();
			dynamic result = this._client.Request("GET", this._apiPath(), query);
			this._total = ((int)(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)["Total"]));
			this._count = ((int)(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)["Count"]));
			if (this._total == 0) {
				return null;
			};
			dynamic[] records = ((dynamic[])(dynamic)((result as System.Collections.Generic.Dictionary<string, object>)[this._rootKeyM()]));
			return ((Resource)(dynamic)(Util.CreateClassInstance("saklient.cloud.resources." + this._className(), new object[] { this._client, records[0] })));
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
			Util.ValidateType(name, "string");
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
			Util.ValidateType(tag, "string");
			return this._filterBy("Tags.Name", new object[] { tag });
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
		 * @param {string[]} tags
		 * @return {Model}
		 */
		internal Model _withTags(string[] tags)
		{
			Util.ValidateType(tags, "System.Collections.ArrayList");
			return this._filterBy("Tags.Name", new object[] { tags });
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
		 * @param {string[][]} dnf
		 * @return {Model}
		 */
		internal Model _withTagDnf(string[][] dnf)
		{
			Util.ValidateType(dnf, "System.Collections.ArrayList");
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
			Util.ValidateType(reverse, "bool");
			return this._sort("Name", reverse);
		}
		
	}
	
}
