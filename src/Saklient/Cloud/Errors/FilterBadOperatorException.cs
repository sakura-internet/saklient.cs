using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。
	/// </summary>
	public class FilterBadOperatorException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FilterBadOperatorException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。フィールドの型に対応していない演算子がフィルタ中に含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
