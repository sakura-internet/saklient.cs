using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。
	 */
	class DiskLicenseMismatchException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DiskLicenseMismatchException#DefaultMessage
		 * @default "要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskLicenseMismatchException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
