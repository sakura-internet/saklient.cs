using HttpBadRequestException = Saklient.Errors.HttpBadRequestException;

namespace Saklient.Cloud.Errors
{

	/// <summary>不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。
	/// </summary>
	public class MustBeOfSameZoneException : HttpBadRequestException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public MustBeOfSameZoneException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "不適切な要求です。参照するリソースは同一ゾーンに存在しなければなりません。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
