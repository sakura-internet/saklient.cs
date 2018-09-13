using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このディスクへのコピー処理が進行中です。完了後に再度お試しください。
	/// </summary>
	public class DiskIsCopyingException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DiskIsCopyingException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。このディスクへのコピー処理が進行中です。完了後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
