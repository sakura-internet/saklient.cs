using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。nullとは比較できない演算子がフィルタ中に含まれています。
	 */
	class FilterNullComparisonException : HttpBadRequestException
	{
		
		/**
		 * @member saklient.cloud.errors.FilterNullComparisonException#DefaultMessage
		 * @default "不適切な要求です。nullとは比較できない演算子がフィルタ中に含まれています。"
		 * @type string
		 * @static
		 * @public
		 */
		public static string DefaultMessage = "不適切な要求です。nullとは比較できない演算子がフィルタ中に含まれています。";
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FilterNullComparisonException(int status, string code=null, string message="") : base(status, code, message)
		{
			/*!base!*/;
		}
		
	}
	
}
