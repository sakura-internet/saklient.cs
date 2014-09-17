using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバの画面が応答していません。
	 */
	class NoDisplayResponseException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.NoDisplayResponseException#DefaultMessage
		 * @default "サービスが利用できません。サーバの画面が応答していません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。サーバの画面が応答していません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NoDisplayResponseException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
