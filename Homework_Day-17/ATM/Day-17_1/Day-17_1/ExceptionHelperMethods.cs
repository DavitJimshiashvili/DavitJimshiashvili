using System;
using System.Collections.Generic;
using System.Text;

namespace Day_17_1
{
    public class ExceptionHelperMethods:Exception
    {
        public string GetLastInnerExMessage(Exception ex)
        {
            while (ex.InnerException != null)
            {
                ex = ex.InnerException;
            }
            string innerExMessage = ex.Message;

            return innerExMessage;

        }
        public string GetAllInnerExMessageTogether(Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            while (ex.InnerException != null)
            {
                sb.Append(ex.Message);
                sb.Append(",");
                ex = ex.InnerException;
            }
            sb.Append(ex.Message);
            return sb.ToString();
        }
    }
}
