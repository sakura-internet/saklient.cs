using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。
	/// </summary>
	public class DeleteResB4AccountException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DeleteResB4AccountException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。現在のアカウントで使用している全てのリソースを削除した後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
