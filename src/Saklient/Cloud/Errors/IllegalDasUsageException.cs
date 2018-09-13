using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。DASの利用方法に問題があります。1台のサーバには同一のストレージ上にあるDASのみを接続できます。
	/// </summary>
	public class IllegalDasUsageException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public IllegalDasUsageException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。DASの利用方法に問題があります。1台のサーバには同一のストレージ上にあるDASのみを接続できます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
