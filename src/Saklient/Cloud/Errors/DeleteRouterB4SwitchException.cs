using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。
	 */
	public class DeleteRouterB4SwitchException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteRouterB4SwitchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ルータを削除することでスイッチは同時に削除されます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
