# NLog_demo 使用步驟<br>

1.利用Nuget安裝NLog套件<br>

2.將NLog.config檔案放進..\Nlog_Test\bin\Debug\net8.0-windows 專案.exe檔案目錄中(可使用本專案的檔案)<br>

3.在專案中寫入相關log即可<br>

~~~csharp
using NLog;
using System.Diagnostics;

namespace Nlog_Test
{
    public partial class Form1 : Form
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logger.Info($"User Login Success.Operation time：123 milliseconds");//紀錄log info

            logger.Error("User Login Error.\n456");//紀錄log error
        }
    }
}
~~~

