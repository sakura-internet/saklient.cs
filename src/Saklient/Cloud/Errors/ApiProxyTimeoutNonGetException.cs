using HttpGatewayTimeoutException = Saklient.Errors.HttpGatewayTimeoutException;

namespace Saklient.Cloud.Errors
{

	/**
	 * APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。
	 */
	class ApiProxyTimeoutNonGetException : HttpGatewayTimeoutException
	{
		
		/**
		 * @member saklient.cloud.errors.ApiProxyTimeoutNonGetException#DefaultMessage
		 * @default "APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "APIプロクシが応答しません。要求は実行された可能性があります。しばらく時間をおいてからご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ApiProxyTimeoutNonGetException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
