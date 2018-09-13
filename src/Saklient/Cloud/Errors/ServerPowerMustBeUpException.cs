using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。サーバが停止中にはこの操作を行えません。
	/// </summary>
	public class ServerPowerMustBeUpException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ServerPowerMustBeUpException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。サーバが停止中にはこの操作を行えません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
