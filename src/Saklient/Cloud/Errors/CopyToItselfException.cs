using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。自分自身をソースとするコピーはできません。
	 */
	public class CopyToItselfException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CopyToItselfException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。自分自身をソースとするコピーはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
