using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//    http://obdcsharpwrapper.codeplex.com/

namespace OBDIIEngineLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            OBDIIEngine eng = new OBDIIEngine("COM3");

            eng.OnOpenPortInit += new OBDIIEngine.Initializing(eng_OnPortOpening);
            eng.OnOpenPortDone += new OBDIIEngine.Initialized(eng_OnPortOpen);
            //eng.PortStatusAutoCheck = false;  //FOR MANUAL OPENING COM PORT
            //eng.OpenPort();

            eng.OnGetSpeedInit += new OBDIIEngine.Initializing(eng_OnGetSpeedInit);
            eng.OnGetSpeedDone += new OBDIIEngine.Initialized(eng_OnGetSpeedDone);
            eng.GetSpeedKmh();
            //Console.WriteLine("{0} Km/h",eng.GetSpeedKmh().ToString());

            eng.OnGetEngineTempInit += new OBDIIEngine.Initializing(eng_OnGetEngineTempInit);
            eng.OnGetEngineTempDone += new OBDIIEngine.Initialized(eng_OnGetEngineTempDone);
            eng.GetEngineTemp();
            //Console.WriteLine("{0} °C", eng.GetEngineTemp().ToString());

            eng.OnGetEngineRpmInit += new OBDIIEngine.Initializing(eng_OnGetEngineRpmInit);
            eng.OnGetEngineRpmDone += new OBDIIEngine.Initialized(eng_OnGetEngineRpmDone);
            eng.GetEngineRpm();
            //Console.WriteLine("{0} rpm", eng.GetEngineRpm().ToString());

            eng.OnGetThrottlePositionInit += new OBDIIEngine.Initializing(eng_OnGetThrottlePositionInit);
            eng.OnGetThrottlePositionDone += new OBDIIEngine.Initialized(eng_OnGetThrottlePositionDone);
            eng.GetThrottlePosition();
            //Console.WriteLine("{0} %", eng.GetThrottlePosition().ToString());

            eng.OnGetCalculatedEngineLoadValueInit += new OBDIIEngine.Initializing(eng_OnGetCalculatedEngineLoadValueInit);
            eng.OnGetCalculatedEngineLoadValueDone += new OBDIIEngine.Initialized(eng_OnGetCalculatedEngineLoadValueDone);
            eng.GetCalculatedEngineLoadValue();
            //Console.WriteLine("{0} %", eng.GetCalculatedEngineLoadValue().ToString());

            eng.OnGetFuelPressureInit += new OBDIIEngine.Initializing(eng_OnGetFuelPressureInit);
            eng.OnGetFuelPressureDone += new OBDIIEngine.Initialized(eng_OnGetFuelPressureDone);
            eng.GetFuelPressure();
            //Console.WriteLine("{0} kPa", eng.GetFuelPressure().ToString());
            
            eng.OnClosePortInit += new OBDIIEngine.Initializing(eng_OnClosePortInit);
            eng.OnClosePortDone += new OBDIIEngine.Initialized(eng_OnClosePortDone);
            eng.ClosePort();

            Console.ReadLine();
        }

        static void eng_OnGetFuelPressureDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("FUEL PRESSURE IS {0} kPa", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetFuelPressureInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING FUEL PRESSURE");
        }

        static void eng_OnGetEngineTempDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("ENGINE TEMP IS {0} °C", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetEngineTempInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING ENGINE TEMP");
        }

        static void eng_OnGetCalculatedEngineLoadValueDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("ENGINE LOAD IS {0} %", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetCalculatedEngineLoadValueInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING ENGINE LOAD");
        }

        static void eng_OnClosePortDone(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("port closed");
        }

        static void eng_OnClosePortInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("port closing");
        }

        static void eng_OnGetThrottlePositionDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("THROTTLE POSITION IS {0} %", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetThrottlePositionInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING THROTTLE POSITION");
        }

        static void eng_OnGetEngineRpmDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("RPM IS {0} rpm", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetEngineRpmInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING RPM");
        }

        static void eng_OnGetSpeedDone(OBDIIEngineEventArgs args)
        {
            if (!args.OBDResultNoData)
                Console.WriteLine("SPEED IS {0} Km/h", args.OBDValue);
            else
                Console.WriteLine("NO DATA");
        }

        static void eng_OnGetSpeedInit(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("READING SPEED");
        }

        static void eng_OnPortOpen(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("port open");
        }

        static void eng_OnPortOpening(OBDIIEngineEventArgs args)
        {
            Console.WriteLine("port opening");
        }
    }
}