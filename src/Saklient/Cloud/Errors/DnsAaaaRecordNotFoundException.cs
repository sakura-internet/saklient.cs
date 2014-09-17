using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。対応するAAAAレコードが見つかりません。
	 */
	class DnsAaaaRecordNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.DnsAaaaRecordNotFoundException#DefaultMessage
		 * @default "不適切な要求です。対応するAAAAレコードが見つかりません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。対応するAAAAレコードが見つかりません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DnsAaaaRecordNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
