using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。FTP共有は既に終了されています。
	/// </summary>
	public class FtpIsAlreadyCloseException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FtpIsAlreadyCloseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。FTP共有は既に終了されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
