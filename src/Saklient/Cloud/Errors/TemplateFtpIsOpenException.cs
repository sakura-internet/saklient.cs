using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。
	/// </summary>
	public class TemplateFtpIsOpenException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public TemplateFtpIsOpenException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
