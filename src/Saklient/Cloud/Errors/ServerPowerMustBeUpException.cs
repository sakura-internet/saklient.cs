using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。サーバが停止中にはこの操作を行えません。
	 */
	public class ServerPowerMustBeUpException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ServerPowerMustBeUpException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。サーバが停止中にはこの操作を行えません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
