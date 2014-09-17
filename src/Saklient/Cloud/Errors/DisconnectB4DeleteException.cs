using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバとの接続を切り離した後に実行してください。
	 */
	class DisconnectB4DeleteException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DisconnectB4DeleteException#DefaultMessage
		 * @default "要求された操作を行えません。サーバとの接続を切り離した後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。サーバとの接続を切り離した後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DisconnectB4DeleteException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
