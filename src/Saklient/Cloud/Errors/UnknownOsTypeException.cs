using HttpServiceUnavailableException = Saklient.Errors.HttpServiceUnavailableException;

namespace Saklient.Cloud.Errors
{

	/**
	 * サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。
	 */
	public class UnknownOsTypeException : HttpServiceUnavailableException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnknownOsTypeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "サービスが利用できません。ディスクにインストールされたOSが特定できないため、正しく修正できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
