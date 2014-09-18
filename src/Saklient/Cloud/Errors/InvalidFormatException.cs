using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータに含まれている値のフォーマットが一部不正です。
	 */
	public class InvalidFormatException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidFormatException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータに含まれている値のフォーマットが一部不正です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
