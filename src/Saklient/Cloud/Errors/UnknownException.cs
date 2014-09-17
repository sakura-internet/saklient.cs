using HttpInternalServerErrorException = Saklient.Errors.HttpInternalServerErrorException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。
	 */
	class UnknownException : HttpInternalServerErrorException
	{
		
		/**
		 * @member saklient.cloud.errors.UnknownException#DefaultMessage
		 * @default "予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnknownException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
