using HttpException = Saklient.Errors.HttpException;

namespace Saklient.Errors
{

	/// <summary>サーバ内部エラーが発生しました。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。
	/// </summary>
	public class HttpInternalServerErrorException : HttpException
	{
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpInternalServerErrorException(long status, string code=null, string message="") : base(status, code, string.IsNullOrEmpty(message) ? "サーバ内部エラーが発生しました。このエラーが繰り返し発生する場合は、メンテナンス情報、サポートサイトをご確認ください。" : message)
		{
			/*!base!*/;
		}
		
	}
	
}
