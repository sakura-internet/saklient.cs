using HttpInternalServerErrorException = Saklient.Errors.HttpInternalServerErrorException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。
	 */
	public class UnknownException : HttpInternalServerErrorException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public UnknownException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
