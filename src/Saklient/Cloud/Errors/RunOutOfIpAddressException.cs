using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。
	 */
	public class RunOutOfIpAddressException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public RunOutOfIpAddressException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
