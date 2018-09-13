using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバを停止できません。再度お試しください。
	/// </summary>
	public class ServerCouldNotStopException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ServerCouldNotStopException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。サーバを停止できません。再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
