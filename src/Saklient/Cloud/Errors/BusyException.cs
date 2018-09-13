using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバが混雑しています。しばらく時間をおいてから再度お試しください。
	/// </summary>
	public class BusyException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public BusyException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。サーバが混雑しています。しばらく時間をおいてから再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
