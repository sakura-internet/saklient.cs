using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。同一アカウント名で複数のアカウントを作成することはできません。
	/// </summary>
	public class DuplicateAccountCodeException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DuplicateAccountCodeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。同一アカウント名で複数のアカウントを作成することはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
