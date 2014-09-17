using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このテンプレートから作成したすべてのディスクを削除した後に実行してください。
	 */
	class DeleteDiskB4TemplateException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.DeleteDiskB4TemplateException#DefaultMessage
		 * @default "要求された操作を行えません。このテンプレートから作成したすべてのディスクを削除した後に実行してください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。このテンプレートから作成したすべてのディスクを削除した後に実行してください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteDiskB4TemplateException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
