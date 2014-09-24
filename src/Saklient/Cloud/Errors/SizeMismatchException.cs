using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。参照するリソースのサイズが合致しません。
	/// </summary>
	public class SizeMismatchException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public SizeMismatchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。参照するリソースのサイズが合致しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
