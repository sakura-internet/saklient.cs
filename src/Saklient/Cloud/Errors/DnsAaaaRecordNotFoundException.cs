using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。対応するAAAAレコードが見つかりません。
	 */
	public class DnsAaaaRecordNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DnsAaaaRecordNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。対応するAAAAレコードが見つかりません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
