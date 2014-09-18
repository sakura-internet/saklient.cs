using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。現在の容量よりも小さくリサイズすることはできません。
	 */
	public class CantResizeSmallerException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public CantResizeSmallerException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。現在の容量よりも小さくリサイズすることはできません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
