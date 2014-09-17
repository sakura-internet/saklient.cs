using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。
	 */
	class BootFailureInGroupException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.BootFailureInGroupException#DefaultMessage
		 * @default "サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。サーバ起動グループ指定に問題がある可能性があります。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public BootFailureInGroupException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
