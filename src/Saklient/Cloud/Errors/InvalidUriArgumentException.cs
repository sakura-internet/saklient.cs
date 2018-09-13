using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/// <summary>対象が見つかりません。パスに使用できない文字が含まれています。
	/// </summary>
	public class InvalidUriArgumentException : HttpNotFoundException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public InvalidUriArgumentException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "対象が見つかりません。パスに使用できない文字が含まれています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
