using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。この種類のリソースは要求された操作に対応しません。
	 */
	public class UnsupportedResClassException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnsupportedResClassException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。この種類のリソースは要求された操作に対応しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
