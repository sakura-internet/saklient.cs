using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。
	 */
	public class MustBeOfSameZoneException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public MustBeOfSameZoneException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
