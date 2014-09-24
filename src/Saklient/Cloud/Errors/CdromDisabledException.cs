using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。
	/// </summary>
	public class CdromDisabledException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public CdromDisabledException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ISOイメージが無効化されています。排出後に再度お試しください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
