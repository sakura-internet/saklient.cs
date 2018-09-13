using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Http Version Not Supported.
	/// </summary>
	public class HttpHttpVersionNotSupportedException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpHttpVersionNotSupportedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "HTTPエラー。Http Version Not Supported." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
