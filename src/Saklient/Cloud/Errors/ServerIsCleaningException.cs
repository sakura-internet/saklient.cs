using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。
	 */
	class ServerIsCleaningException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ServerIsCleaningException#DefaultMessage
		 * @default "要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerIsCleaningException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
