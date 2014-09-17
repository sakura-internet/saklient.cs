using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/**
	 * APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。
	 */
	class ApiProxyTimeoutException : HttpGatewayTimeoutException
	{
		
		/**
		 * @member saklient.cloud.errors.ApiProxyTimeoutException#DefaultMessage
		 * @default "APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "APIプロクシがタイムアウトしました。サーバが混雑している可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ApiProxyTimeoutException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
