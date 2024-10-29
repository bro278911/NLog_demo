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
            logger.Info($"User Login Success.Operation time¡G123 milliseconds");//¬ö¿ýlogÀÉ

            logger.Error("User Login Error.\n456");
        }
    }
}
