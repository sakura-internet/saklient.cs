using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。
	 */
	class ParamIpNotFoundException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.ParamIpNotFoundException#DefaultMessage
		 * @default "不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。パラメータで指定されたIPアドレスを含むネットワークが存在しません。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public ParamIpNotFoundException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
