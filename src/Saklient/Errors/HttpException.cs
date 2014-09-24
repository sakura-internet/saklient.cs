namespace Saklient.Errors
{

	public class HttpException : System.Exception
	{
		
		public long Status;
		
		public string Code;
		
		/// <summary>
		/// <param name="status" />
		/// <param name="code" />
		/// <param name="message" />
		/// </summary>
		public HttpException(long status, string code=null, string message="") : base(message)
		{
			/*!base!*/;
			this.Status = status;
			this.Code = code;
		}
		
	}
	
}
