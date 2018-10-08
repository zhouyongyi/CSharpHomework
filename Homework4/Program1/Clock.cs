using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class ClockEventArgs : EventArgs
    {
     public DateTime Time { set; get; }
    }
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    class Clock
    {
        public event ClockEventHandler OnTime;
        public void SetAlarm(DateTime time)
        {         
            if (OnTime != null)
            {
            ClockEventArgs args = new ClockEventArgs();
            args.Time = time;
            OnTime(this, args);
            }
        }
    }
}
