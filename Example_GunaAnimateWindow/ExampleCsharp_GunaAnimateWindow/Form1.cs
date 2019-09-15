using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExampleCsharp_GunaAnimateWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GunaButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_CENTER ;
            f.Show();

        }

        private void GunaButton2_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND;
            f.Show();
        }

        private void GunaButton3_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE ;
            f.Show();
        }

        private void GunaButton4_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE ;
            f.Show();
        }

        private void GunaButton5_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_NEGATIVE ;
            f.Show();
        }

        private void GunaButton6_Click(object sender, EventArgs e)
        {
            Form2 f = new ExampleCsharp_GunaAnimateWindow.Form2();
            f.gunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_VER_POSITIVE;
            f.Show();
        }
    }
}
