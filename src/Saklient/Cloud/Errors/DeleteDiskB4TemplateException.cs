using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。このテンプレートから作成したすべてのディスクを削除した後に実行してください。
	 */
	public class DeleteDiskB4TemplateException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DeleteDiskB4TemplateException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。このテンプレートから作成したすべてのディスクを削除した後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
