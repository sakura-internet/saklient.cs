using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。
	 */
	public class DuplicateUserCodeException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DuplicateUserCodeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
