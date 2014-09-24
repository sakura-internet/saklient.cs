using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。必要なパラメータが指定されていません。
	/// </summary>
	public class MissingParamException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public MissingParamException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。必要なパラメータが指定されていません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
