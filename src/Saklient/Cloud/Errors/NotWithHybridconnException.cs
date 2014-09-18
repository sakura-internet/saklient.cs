using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。
	 */
	public class NotWithHybridconnException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public NotWithHybridconnException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
