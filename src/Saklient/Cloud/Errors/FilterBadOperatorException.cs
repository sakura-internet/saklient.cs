using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/**
	 * 不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。
	 */
	public class FilterBadOperatorException : HttpBadRequestException
	{
		
		/**
		 * @constructor
		 * @public
		 * @param {long} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public FilterBadOperatorException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
