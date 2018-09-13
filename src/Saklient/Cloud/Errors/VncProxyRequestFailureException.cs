using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。VNCプロクシの要求に失敗しました。
	/// </summary>
	public class VncProxyRequestFailureException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public VncProxyRequestFailureException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。VNCプロクシの要求に失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
