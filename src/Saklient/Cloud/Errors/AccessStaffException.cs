using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作は許可されていません。権限エラー。
	 */
	public class AccessStaffException : HttpForbiddenException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccessStaffException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。権限エラー。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
