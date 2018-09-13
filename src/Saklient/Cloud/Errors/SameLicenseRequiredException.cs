using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。再インストール時に指定できるソースは、同一のライセンスを必要とするアーカイブに限られます。
	/// </summary>
	public class SameLicenseRequiredException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public SameLicenseRequiredException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。再インストール時に指定できるソースは、同一のライセンスを必要とするアーカイブに限られます。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
