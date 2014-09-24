using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/// <summary>APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。
	/// </summary>
	public class ApiProxyTimeoutException : HttpGatewayTimeoutException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ApiProxyTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
