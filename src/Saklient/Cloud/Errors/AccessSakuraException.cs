using HttpForbiddenException = Saklient.Errors.HttpForbiddenException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。
	/// </summary>
	public class AccessSakuraException : HttpForbiddenException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AccessSakuraException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作は許可されていません。さくらインターネットの会員メニューより認証後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
