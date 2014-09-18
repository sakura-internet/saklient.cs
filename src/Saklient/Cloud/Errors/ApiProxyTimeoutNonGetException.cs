using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/**
	 * APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。
	 */
	public class ApiProxyTimeoutNonGetException : HttpGatewayTimeoutException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ApiProxyTimeoutNonGetException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
