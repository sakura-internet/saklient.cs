using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>要求されたHTTPメソッドは対応していません。
	/// </summary>
	public class HttpMethodNotAllowedException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpMethodNotAllowedException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求されたHTTPメソッドは対応していません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
