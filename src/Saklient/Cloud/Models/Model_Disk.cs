using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Disk = Saklient.Cloud.Resources.Disk;

namespace Saklient.Cloud.Models
{

	/// <summary>ディスクを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Disk : Model
	{
		
		internal override string _ApiPath()
		{
			return "/disk";
		}
		
		internal override string _RootKey()
		{
			return "Disk";
		}
		
		internal override string _RootKeyM()
		{
			return "Disks";
		}
		
		internal override string _ClassName()
		{
			return "Disk";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new Disk(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_Disk Offset(long offset)
		{
			return ((Model_Disk)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_Disk Limit(long count)
		{
			return ((Model_Disk)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_Disk FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Disk)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_Disk Reset()
		{
			return ((Model_Disk)(this._Reset()));
		}

        /// <summary>新規リソース作成用のオブジェクトを用意します。
        /// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
        /// </summary>
        /// <returns>リソースオブジェクト</returns>
        public Disk Create()
		{
			return ((Disk)(this._Create()));
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public Disk GetById(string id)
		{
			return ((Disk)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<Disk> Find()
		{
			return Util.CastArray(this._Find(), ((Disk)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_Disk WithNameLike(string name)
		{
			return ((Model_Disk)(this._WithNameLike(name)));
		}

        /// <summary>指定したタグを持つリソースに絞り込みます。
        /// 複数のタグを指定する場合は withTags() を利用してください。
        /// </summary>
        /// <param name="tag" />
        public Model_Disk WithTag(string tag)
		{
			return ((Model_Disk)(this._WithTag(tag)));
		}

        /// <summary>指定したすべてのタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="tags" />
        public Model_Disk WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Disk)(this._WithTags(tags)));
		}

        /// <summary>指定したDNFに合致するタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="dnf" />
        public Model_Disk WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Disk)(this._WithTagDnf(dnf)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Disk SortByName(bool reverse=false)
		{
			return ((Model_Disk)(this._SortByName(reverse)));
		}

        /// <summary>
        /// </summary>
        /// <param name="reverse" />
        public Model_Disk SortByConnectionOrder(bool reverse=false)
		{
			return ((Model_Disk)(this._Sort("ConnectionOrder", reverse)));
		}
		
		public Model_Disk(Client client) : base(client)
		{
			/*!base!*/;
		}

        /// <summary>指定したサイズのディスクに絞り込みます。
        /// </summary>
        /// <param name="sizeGib" />
        public Model_Disk WithSizeGib(long sizeGib)
		{
			this._FilterBy("SizeMB", new System.Collections.Generic.List<object> { sizeGib * 1024 });
			return this;
		}

        /// <summary>指定したサーバへ接続されているディスクに絞り込みます。
        /// </summary>
        /// <param name="id" />
        public Model_Disk WithServerId(string id)
		{
			this._FilterBy("Server.ID", new System.Collections.Generic.List<object> { id });
			return this;
		}

        /// <summary>サイズでソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Disk SortBySize(bool reverse=false)
		{
			this._Sort("SizeMB", reverse);
			return this;
		}
		
	}
	
}
