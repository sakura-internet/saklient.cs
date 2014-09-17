using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。
	 */
	class DeleteStaticRouteFirstException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DeleteStaticRouteFirstException#DefaultMessage
		 * @default "要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteStaticRouteFirstException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
