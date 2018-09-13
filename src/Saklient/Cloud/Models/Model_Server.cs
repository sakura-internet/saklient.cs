using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Server = Saklient.Cloud.Resources.Server;
using ServerPlan = Saklient.Cloud.Resources.ServerPlan;
using IsoImage = Saklient.Cloud.Resources.IsoImage;
using EServerInstanceStatus = Saklient.Cloud.Enums.EServerInstanceStatus;

namespace Saklient.Cloud.Models
{

	/// <summary>サーバを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Server : Model
	{
		
		internal override string _ApiPath()
		{
			return "/server";
		}
		
		internal override string _RootKey()
		{
			return "Server";
		}
		
		internal override string _RootKeyM()
		{
			return "Servers";
		}
		
		internal override string _ClassName()
		{
			return "Server";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			return new Server(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_Server Offset(long offset)
		{
			return ((Model_Server)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_Server Limit(long count)
		{
			return ((Model_Server)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_Server FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Server)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_Server Reset()
		{
			return ((Model_Server)(this._Reset()));
		}

        /// <summary>新規リソース作成用のオブジェクトを用意します。
        /// 返り値のオブジェクトにパラメータを設定し、save() を呼ぶことで実際のリソースが作成されます。
        /// </summary>
        /// <returns>リソースオブジェクト</returns>
        public Server Create()
		{
			return ((Server)(this._Create()));
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public Server GetById(string id)
		{
			return ((Server)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<Server> Find()
		{
			return Util.CastArray(this._Find(), ((Server)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_Server WithNameLike(string name)
		{
			return ((Model_Server)(this._WithNameLike(name)));
		}

        /// <summary>指定したタグを持つリソースに絞り込みます。
        /// 複数のタグを指定する場合は withTags() を利用してください。
        /// </summary>
        /// <param name="tag" />
        public Model_Server WithTag(string tag)
		{
			return ((Model_Server)(this._WithTag(tag)));
		}

        /// <summary>指定したすべてのタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="tags" />
        public Model_Server WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Server)(this._WithTags(tags)));
		}

        /// <summary>指定したDNFに合致するタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="dnf" />
        public Model_Server WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Server)(this._WithTagDnf(dnf)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Server SortByName(bool reverse=false)
		{
			return ((Model_Server)(this._SortByName(reverse)));
		}
		
		public Model_Server(Client client) : base(client)
		{
			/*!base!*/;
		}

        /// <summary>指定したプランのサーバに絞り込みます。
        /// </summary>
        /// <param name="plan" />
        public Model_Server WithPlan(ServerPlan plan)
		{
			this._FilterBy("ServerPlan.ID", new System.Collections.Generic.List<object> { plan._Id() });
			return this;
		}

        /// <summary>インスタンスが指定した状態にあるサーバに絞り込みます。
        /// </summary>
        /// <param name="status" />
        public Model_Server WithStatus(string status)
		{
			this._FilterBy("Instance.Status", new System.Collections.Generic.List<object> { status });
			return this;
		}
		
		/// <summary>インスタンスが起動中のサーバに絞り込みます。
		/// </summary>
		public Model_Server WithStatusUp()
		{
			return this.WithStatus(EServerInstanceStatus.UP);
		}
		
		/// <summary>インスタンスが停止中のサーバに絞り込みます。
		/// </summary>
		public Model_Server WithStatusDown()
		{
			return this.WithStatus(EServerInstanceStatus.DOWN);
		}

        /// <summary>指定したISOイメージが挿入されているサーバに絞り込みます。
        /// </summary>
        /// <param name="iso" />
        public Model_Server WithIsoImage(IsoImage iso)
		{
			this._FilterBy("Instance.CDROM.ID", new System.Collections.Generic.List<object> { iso._Id() });
			return this;
		}

        /// <summary>仮想コア数でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Server SortByCpu(bool reverse=false)
		{
			this._Sort("ServerPlan.CPU", reverse);
			return this;
		}

        /// <summary>メモリ容量でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Server SortByMemory(bool reverse=false)
		{
			this._Sort("ServerPlan.MemoryMB", reverse);
			return this;
		}
		
	}
	
}
