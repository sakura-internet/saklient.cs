using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/// <summary>対象が見つかりません。このストレージには指定リソースの複製が存在しません。
	/// </summary>
	public class ReplicaNotFoundException : HttpNotFoundException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public ReplicaNotFoundException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "対象が見つかりません。このストレージには指定リソースの複製が存在しません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
