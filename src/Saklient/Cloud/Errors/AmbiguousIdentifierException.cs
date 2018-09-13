using HttpNotFoundException = Saklient.Errors.HttpNotFoundException;

namespace Saklient.Cloud.Errors
{

	/// <summary>対象が見つかりません。識別名から一意にリソースを特定できません。
	/// </summary>
	public class AmbiguousIdentifierException : HttpNotFoundException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public AmbiguousIdentifierException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "対象が見つかりません。識別名から一意にリソースを特定できません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
