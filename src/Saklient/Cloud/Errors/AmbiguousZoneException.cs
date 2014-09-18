using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。
	 */
	public class AmbiguousZoneException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public AmbiguousZoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。リクエストパラメータに指定されたゾーンをパスに含むURLへアクセスしてください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
