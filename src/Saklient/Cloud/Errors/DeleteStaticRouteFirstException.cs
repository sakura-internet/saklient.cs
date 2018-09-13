using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。
	/// </summary>
	public class DeleteStaticRouteFirstException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DeleteStaticRouteFirstException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。ルータを削除する前に、スタティックルートを削除してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
