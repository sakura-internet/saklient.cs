using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。APIキーによるアクセスはできません。
	/// </summary>
	public class AccessApiKeyDisabledException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccessApiKeyDisabledException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作は許可されていません。APIキーによるアクセスはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
