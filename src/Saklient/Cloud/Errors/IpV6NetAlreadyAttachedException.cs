using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。
	 */
	class IpV6NetAlreadyAttachedException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.IpV6NetAlreadyAttachedException#DefaultMessage
		 * @default "要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。ConnectedなIPv6ネットワークが既に割り当て済みです。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public IpV6NetAlreadyAttachedException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
