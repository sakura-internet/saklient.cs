using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。対応するAAAAレコードが見つかりません。
	/// </summary>
	public class DnsAaaaRecordNotFoundException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DnsAaaaRecordNotFoundException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。対応するAAAAレコードが見つかりません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
