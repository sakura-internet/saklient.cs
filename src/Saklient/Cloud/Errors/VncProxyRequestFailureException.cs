using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。VNCプロクシの要求に失敗しました。
	 */
	class VncProxyRequestFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.VncProxyRequestFailureException#DefaultMessage
		 * @default "サービスが利用できません。VNCプロクシの要求に失敗しました。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。VNCプロクシの要求に失敗しました。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public VncProxyRequestFailureException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
