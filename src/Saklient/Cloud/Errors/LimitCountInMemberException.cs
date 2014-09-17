using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求を受け付けできません。アカウント数上限により作成失敗しました。
	 */
	class LimitCountInMemberException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.LimitCountInMemberException#DefaultMessage
		 * @default "要求を受け付けできません。アカウント数上限により作成失敗しました。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求を受け付けできません。アカウント数上限により作成失敗しました。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public LimitCountInMemberException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
