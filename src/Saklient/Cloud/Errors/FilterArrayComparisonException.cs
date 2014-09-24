using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。配列とは比較できない演算子がフィルタ中に含まれています。
	/// </summary>
	public class FilterArrayComparisonException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FilterArrayComparisonException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。配列とは比較できない演算子がフィルタ中に含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
