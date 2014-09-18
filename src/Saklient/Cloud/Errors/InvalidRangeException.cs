using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータに含まれている値の範囲が一部不正です。
	 */
	public class InvalidRangeException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public InvalidRangeException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータに含まれている値の範囲が一部不正です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
