using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このIDのリソースは既に存在します。
	 */
	public class ResAlreadyExistsException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ResAlreadyExistsException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このIDのリソースは既に存在します。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
