using HttpInternalServerErrorException = Saklient.Errors.HttpInternalServerErrorException;

namespace Saklient.Cloud.Errors
{

	/// <summary>予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。
	/// </summary>
	public class UnknownException : HttpInternalServerErrorException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public UnknownException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "予期しないエラーが発生しました。このエラーが繰り返し発生する場合は、サポートサイトやメンテナンス情報をご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
