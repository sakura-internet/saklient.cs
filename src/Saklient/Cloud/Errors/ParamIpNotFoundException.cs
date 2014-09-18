using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。
	 */
	public class ParamIpNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ParamIpNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
