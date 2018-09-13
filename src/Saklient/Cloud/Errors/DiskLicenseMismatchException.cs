using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。
	/// </summary>
	public class DiskLicenseMismatchException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public DiskLicenseMismatchException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。ライセンスの問題により、組み合わせて使用できないディスクが接続されています。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
