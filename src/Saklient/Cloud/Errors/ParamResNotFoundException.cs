using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。
	 */
	class ParamResNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.ParamResNotFoundException#DefaultMessage
		 * @default "不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ParamResNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
