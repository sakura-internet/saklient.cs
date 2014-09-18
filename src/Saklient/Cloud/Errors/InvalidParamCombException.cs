using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。同時に指定できないパラメータが含まれています。
	 */
	public class InvalidParamCombException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidParamCombException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。同時に指定できないパラメータが含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
