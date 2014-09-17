using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * サーバ内部エラーが発生しました。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。
	 */
	class HttpInternalServerErrorException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpInternalServerErrorException#DefaultMessage
		 * @default "サーバ内部エラーが発生しました。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サーバ内部エラーが発生しました。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpInternalServerErrorException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
