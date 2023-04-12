using System;
using System.Timers;

namespace TelegramBot.Classes.Helper
{
    public class TimeSaver
    {
        private readonly Timer _timer = new Timer();
        public TimeSaver()
        {
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Elapsed += new ElapsedEventHandler(Save);
            _timer.Start();
        }

        private void Save(object myObject, EventArgs myEventArgs) =>
            JSONSerializeController.SerializeObject(CompanyProfile.Data, PathFile.PathFileStr);
    }
}