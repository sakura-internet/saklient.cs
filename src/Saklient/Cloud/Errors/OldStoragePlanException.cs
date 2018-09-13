using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。旧ストレージディスクの提供は終了しました。サーバから該当するディスクを取り外した後、再度お試しください。
	/// </summary>
	public class OldStoragePlanException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public OldStoragePlanException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。旧ストレージディスクの提供は終了しました。サーバから該当するディスクを取り外した後、再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
