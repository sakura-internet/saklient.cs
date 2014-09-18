using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。作成済みディスクを確保できませんでした。サーバが混雑している可能性があります。
	 */
	public class DiskStockRunOutException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DiskStockRunOutException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。作成済みディスクを確保できませんでした。サーバが混雑している可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
