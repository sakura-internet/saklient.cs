using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。
	 */
	public class ParamResNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ParamResNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
