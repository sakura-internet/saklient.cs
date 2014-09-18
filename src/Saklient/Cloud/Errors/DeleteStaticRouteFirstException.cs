using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。
	 */
	public class DeleteStaticRouteFirstException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteStaticRouteFirstException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
