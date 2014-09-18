using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このリソースは既に切断されています。
	 */
	public class ResAlreadyDisconnectedException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResAlreadyDisconnectedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このリソースは既に切断されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
