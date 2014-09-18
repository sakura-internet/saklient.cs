using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/**
	 * APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。
	 */
	public class ApiProxyTimeoutException : HttpGatewayTimeoutException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ApiProxyTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
