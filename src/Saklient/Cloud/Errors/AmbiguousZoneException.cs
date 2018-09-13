using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。
	/// </summary>
	public class AmbiguousZoneException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AmbiguousZoneException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
