using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。
	 */
	public class IpV6NetAlreadyAttachedException : HttpConflictException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public IpV6NetAlreadyAttachedException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
