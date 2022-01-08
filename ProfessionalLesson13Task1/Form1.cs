using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfessionalLesson13Task1
{
    public partial class Form1 : Form
    {
        Func<int, int, int> func = Sum;
        AsyncCallback callback = Callback;
        public Form1()
        {
            InitializeComponent();
        }

        private void End_Btn_Click(object sender, EventArgs e)
        {
            IAsyncResult ar = func.BeginInvoke(1,2,null,null);
            int x = func.EndInvoke(ar);
            MessageBox.Show($"Result is: {x}");
        }

        private void CallBack_Btn_Click(object sender, EventArgs e)
        {
            IAsyncResult ar = func.BeginInvoke(1, 2, Callback, func);
        }

        static int Sum(int a, int b)
        {
            Thread.Sleep(3000);
            return a + b;
        }

        static void Callback(IAsyncResult asyncResult)
        {
            int x = (asyncResult.AsyncState as Func<int, int, int>).EndInvoke(asyncResult);
            MessageBox.Show($"Result is: {x}");
        }

        private void IsComplete_Btn_Click(object sender, EventArgs e)
        {
            IAsyncResult asyncResult = func.BeginInvoke(1,2, null, null);
            while (!asyncResult.IsCompleted)
            {

            }
            MessageBox.Show($"Result is: {func.EndInvoke(asyncResult)}");
        }
    }
}
