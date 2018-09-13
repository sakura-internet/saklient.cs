using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。
	/// </summary>
	public class HttpBadRequestException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpBadRequestException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
