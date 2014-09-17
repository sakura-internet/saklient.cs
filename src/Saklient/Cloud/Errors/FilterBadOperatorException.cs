using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。
	 */
	class FilterBadOperatorException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.FilterBadOperatorException#DefaultMessage
		 * @default "不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FilterBadOperatorException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
