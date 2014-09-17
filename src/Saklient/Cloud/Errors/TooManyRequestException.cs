using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。リクエストの密度が高すぎます。
	 */
	class TooManyRequestException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.TooManyRequestException#DefaultMessage
		 * @default "要求を受け付けできません。リクエストの密度が高すぎます。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。リクエストの密度が高すぎます。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public TooManyRequestException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
