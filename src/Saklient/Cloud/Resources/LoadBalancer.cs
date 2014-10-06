using Util = Saklient.Util;
using SaklientException = Saklient.Errors.SaklientException;
using Client = Saklient.Cloud.Client;
using Appliance = Saklient.Cloud.Resources.Appliance;

namespace Saklient.Cloud.Resources
{

	/// <summary>ロードバランサの実体1つに対応し、属性の取得や操作を行うためのクラス。
	/// </summary>
	public class LoadBalancer : Appliance
	{
		
		public LoadBalancer(Client client, object obj, bool wrapped=false) : base(client, obj, wrapped)
		{
			/*!base!*/;
		}
		
	}
	
}
