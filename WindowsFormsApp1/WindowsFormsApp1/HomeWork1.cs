using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class HomeWork1 : Form
    {
        public HomeWork1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string [] caption= {"Фамилия","Имя","Возраст"};
            string[] resume = { "Уважанов", "Елнар", "22" };
            int count = 0;
            for (int i=0;i<caption.Length;i++) {
                MessageBox.Show(resume[i],caption[i],MessageBoxButtons.OK);                
            }
            foreach (string a in resume) {
                count += a.Length;
            }
            MessageBox.Show((count / resume.Length).ToString(), "Среднее число символов на странице",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
