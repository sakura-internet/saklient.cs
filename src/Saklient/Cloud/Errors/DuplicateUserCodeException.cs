using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。
	/// </summary>
	public class DuplicateUserCodeException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DuplicateUserCodeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。同一ユーザ名で複数のユーザを作成することはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
