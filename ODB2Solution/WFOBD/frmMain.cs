using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OBDIIEngineLibrary;

//    http://obdcsharpwrapper.codeplex.com/

namespace WFOBD
{
    public partial class frmMain : Form
    {
        OBDIIEngine eng;
        delegate void PutValueToControlDelegate(OBDIIEngineEventArgs args);

        public frmMain()
        {
            InitializeComponent();
            eng = new OBDIIEngine("COM3");
            eng.OnGetSpeedDone += new OBDIIEngine.Initialized(eng_OnGetSpeedDone);
            eng.OnGetFuelPressureDone += new OBDIIEngine.Initialized(eng_OnGetFuelPressureDone);
            eng.OnGetEngineRpmDone += new OBDIIEngine.Initialized(eng_OnGetEngineRpmDone);
        }

        void eng_OnGetEngineRpmDone(OBDIIEngineEventArgs args)
        {
            if (aGauge3.InvokeRequired)
                Invoke(new PutValueToControlDelegate(eng_OnGetEngineRpmDone), new object[] { args });
            else
            {
                if (args.OBDValue != null)
                {
                    aGauge3.Enabled = true;
                    aGauge3.Value = (float)args.OBDValue;
                }
                else
                    aGauge3.Enabled = false;
            }
        }

        void eng_OnGetFuelPressureDone(OBDIIEngineEventArgs args)
        {
            if (aGauge2.InvokeRequired)
                Invoke(new PutValueToControlDelegate(eng_OnGetFuelPressureDone), new object[] { args });
            else
            {
                if (args.OBDValue != null)
                {
                    aGauge2.Enabled = true;
                    aGauge2.Value = (float)args.OBDValue;
                }
                else
                    aGauge2.Enabled = false;
            }
        }

        void eng_OnGetSpeedDone(OBDIIEngineEventArgs args)
        {
            if (aGauge1.InvokeRequired)
                Invoke(new PutValueToControlDelegate(eng_OnGetSpeedDone), new object[] { args });
            else
            {
                if (args.OBDValue != null)
                {
                    aGauge1.Value = (float)args.OBDValue;
                }
                else
                    aGauge1.Enabled = false;
            }
        }

        System.Threading.Thread td;
        private void Form1_Load(object sender, EventArgs e)
        {
            td = new System.Threading.Thread(LoadData);
            td.Start();
        }

        private void LoadData()
        {
            while (td.IsAlive)
            {
                eng.GetSpeedKmh();
                eng.GetFuelPressure();
                eng.GetEngineRpm();
                System.Threading.Thread.Sleep(20);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (td.IsAlive)
                td.Abort();
            eng.ClosePort();
        }
    }
}
