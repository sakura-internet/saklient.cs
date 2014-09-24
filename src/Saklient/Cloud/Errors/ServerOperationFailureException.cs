using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバの操作に失敗しました。
	/// </summary>
	public class ServerOperationFailureException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ServerOperationFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバの操作に失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
