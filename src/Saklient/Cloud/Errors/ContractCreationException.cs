using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求を受け付けできません。契約コードを発行することができません。メンテナンス情報、サポートサイトをご確認ください。
	/// </summary>
	public class ContractCreationException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ContractCreationException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求を受け付けできません。契約コードを発行することができません。メンテナンス情報、サポートサイトをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
