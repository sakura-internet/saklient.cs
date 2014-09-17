using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。参照するリソースのサイズが合致しません。
	 */
	class SizeMismatchException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.SizeMismatchException#DefaultMessage
		 * @default "不適切な要求です。参照するリソースのサイズが合致しません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。参照するリソースのサイズが合致しません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public SizeMismatchException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
