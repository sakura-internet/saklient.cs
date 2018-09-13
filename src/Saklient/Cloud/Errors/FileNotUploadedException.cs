using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ファイルをアップロード後に実行してください。
	/// </summary>
	public class FileNotUploadedException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FileNotUploadedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。ファイルをアップロード後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
