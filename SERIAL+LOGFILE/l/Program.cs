using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.IO;


namespace SerialPortExample1
{

    class SerialPortProgram
    {
        public static void WriteLog(string strLog)
        {
            StreamWriter log;
            FileStream fileStream = null;
            DirectoryInfo logDirInfo = null;
            FileInfo logFileInfo;

            string logFilePath = "C:\\Users\\youdong\\Desktop\\아톰-자바스크립트\\캡스톤\\로그위치기록";
            logFilePath = logFilePath + "Log-" + System.DateTime.Today.ToString("MM-dd-yyyy") + "." + "txt";
            logFileInfo = new FileInfo(logFilePath);
            logDirInfo = new DirectoryInfo(logFileInfo.DirectoryName);
            if (!logDirInfo.Exists) logDirInfo.Create();
            if (!logFileInfo.Exists)
            {
                fileStream = logFileInfo.Create();
            }
            else
            {
                fileStream = new FileStream(logFilePath, FileMode.Append);
            }
            log = new StreamWriter(fileStream);
            log.WriteLine(strLog);
            log.Close();
        }

        // Create the serial port with basic settings
        private SerialPort port = new SerialPort("COM3",
          115200, Parity.None, 8, StopBits.One);

        private string value;

        [STAThread]
        static void Main(string[] args)
        {
            // Instatiate this class         
            new SerialPortProgram();
            
        }

        private SerialPortProgram()
        {
            Console.WriteLine("Incoming Data:");

            // Attach a method to be called when there
            // is data waiting in the port's buffer
            port.DataReceived += new
              SerialDataReceivedEventHandler(port_DataReceived);

            // Begin communications
            port.Open();

            // Enter an application loop to keep this thread alive
            Application.Run();
         
        }

        private void port_DataReceived(object sender,
          SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            WriteLog(indata);
            // Show all the incoming data in the port's buffer
            Console.WriteLine(port.ReadExisting());
        }

       
    }

}
