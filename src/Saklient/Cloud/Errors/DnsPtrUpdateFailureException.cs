using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。PTRレコードを設定できません。
	 */
	public class DnsPtrUpdateFailureException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public DnsPtrUpdateFailureException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。PTRレコードを設定できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
