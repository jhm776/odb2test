using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//    http://obdcsharpwrapper.codeplex.com/

namespace OBDIIEngineLibrary
{
    public class OBDIIEngine
    {
        public delegate void Initializing(OBDIIEngineEventArgs args);
        public delegate void Initialized(OBDIIEngineEventArgs args);

        System.IO.Ports.SerialPort sp;
        public bool PortStatusAutoCheck = true;

        public OBDIIEngine(string portName)
        {
            InitializePort(portName, false);
        }

        public OBDIIEngine(string portName, bool openPort)
        {
            InitializePort(portName, openPort);
        }

        private void InitializePort(string portName, bool openPort)
        {
            sp = new System.IO.Ports.SerialPort(portName);
            if (openPort)
                OpenPort();
        }

        public event Initializing OnOpenPortInit;
        public event Initialized OnOpenPortDone;
        public void OpenPort()
        {
            if (!sp.IsOpen)
            {
                if (OnOpenPortInit != null)
                    OnOpenPortInit(new OBDIIEngineEventArgs(null, null));
                sp.Open();
                sp.DiscardInBuffer();
                sp.DiscardOutBuffer();
                if (OnOpenPortDone != null)
                    OnOpenPortDone(new OBDIIEngineEventArgs(null, null));
            }
        }

        public event Initializing OnClosePortInit;
        public event Initialized OnClosePortDone;
        public void ClosePort()
        {
            if (sp.IsOpen)
            {
                if (OnClosePortInit != null)
                    OnClosePortInit(new OBDIIEngineEventArgs(null, null));
                sp.Close();
                if (OnClosePortDone != null)
                    OnClosePortDone(new OBDIIEngineEventArgs(null, null));
            }
        }

        private void CheckSerialPort()
        {
            if (PortStatusAutoCheck)
                OpenPort();
        }

        private string GetValue(string pid)
        {
            sp.Write(pid + "\r");
            System.Threading.Thread.Sleep(100);
            int buffSize = 1024;
            bool cont = true;
            int count = 0;
            byte[] bff = new byte[buffSize];
            string retVal = string.Empty;
            while (cont)
            {
                count = sp.Read(bff, 0, buffSize);
                retVal += System.Text.Encoding.Default.GetString(bff, 0, count);
                if (retVal.Contains(">"))
                {
                    cont = false;
                }
            }
            return retVal.Replace("\n", "");
        }

        public event Initializing OnGetSpeedInit;
        public event Initialized OnGetSpeedDone;
        public int? GetSpeedKmh()
        {
            CheckSerialPort();
            string obdMessage = "010D";
            if (OnGetSpeedInit != null)
                OnGetSpeedInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16);
            if (OnGetSpeedDone != null)
                OnGetSpeedDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }

        public event Initializing OnGetEngineTempInit;
        public event Initialized OnGetEngineTempDone;
        public int? GetEngineTemp()
        {
            CheckSerialPort();
            string obdMessage = "0105";
            if (OnGetEngineTempInit != null)
                OnGetEngineTempInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16) - 40;
            if (OnGetEngineTempDone != null)
                OnGetEngineTempDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }

        public event Initializing OnGetEngineRpmInit;
        public event Initialized OnGetEngineRpmDone;
        public int? GetEngineRpm()
        {
            CheckSerialPort();
            string obdMessage = "010C";
            if (OnGetEngineRpmInit != null)
                OnGetEngineRpmInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int data1 = Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16);
            int data2 = Convert.ToInt32(data.Split(' ')[3].Replace("\r>", string.Empty), 16);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)((data1 * 256) + data2) / 4;
            if (OnGetEngineRpmDone != null)
                OnGetEngineRpmDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }

        public event Initializing OnGetThrottlePositionInit;
        public event Initialized OnGetThrottlePositionDone;
        public int? GetThrottlePosition()
        {
            CheckSerialPort();
            string obdMessage = "0111";
            if (OnGetThrottlePositionInit != null)
                OnGetThrottlePositionInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16) * 100 / 255;
            if (OnGetThrottlePositionDone != null)
                OnGetThrottlePositionDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }

        public event Initializing OnGetCalculatedEngineLoadValueInit;
        public event Initialized OnGetCalculatedEngineLoadValueDone;
        public int? GetCalculatedEngineLoadValue()
        {
            CheckSerialPort();
            string obdMessage = "0104";
            if (OnGetCalculatedEngineLoadValueInit != null)
                OnGetCalculatedEngineLoadValueInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16) * 100 / 255;
            if (OnGetCalculatedEngineLoadValueDone != null)
                OnGetCalculatedEngineLoadValueDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }

        public event Initializing OnGetFuelPressureInit;
        public event Initialized OnGetFuelPressureDone;
        public int? GetFuelPressure()
        {
            CheckSerialPort();
            string obdMessage = "010A";
            if (OnGetFuelPressureInit != null)
                OnGetFuelPressureInit(new OBDIIEngineEventArgs(null, obdMessage));
            string data = GetValue(obdMessage);
            int? retVal = (data.Contains("NO DATA")) ? null : (int?)Convert.ToInt32(data.Split(' ')[2].Replace("\r>", string.Empty), 16) * 3;
            if (OnGetFuelPressureDone != null)
                OnGetFuelPressureDone(new OBDIIEngineEventArgs(retVal, obdMessage, data.Contains("NO DATA")));
            return retVal;
        }
    }
}
