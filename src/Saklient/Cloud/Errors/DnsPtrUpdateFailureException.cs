using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。PTRレコードを設定できません。
	 */
	class DnsPtrUpdateFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @member saklient.cloud.errors.DnsPtrUpdateFailureException#DefaultMessage
		 * @default "サービスが利用できません。PTRレコードを設定できません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "サービスが利用できません。PTRレコードを設定できません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DnsPtrUpdateFailureException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
