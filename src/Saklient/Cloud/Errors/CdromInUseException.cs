using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ISOイメージをサーバから排出後に実行してください。
	/// </summary>
	public class CdromInUseException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public CdromInUseException(long status, string code=null, string message="") : base(status, code, message == null || message == "" ? "要求された操作を行えません。ISOイメージをサーバから排出後に実行してください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
