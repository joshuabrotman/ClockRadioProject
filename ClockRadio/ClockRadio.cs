using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockRadio
{
    class ClockRadio
    {
        public string currentTime;
        public string currentRadioStation;
        public bool alarmState;
        public string alarmTime;

        public ClockRadio()
        {
            currentTime = "19:00";
            currentRadioStation = "97 QM";
            alarmState = false;
            alarmTime = "06:00";
        }

        public string GetTime()
        {
            return currentTime;
        }

        public void SetTime(string newTime)
        {
            currentTime = newTime;
        }

        public string GetStation()
        {
            return currentRadioStation;
        }

        public void SetStation(string newStation)
        {
            currentRadioStation = newStation;
        }

        public string GetAlarmTime()
        {
            return alarmTime;
        }

        public void SetAlarmTime(string newAlarmTime)
        {
            alarmTime = newAlarmTime;
        }

        public void ToggleAlarm()
        {
            if (alarmState == true)
            {
                alarmState = false;
            }
            else
            {
                alarmState = true;
            }
        }
    }
}
