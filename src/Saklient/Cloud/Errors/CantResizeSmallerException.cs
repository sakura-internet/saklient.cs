using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。現在の容量よりも小さくリサイズすることはできません。
	/// </summary>
	public class CantResizeSmallerException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public CantResizeSmallerException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。現在の容量よりも小さくリサイズすることはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
