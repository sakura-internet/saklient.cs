using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。アカウントが存在しません。IDをご確認ください。
	 */
	class AccountNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.AccountNotFoundException#DefaultMessage
		 * @default "不適切な要求です。アカウントが存在しません。IDをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。アカウントが存在しません。IDをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AccountNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
