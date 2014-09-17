using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/**
	 * 要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。
	 */
	class HttpNotAcceptableException : HttpException
	{
		
		/**
		 * @member saklient.errors.HttpNotAcceptableException#DefaultMessage
		 * @default "要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。サポートサイトやメンテナンス情報をご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpNotAcceptableException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
