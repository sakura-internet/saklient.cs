using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。必要なパラメータが指定されていません。
	 */
	class MissingParamException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.MissingParamException#DefaultMessage
		 * @default "不適切な要求です。必要なパラメータが指定されていません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。必要なパラメータが指定されていません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public MissingParamException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
