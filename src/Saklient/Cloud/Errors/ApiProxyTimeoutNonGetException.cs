using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/// <summary>APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。
	/// </summary>
	public class ApiProxyTimeoutNonGetException : HttpGatewayTimeoutException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ApiProxyTimeoutNonGetException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
