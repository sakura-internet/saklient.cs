using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバの画面が応答していません。
	/// </summary>
	public class NoDisplayResponseException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public NoDisplayResponseException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。サーバの画面が応答していません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
