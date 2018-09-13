using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。
	/// </summary>
	public class DiskConnectionLimitException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DiskConnectionLimitException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。この接続インタフェースにこれ以上のディスクを接続することができません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
