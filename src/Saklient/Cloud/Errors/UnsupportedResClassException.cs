using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。この種類のリソースは要求された操作に対応しません。
	 */
	class UnsupportedResClassException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.UnsupportedResClassException#DefaultMessage
		 * @default "不適切な要求です。この種類のリソースは要求された操作に対応しません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。この種類のリソースは要求された操作に対応しません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnsupportedResClassException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
