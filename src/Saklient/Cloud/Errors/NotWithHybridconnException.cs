using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。
	/// </summary>
	public class NotWithHybridconnException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public NotWithHybridconnException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ハイブリッド接続と併用する場合はお問い合わせください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
