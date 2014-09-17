using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ファイルをアップロード後に実行してください。
	 */
	class FileNotUploadedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.FileNotUploadedException#DefaultMessage
		 * @default "要求された操作を行えません。ファイルをアップロード後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ファイルをアップロード後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FileNotUploadedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
