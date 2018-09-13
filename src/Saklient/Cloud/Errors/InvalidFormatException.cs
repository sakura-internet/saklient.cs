using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。パラメータに含まれている値のフォーマットが一部不正です。
	/// </summary>
	public class InvalidFormatException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public InvalidFormatException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。パラメータに含まれている値のフォーマットが一部不正です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
