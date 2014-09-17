namespace Saklient.Errors
{

	/**
	 * @module saklient.errors.HttpException
	 * @class HttpException
	 * @constructor
	 * @extends System.Exception
	 */
	class HttpException : System.Exception
	{
		
		/**
		 * @member saklient.errors.HttpException#Status
		 * @type int
		 * @public
		 */
		public int Status;
		
		/**
		 * @member saklient.errors.HttpException#Code
		 * @type string
		 * @public
		 */
		public string Code;
		
		/**
		 * @member saklient.errors.HttpException#Message
		 * @type string
		 * @public
		 */
		public string Message;
		
		/**
		 * @constructor
		 * @public
		 * @param {int} status
		 * @param {string} code=null
		 * @param {string} message=""
		 */
		public HttpException(int status, string code=null, string message="") : base(message)
		{
			/*!base!*/;
			this.Status = status;
			this.Code = code;
			this.Message = message;
		}
		
	}
	
}
