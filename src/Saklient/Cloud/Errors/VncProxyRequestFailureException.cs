using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。VNCプロクシの要求に失敗しました。
	 */
	public class VncProxyRequestFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public VncProxyRequestFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。VNCプロクシの要求に失敗しました。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
