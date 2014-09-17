using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * サービスが利用できません。対象は利用できない、またはサーバが混雑しています。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。
	 */
	class HttpServiceUnavailableException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpServiceUnavailableException#DefaultMessage
		 * @default "サービスが利用できません。対象は利用できない、またはサーバが混雑しています。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。対象は利用できない、またはサーバが混雑しています。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpServiceUnavailableException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
