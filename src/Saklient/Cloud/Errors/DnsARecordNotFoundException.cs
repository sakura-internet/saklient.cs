using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。対応するAレコードが見つかりません。
	/// </summary>
	public class DnsARecordNotFoundException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DnsARecordNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。対応するAレコードが見つかりません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
