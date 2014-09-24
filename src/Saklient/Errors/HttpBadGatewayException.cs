using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>HTTPエラー。Bad Gateway.
	/// </summary>
	public class HttpBadGatewayException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpBadGatewayException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "HTTPエラー。Bad Gateway." : message)
		{
			/*!base!*/;
		}
		
	}
	
}
