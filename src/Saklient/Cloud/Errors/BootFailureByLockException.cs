using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバが予期せず終了したため、ロックされています。しばらく時間をおいてから再度お試しください。
	/// </summary>
	public class BootFailureByLockException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public BootFailureByLockException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバが予期せず終了したため、ロックされています。しばらく時間をおいてから再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
