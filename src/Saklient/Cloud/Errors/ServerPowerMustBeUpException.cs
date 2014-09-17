using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバが停止中にはこの操作を行えません。
	 */
	class ServerPowerMustBeUpException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ServerPowerMustBeUpException#DefaultMessage
		 * @default "要求された操作を行えません。サーバが停止中にはこの操作を行えません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。サーバが停止中にはこの操作を行えません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerPowerMustBeUpException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
