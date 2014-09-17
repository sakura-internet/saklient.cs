using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。
	 */
	class NotWithHybridconnException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.NotWithHybridconnException#DefaultMessage
		 * @default "要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotWithHybridconnException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
