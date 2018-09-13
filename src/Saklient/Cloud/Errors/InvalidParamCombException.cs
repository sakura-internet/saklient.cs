using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。同時に指定できないパラメータが含まれています。
	/// </summary>
	public class InvalidParamCombException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public InvalidParamCombException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。同時に指定できないパラメータが含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
