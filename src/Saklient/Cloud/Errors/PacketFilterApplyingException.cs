using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。起動中のサーバに対して変更されたパケットフィルタを反映するタスクが既に実行中です。
	 */
	class PacketFilterApplyingException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.PacketFilterApplyingException#DefaultMessage
		 * @default "要求された操作を行えません。起動中のサーバに対して変更されたパケットフィルタを反映するタスクが既に実行中です。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。起動中のサーバに対して変更されたパケットフィルタを反映するタスクが既に実行中です。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public PacketFilterApplyingException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
