using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このリソースから他のリソースへのコピー処理が進行中です。完了後に再度お試しください。
	/// </summary>
	public class InMigrationException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public InMigrationException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このリソースから他のリソースへのコピー処理が進行中です。完了後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
