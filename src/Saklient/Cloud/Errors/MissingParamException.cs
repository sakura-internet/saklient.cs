using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。必要なパラメータが指定されていません。
	 */
	public class MissingParamException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public MissingParamException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。必要なパラメータが指定されていません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
