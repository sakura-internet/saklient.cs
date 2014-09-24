using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。
	/// </summary>
	public class NotReplicatingException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public NotReplicatingException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このストレージ上への指定リソースの複製は実行されていません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
