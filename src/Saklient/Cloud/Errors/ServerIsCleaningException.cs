using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。
	/// </summary>
	public class ServerIsCleaningException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ServerIsCleaningException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。サーバが終了処理中です。しばらく時間をおいてから再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
