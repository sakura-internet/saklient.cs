using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。
	 */
	class TemplateFtpIsOpenException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.TemplateFtpIsOpenException#DefaultMessage
		 * @default "要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。テンプレートのFTP共有を終了後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public TemplateFtpIsOpenException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
