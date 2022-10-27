using System;
using System.Threading;
using System.Windows.Forms;

namespace ThreadHomeres
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();


        }

        private void FrmBasicThread_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            ThreadA.Name = "Thread A Process";
            Thread ThreadB = new Thread(MyThreadClass.Thread1);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();
            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End Of Thread-");
            label1.Text = "-End Of Thread-";
        }
    }
}
