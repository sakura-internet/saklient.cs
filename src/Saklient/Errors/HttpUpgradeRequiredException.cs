using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Upgrade Required.
	/// </summary>
	public class HttpUpgradeRequiredException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpUpgradeRequiredException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Upgrade Required." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
