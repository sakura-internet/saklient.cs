using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。オリジナルのデータを取得してからこのリクエストを行うまでの間に、他の変更が加わった可能性があります。
	 */
	class OriginalHashMismatchException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.OriginalHashMismatchException#DefaultMessage
		 * @default "要求された操作を行えません。オリジナルのデータを取得してからこのリクエストを行うまでの間に、他の変更が加わった可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。オリジナルのデータを取得してからこのリクエストを行うまでの間に、他の変更が加わった可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public OriginalHashMismatchException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
