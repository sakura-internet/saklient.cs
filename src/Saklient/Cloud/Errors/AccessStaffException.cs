using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。権限エラー。
	/// </summary>
	public class AccessStaffException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccessStaffException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作は許可されていません。権限エラー。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
