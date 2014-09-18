using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。
	 */
	public class DiskLicenseMismatchException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskLicenseMismatchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
