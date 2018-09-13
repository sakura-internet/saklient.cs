using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EScope = Saklient.Cloud.Enums.EScope;

namespace Saklient.Cloud.Models
{

	/// <summary>ISOイメージを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_IsoImage : Model
	{
		
		internal override string _ApiPath()
		{
			return "/cdrom";
		}
		
		internal override string _RootKey()
		{
			return "CDROM";
		}
		
		internal override string _RootKeyM()
		{
			return "CDROMs";
		}
		
		internal override string _ClassName()
		{
			return "IsoImage";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new IsoImage(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_IsoImage Offset(long offset)
		{
			return ((Model_IsoImage)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_IsoImage Limit(long count)
		{
			return ((Model_IsoImage)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_IsoImage FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_IsoImage)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_IsoImage Reset()
		{
			return ((Model_IsoImage)(this._Reset()));
		}

        /// <summary>新規リソース作成用のオブジェクトを用意します。
        /// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
        /// </summary>
        /// <returns>リソースオブジェクト</returns>
        public IsoImage Create()
		{
			return ((IsoImage)(this._Create()));
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public IsoImage GetById(string id)
		{
			return ((IsoImage)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<IsoImage> Find()
		{
			return Util.CastArray(this._Find(), ((IsoImage)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_IsoImage WithNameLike(string name)
		{
			return ((Model_IsoImage)(this._WithNameLike(name)));
		}

        /// <summary>指定したタグを持つリソースに絞り込みます。
        /// 複数のタグを指定する場合は withTags() を利用してください。
        /// </summary>
        /// <param name="tag" />
        public Model_IsoImage WithTag(string tag)
		{
			return ((Model_IsoImage)(this._WithTag(tag)));
		}

        /// <summary>指定したすべてのタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="tags" />
        public Model_IsoImage WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_IsoImage)(this._WithTags(tags)));
		}

        /// <summary>指定したDNFに合致するタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="dnf" />
        public Model_IsoImage WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_IsoImage)(this._WithTagDnf(dnf)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_IsoImage SortByName(bool reverse=false)
		{
			return ((Model_IsoImage)(this._SortByName(reverse)));
		}
		
		public Model_IsoImage(Client client) : base(client)
		{
			/*!base!*/;
		}

        /// <summary>指定したサイズのISOイメージに絞り込みます。
        /// </summary>
        /// <param name="sizeGib" />
        public Model_IsoImage WithSizeGib(long sizeGib)
		{
			this._FilterBy("SizeMB", new System.Collections.Generic.List<object> { sizeGib * 1024 });
			return this;
		}
		
		/// <summary>パブリックISOイメージに絞り込みます。
		/// </summary>
		public Model_IsoImage WithSharedScope()
		{
			this._FilterBy("Scope", new System.Collections.Generic.List<object> { EScope.SHARED });
			return this;
		}
		
		/// <summary>プライベートISOイメージに絞り込みます。
		/// </summary>
		public Model_IsoImage WithUserScope()
		{
			this._FilterBy("Scope", new System.Collections.Generic.List<object> { EScope.USER });
			return this;
		}

        /// <summary>サイズでソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_IsoImage SortBySize(bool reverse=false)
		{
			this._Sort("SizeMB", reverse);
			return this;
		}
		
	}
	
}
