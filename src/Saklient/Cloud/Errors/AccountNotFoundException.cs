using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。アカウントが存在しません。IDをご確認ください。
	/// </summary>
	public class AccountNotFoundException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccountNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "不適切な要求です。アカウントが存在しません。IDをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
