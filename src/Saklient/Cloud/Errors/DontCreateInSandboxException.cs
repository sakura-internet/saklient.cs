using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。ゾーンをまたぐ一部のリソースは課金対象です。料金をご確認の上、他のゾーンで作成してください。
	/// </summary>
	public class DontCreateInSandboxException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DontCreateInSandboxException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。ゾーンをまたぐ一部のリソースは課金対象です。料金をご確認の上、他のゾーンで作成してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
