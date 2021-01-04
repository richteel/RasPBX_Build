using FreePBX_Utility.Utility;
using System;

namespace FreePBX_Utility.CallerId
{
    public class CallerIdResult
    {
        /*** Properties ***/
        #region
        public DateTime CallStart { get; set; }

        public string Caller { get; set; }

        public string Number { get; set; }

        public int Duration { get; set; }

        public string CallerId { get; set; }

        public string Disposition { get; set; }

        public string Source { get; set; }

        public string Destination { get; set; }

        public string UniqueId { get; set; }

        public string ErrorMessage { get; set; }

        public ExecutionTime ThreadRunTimeInfo { get; set; }
        #endregion

        /*** Constructor ***/
        #region
        public CallerIdResult()
        {
            CallStart = Common.NULL_DATE;
            Caller = string.Empty;
            Number = string.Empty;
            Duration = -1;
            CallerId = string.Empty;
            Disposition = string.Empty;
            Source = string.Empty;
            Destination = string.Empty;
            UniqueId = string.Empty;

            ErrorMessage = string.Empty;
            ThreadRunTimeInfo = new ExecutionTime();
        }
        #endregion
    }
}