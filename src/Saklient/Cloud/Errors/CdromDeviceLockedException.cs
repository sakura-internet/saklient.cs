using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。CD-ROMドライブがロックされています。
	/// </summary>
	public class CdromDeviceLockedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public CdromDeviceLockedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。CD-ROMドライブがロックされています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
