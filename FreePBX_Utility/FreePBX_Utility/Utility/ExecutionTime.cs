using System;

namespace FreePBX_Utility.Utility
{
    public class ExecutionTime
    {
        /*** Fields ***/
        #region
        #endregion

        /*** Properties ***/
        #region
        public DateTime AverageExecutionTime
        {
            get
            {
                return ExecutionStartTime.AddMilliseconds(ExecutionCompletionTime.Subtract(ExecutionStartTime).TotalMilliseconds / 2);
            }
        }

        public DateTime ExecutionCompletionTime { get; set; }

        public DateTime ExecutionStartTime { get; set; }

        public TimeSpan TotalExecutionTime
        {
            get
            {
                return ExecutionCompletionTime.Subtract(ExecutionStartTime);
            }
        }

        public TimeSpan Uncertainty
        {
            get { return new TimeSpan(TotalExecutionTime.Ticks / 2); }
        }
        #endregion

        /*** Constructor ***/
        #region
        public ExecutionTime()
        {
            ExecutionCompletionTime = Common.NULL_DATE;
            ExecutionStartTime = DateTime.Now;
        }
        #endregion

        /*** Public Events ***/
        #region
        #endregion

        /*** Public Methods ***/
        #region
        public bool InExecutionRange(DateTime TimeToCompare)
        {
            return TimeToCompare >= ExecutionStartTime && TimeToCompare <= ExecutionCompletionTime;
        }

        public TimeSpan TimeDiff(DateTime TimeToCompare)
        {
            if (InExecutionRange(TimeToCompare))
            {
                return new TimeSpan(0);
            }

            if (TimeToCompare < ExecutionStartTime)
            {
                return ExecutionStartTime.Subtract(TimeToCompare);
            }

            return ExecutionCompletionTime.Subtract(TimeToCompare);
        }

        public string TimeDiffText(DateTime TimeToCompare)
        {
            TimeSpan timeDiff = TimeDiff(TimeToCompare);

            if (timeDiff.Ticks < 0)
            {
                return "Behind";
            }

            if (timeDiff.Ticks > 0)
            {
                return "Ahead";
            }

            return "Same";
        }
        #endregion

        /*** Event Handlers ***/
        #region
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        #endregion
    }
}
