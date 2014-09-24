using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。この種類のリソースは要求された操作に対応しません。
	/// </summary>
	public class UnsupportedResClassException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public UnsupportedResClassException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。この種類のリソースは要求された操作に対応しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
