using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。サーバとの接続を切り離した後に実行してください。
	/// </summary>
	public class DisconnectB4DeleteException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DisconnectB4DeleteException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。サーバとの接続を切り離した後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
