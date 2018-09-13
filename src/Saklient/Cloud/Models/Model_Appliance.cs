using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using Appliance = Saklient.Cloud.Resources.Appliance;
using LoadBalancer = Saklient.Cloud.Resources.LoadBalancer;
using VpcRouter = Saklient.Cloud.Resources.VpcRouter;
using Swytch = Saklient.Cloud.Resources.Swytch;

namespace Saklient.Cloud.Models
{

	/// <summary>アプライアンスを検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_Appliance : Model
	{
		
		internal override string _ApiPath()
		{
			return "/appliance";
		}
		
		internal override string _RootKey()
		{
			return "Appliance";
		}
		
		internal override string _RootKeyM()
		{
			return "Appliances";
		}
		
		internal override string _ClassName()
		{
			return "Appliance";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			Appliance ret = new Appliance(this._Client, obj, wrapped);
			string clazz = ((string)(ret.Clazz));
			if (clazz == "loadbalancer") {
				return new LoadBalancer(this._Client, obj, wrapped);
			}
			if (clazz == "vpcrouter") {
				return new VpcRouter(this._Client, obj, wrapped);
			}
			return ret;
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_Appliance Offset(long offset)
		{
			return ((Model_Appliance)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_Appliance Limit(long count)
		{
			return ((Model_Appliance)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_Appliance FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_Appliance)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_Appliance Reset()
		{
			return ((Model_Appliance)(this._Reset()));
		}

        /// <summary>
        /// </summary>
        /// <param name="swytch" />
        /// <param name="vrid" />
        /// <param name="realIps" />
        /// <param name="isHighSpec" />
        public LoadBalancer CreateLoadBalancer(Swytch swytch, long vrid, System.Collections.Generic.List<string> realIps, bool isHighSpec=false)
		{
			LoadBalancer ret = new LoadBalancer(this._Client, null);
			return ret.SetInitialParams(swytch, vrid, realIps, isHighSpec);
		}
		
		public VpcRouter CreateVpcRouter()
		{
			VpcRouter ret = new VpcRouter(this._Client, null);
			return ret;
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public Appliance GetById(string id)
		{
			return ((Appliance)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<Appliance> Find()
		{
			return Util.CastArray(this._Find(), ((Appliance)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_Appliance WithNameLike(string name)
		{
			return ((Model_Appliance)(this._WithNameLike(name)));
		}

        /// <summary>指定したタグを持つリソースに絞り込みます。
        /// 複数のタグを指定する場合は withTags() を利用してください。
        /// </summary>
        /// <param name="tag" />
        public Model_Appliance WithTag(string tag)
		{
			return ((Model_Appliance)(this._WithTag(tag)));
		}

        /// <summary>指定したすべてのタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="tags" />
        public Model_Appliance WithTags(System.Collections.Generic.List<string> tags)
		{
			return ((Model_Appliance)(this._WithTags(tags)));
		}

        /// <summary>指定したDNFに合致するタグを持つリソースに絞り込みます。
        /// </summary>
        /// <param name="dnf" />
        public Model_Appliance WithTagDnf(System.Collections.Generic.List<System.Collections.Generic.List<string>> dnf)
		{
			return ((Model_Appliance)(this._WithTagDnf(dnf)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_Appliance SortByName(bool reverse=false)
		{
			return ((Model_Appliance)(this._SortByName(reverse)));
		}
		
		public Model_Appliance(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
