using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このディスクへのコピー処理が進行中です。完了後に再度お試しください。
	 */
	public class DiskIsCopyingException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskIsCopyingException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このディスクへのコピー処理が進行中です。完了後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
