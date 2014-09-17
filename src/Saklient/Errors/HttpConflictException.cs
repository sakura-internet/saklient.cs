using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。
	 */
	class HttpConflictException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpConflictException#DefaultMessage
		 * @default "要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。現在の対象の状態では、この操作を受け付けできません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpConflictException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
