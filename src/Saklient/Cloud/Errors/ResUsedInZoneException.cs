using HttpConflictException = Saklient.Errors.HttpConflictException;

namespace Saklient.Cloud.Errors
{

	/// <summary>要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。
	/// </summary>
	public class ResUsedInZoneException : HttpConflictException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ResUsedInZoneException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "要求された操作を行えません。同一ゾーン内の他のリソースが既にこのリソースを使用中です。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
