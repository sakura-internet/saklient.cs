using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。
	/// </summary>
	public class ParamResNotFoundException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ParamResNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。パラメータで指定されたリソースが存在しません。IDをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
