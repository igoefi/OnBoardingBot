using System;
using System.Timers;
using System.Windows;

namespace TelegramBot.Classes.Helper
{
    public class TimeSaver
    {
        private Timer _timer = new Timer();
        public TimeSaver()
        {
            _timer.Interval = 5000;
            _timer.Enabled = true;
            _timer.Elapsed += new ElapsedEventHandler(Save);
            _timer.Start();
        }

        private void Save(Object myObject, EventArgs myEventArgs) =>
            JSONSerializeController.SerializeObject(CompanyProfile.Data, PathFile.PathFileStr);
    }
}
