using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバが起動中にはこの操作を行えません。
	 */
	class ServerPowerMustBeDownException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.ServerPowerMustBeDownException#DefaultMessage
		 * @default "要求された操作を行えません。サーバが起動中にはこの操作を行えません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。サーバが起動中にはこの操作を行えません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerPowerMustBeDownException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
