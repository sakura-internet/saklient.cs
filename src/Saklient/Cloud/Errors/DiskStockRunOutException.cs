using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。作成済みディスクを確保できませんでした。サーバが混雑している可能性があります。
	 */
	class DiskStockRunOutException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.DiskStockRunOutException#DefaultMessage
		 * @default "サービスが利用できません。作成済みディスクを確保できませんでした。サーバが混雑している可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。作成済みディスクを確保できませんでした。サーバが混雑している可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskStockRunOutException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
