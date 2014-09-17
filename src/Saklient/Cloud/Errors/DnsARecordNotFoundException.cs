using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。対応するAレコードが見つかりません。
	 */
	class DnsARecordNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.DnsARecordNotFoundException#DefaultMessage
		 * @default "不適切な要求です。対応するAレコードが見つかりません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。対応するAレコードが見つかりません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DnsARecordNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
