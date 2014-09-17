using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。CD-ROMドライブがロックされています。
	 */
	class CdromDeviceLockedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.CdromDeviceLockedException#DefaultMessage
		 * @default "要求された操作を行えません。CD-ROMドライブがロックされています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。CD-ROMドライブがロックされています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CdromDeviceLockedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
