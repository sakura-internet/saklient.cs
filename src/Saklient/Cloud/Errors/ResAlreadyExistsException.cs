using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。このIDのリソースは既に存在します。
	/// </summary>
	public class ResAlreadyExistsException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ResAlreadyExistsException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。このIDのリソースは既に存在します。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
