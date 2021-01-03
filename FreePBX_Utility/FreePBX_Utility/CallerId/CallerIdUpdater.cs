using System;
using System.ComponentModel;
using FreePBX_Utility.Web;

namespace FreePBX_Utility.CallerId
{
    public class CallerIdUpdater
    {
        /*** Fields and Constants ***/
        #region
        readonly BackgroundWorker backgroundWorker1;
        CallerIdResult _lastCall;
        #endregion

        /*** Properties ***/
        #region
        protected BackgroundWorker BackgroundWorker1
        {
            get { return backgroundWorker1; }
        }

        public CallerIdResult LastCall { get { return _lastCall; } }

        public string SourceUrl { get; set; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public CallerIdUpdater()
        {
            backgroundWorker1 = new BackgroundWorker();

            BackgroundWorker1.RunWorkerCompleted += BackgroundWorker1_RunWorkerCompleted;
            BackgroundWorker1.DoWork += BackgroundWorker1_DoWork;

            _lastCall = new CallerIdResult();
        }


        #endregion

        /*** Public Events ***/
        #region
        public event EventHandler<EventArgs> Updated;

        public void CallerId_Updated(object sender, EventArgs e)
        {
            Updated?.Invoke(sender, e);
        }
        #endregion

        /*** Public Methods ***/
        #region
        public void Update()
        {
            BackgroundWorker1.RunWorkerAsync(this);
        }
        #endregion

        /*** Protected Methods ***/
        #region
        #endregion

        /*** Private Methods ***/
        #region
        #endregion

        /*** Event Handlers ***/
        #region
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            CallerIdResult result = new CallerIdResult();
            string url = ((CallerIdUpdater)e.Argument).SourceUrl;

            result.ThreadRunTimeInfo.ExecutionStartTime = DateTime.Now;

            string webText = WebContent.GetResponseText(url);

            if (webText != string.Empty)
            {
                string[] fields = webText.Split('\t');

                if (fields.Length == 9)
                {
                    try
                    {
                        result.CallStart = DateTime.Parse(fields[0]);
                        result.Caller = fields[1];
                        result.Number = fields[2];
                        result.Duration = fields[3] == string.Empty ? -1 : int.Parse(fields[3]);
                        result.CallerId = fields[4];
                        result.Disposition = fields[5];
                        result.Source = fields[6];
                        result.Destination = fields[7];
                        result.UniqueId = fields[8].Trim();
                    }
                    catch (Exception ex)
                    {
                        result.ErrorMessage = ex.Message;
                    }
                }
            }

            result.ThreadRunTimeInfo.ExecutionCompletionTime = DateTime.Now;
            e.Result = result;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _lastCall = (CallerIdResult)e.Result;

            CallerId_Updated(this, new EventArgs());
        }
        #endregion
    }
}
