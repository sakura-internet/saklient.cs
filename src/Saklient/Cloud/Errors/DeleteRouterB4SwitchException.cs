using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。
	 */
	class DeleteRouterB4SwitchException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DeleteRouterB4SwitchException#DefaultMessage
		 * @default "要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteRouterB4SwitchException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
