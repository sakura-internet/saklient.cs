using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。自分自身をソースとするコピーはできません。
	/// </summary>
	public class CopyToItselfException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public CopyToItselfException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。自分自身をソースとするコピーはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
