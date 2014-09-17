using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。
	 */
	class HttpBadRequestException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpBadRequestException#DefaultMessage
		 * @default "不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。パラメータの指定誤り、入力規則違反です。入力内容をご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpBadRequestException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
