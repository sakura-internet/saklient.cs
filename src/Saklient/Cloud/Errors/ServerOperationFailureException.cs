using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバの操作に失敗しました。
	 */
	class ServerOperationFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.ServerOperationFailureException#DefaultMessage
		 * @default "サービスが利用できません。サーバの操作に失敗しました。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。サーバの操作に失敗しました。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerOperationFailureException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
