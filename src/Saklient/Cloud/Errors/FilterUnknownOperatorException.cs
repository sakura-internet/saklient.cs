using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。不明な演算子がフィルタ中に含まれています。
	/// </summary>
	public class FilterUnknownOperatorException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public FilterUnknownOperatorException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。不明な演算子がフィルタ中に含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
