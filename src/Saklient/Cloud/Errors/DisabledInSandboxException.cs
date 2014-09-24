using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。
	/// </summary>
	public class DisabledInSandboxException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DisabledInSandboxException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。このゾーンではこの操作は禁止されています。他のゾーンでお試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
