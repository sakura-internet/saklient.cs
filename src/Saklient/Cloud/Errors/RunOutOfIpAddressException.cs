using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。
	 */
	class RunOutOfIpAddressException : HttpConflictException
	{
		
		/**
		 * @member saklient.cloud.errors.RunOutOfIpAddressException#DefaultMessage
		 * @default "要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "要求された操作を行えません。指定されたネットワークに属するIPアドレスはすべて使用中です。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public RunOutOfIpAddressException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
