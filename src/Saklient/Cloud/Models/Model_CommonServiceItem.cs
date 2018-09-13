using Util = Saklient.Util;
using Client = Saklient.Cloud.Client;
using Model = Saklient.Cloud.Models.Model;
using Resource = Saklient.Cloud.Resources.Resource;
using CommonServiceItem = Saklient.Cloud.Resources.CommonServiceItem;
using Gslb = Saklient.Cloud.Resources.Gslb;

namespace Saklient.Cloud.Models
{

	/// <summary>共通サービス契約を検索・作成するための機能を備えたクラス。
	/// </summary>
	public class Model_CommonServiceItem : Model
	{
		
		internal override string _ApiPath()
		{
			return "/commonserviceitem";
		}
		
		internal override string _RootKey()
		{
			return "CommonServiceItem";
		}
		
		internal override string _RootKeyM()
		{
			return "CommonServiceItems";
		}
		
		internal override string _ClassName()
		{
			return "CommonServiceItem";
		}
		
		internal override Resource _CreateResourceImpl(object obj, bool wrapped=false)
		{
			string clazz = ((string)(Util.GetByPath(obj, "CommonServiceItem.Provider.Class")));
			if (clazz == "gslb") {
				return new Gslb(this._Client, obj, wrapped);
			}
			return new CommonServiceItem(this._Client, obj, wrapped);
		}

        /// <summary>次に取得するリストの開始オフセットを指定します。
        /// </summary>
        /// <param name="offset">オフセット</param>
        /// <returns>this</returns>
        public Model_CommonServiceItem Offset(long offset)
		{
			return ((Model_CommonServiceItem)(this._Offset(offset)));
		}

        /// <summary>次に取得するリストの上限レコード数を指定します。
        /// </summary>
        /// <param name="count">上限レコード数</param>
        /// <returns>this</returns>
        public Model_CommonServiceItem Limit(long count)
		{
			return ((Model_CommonServiceItem)(this._Limit(count)));
		}

        /// <summary>Web APIのフィルタリング設定を直接指定します。
        /// </summary>
        /// <param name="key">キー</param>
        /// <param name="value">値</param>
        /// <param name="multiple">valueに配列を与え、OR条件で完全一致検索する場合にtrueを指定します。通常、valueはスカラ値であいまい検索されます。</param>
        public Model_CommonServiceItem FilterBy(string key, object value, bool multiple=false)
		{
			return ((Model_CommonServiceItem)(this._FilterBy(key, value, multiple)));
		}

        /// <summary>次のリクエストのために設定されているステートをすべて破棄します。
        /// </summary>
        /// <returns>this</returns>
        public Model_CommonServiceItem Reset()
		{
			return ((Model_CommonServiceItem)(this._Reset()));
		}

        /// <summary>
        /// </summary>
        /// <param name="protocol" />
        /// <param name="delayLoop" />
        /// <param name="weighted" />
        public Gslb CreateGslb(string protocol, long delayLoop=10, bool weighted=true)
		{
			Gslb ret = new Gslb(this._Client, null);
			ret.SetInitialParams(protocol, delayLoop, weighted);
			return ret;
		}

        /// <summary>指定したIDを持つ唯一のリソースを取得します。
        /// </summary>
        /// <param name="id" />
        /// <returns>リソースオブジェクト</returns>
        public CommonServiceItem GetById(string id)
		{
			return ((CommonServiceItem)(this._GetById(id)));
		}

        /// <summary>リソースの検索リクエストを実行し、結果をリストで取得します。
        /// </summary>
        /// <returns>リソースオブジェクトの配列</returns>
        public System.Collections.Generic.List<CommonServiceItem> Find()
		{
			return Util.CastArray(this._Find(), ((CommonServiceItem)(null)));
		}

        /// <summary>指定した文字列を名前に含むリソースに絞り込みます。
        /// 大文字・小文字は区別されません。
        /// 半角スペースで区切られた複数の文字列は、それらをすべて含むことが条件とみなされます。
        /// </summary>
        /// <param name="name" />
        public Model_CommonServiceItem WithNameLike(string name)
		{
			return ((Model_CommonServiceItem)(this._WithNameLike(name)));
		}

        /// <summary>名前でソートします。
        /// </summary>
        /// <param name="reverse" />
        public Model_CommonServiceItem SortByName(bool reverse=false)
		{
			return ((Model_CommonServiceItem)(this._SortByName(reverse)));
		}
		
		public Model_CommonServiceItem(Client client) : base(client)
		{
			/*!base!*/;
		}
		
	}
	
}
