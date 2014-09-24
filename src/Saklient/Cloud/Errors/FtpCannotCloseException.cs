using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。FTP共有によりアップロードされたファイルを操作できません。ファイル名等をご確認ください。
	/// </summary>
	public class FtpCannotCloseException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FtpCannotCloseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。FTP共有によりアップロードされたファイルを操作できません。ファイル名等をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
