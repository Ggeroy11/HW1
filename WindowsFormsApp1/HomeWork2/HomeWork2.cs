using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class HomeWork2 : Form
    {
        public HomeWork2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Game();

        }
        

        private void Game()
        {
            while (true) {
                
                DialogResult result = MessageBox.Show("Загадайте число от 1 до 2000", "Игра началась", MessageBoxButtons.YesNo);
                Random random = new Random();
                DialogResult tryAgain=0;

                do {
                    DialogResult win = MessageBox.Show($"Ваше число {random.Next(1, 2000)}" + $"?", "", MessageBoxButtons.YesNo);
                    if (win == DialogResult.Yes) {
                        MessageBox.Show("Мы угадали число!!!");
                        tryAgain=MessageBox.Show("Хотите поиграть еще","еще одна попытка",MessageBoxButtons.YesNo);
                        if (tryAgain == DialogResult.No) { 
                            this.Close();
                        }
                    }
                } while (tryAgain != DialogResult.Yes);

            }
            
        }
    }
}
