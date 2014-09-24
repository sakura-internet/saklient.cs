using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。
	/// </summary>
	public class HttpNotFoundException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpNotFoundException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "対象が見つかりません。対象は利用できない状態か、IDまたはパスに誤りがあります。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
