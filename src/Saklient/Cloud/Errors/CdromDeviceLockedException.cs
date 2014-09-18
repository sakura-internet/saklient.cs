using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。CD-ROMドライブがロックされています。
	 */
	public class CdromDeviceLockedException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CdromDeviceLockedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。CD-ROMドライブがロックされています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
