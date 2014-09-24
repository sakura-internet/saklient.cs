using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。リソースの作成処理が進行中です。完了後に再度お試しください。
	/// </summary>
	public class StillCreatingException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public StillCreatingException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。リソースの作成処理が進行中です。完了後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
