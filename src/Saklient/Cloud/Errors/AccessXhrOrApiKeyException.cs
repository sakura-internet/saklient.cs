using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。XHRまたはAPIキーによるアクセスのみ許可されています。
	/// </summary>
	public class AccessXhrOrApiKeyException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccessXhrOrApiKeyException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。XHRまたはAPIキーによるアクセスのみ許可されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
