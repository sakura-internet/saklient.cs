using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。
	 */
	public class BootFailureInGroupException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public BootFailureInGroupException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
