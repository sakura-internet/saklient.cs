using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。FTP共有は既に開始されています。
	/// </summary>
	public class FtpIsAlreadyOpenException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FtpIsAlreadyOpenException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。FTP共有は既に開始されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
