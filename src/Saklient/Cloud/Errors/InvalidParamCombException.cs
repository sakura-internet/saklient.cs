using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。同時に指定できないパラメータが含まれています。
	 */
	class InvalidParamCombException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.InvalidParamCombException#DefaultMessage
		 * @default "不適切な要求です。同時に指定できないパラメータが含まれています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。同時に指定できないパラメータが含まれています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidParamCombException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
