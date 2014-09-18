using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。参照するリソースのサイズが合致しません。
	 */
	public class SizeMismatchException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public SizeMismatchException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。参照するリソースのサイズが合致しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
