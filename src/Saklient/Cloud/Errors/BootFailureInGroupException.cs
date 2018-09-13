using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/// <summary>サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。
	/// </summary>
	public class BootFailureInGroupException : HttpServiceUnavailableException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public BootFailureInGroupException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
