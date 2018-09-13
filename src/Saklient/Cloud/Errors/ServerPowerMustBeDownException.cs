using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。サーバが起動中にはこの操作を行えません。
	/// </summary>
	public class ServerPowerMustBeDownException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ServerPowerMustBeDownException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。サーバが起動中にはこの操作を行えません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
