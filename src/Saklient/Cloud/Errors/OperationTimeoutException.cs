using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。操作がタイムアウトしました。サーバが混雑している可能性があります。
	/// </summary>
	public class OperationTimeoutException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public OperationTimeoutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。操作がタイムアウトしました。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
