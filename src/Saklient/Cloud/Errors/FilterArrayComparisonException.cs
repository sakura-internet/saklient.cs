using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。配列とは比較できない演算子がフィルタ中に含まれています。
	 */
	public class FilterArrayComparisonException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FilterArrayComparisonException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。配列とは比較できない演算子がフィルタ中に含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
