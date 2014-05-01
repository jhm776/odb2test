using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBDIIEngineLibrary
{
    public class OBDIIEngineEventArgs : EventArgs
    {
        public int? OBDValue { get; set; }
        public string OBDMessage { get; set; }
        public bool OBDResultNoData { get; set; }

        public OBDIIEngineEventArgs(int? value, string message)
        {
            OBDValue = value;
            OBDMessage = message;
            OBDResultNoData = false;
        }

        public OBDIIEngineEventArgs(int? value, string message, bool nodata)
        {
            OBDValue = value;
            OBDMessage = message;
            OBDResultNoData = nodata;
        }
    }
}
