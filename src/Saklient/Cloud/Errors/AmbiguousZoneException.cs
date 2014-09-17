using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。
	 */
	class AmbiguousZoneException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.AmbiguousZoneException#DefaultMessage
		 * @default "不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AmbiguousZoneException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
