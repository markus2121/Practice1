using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                DialogResult dialog = MessageBox.Show
               (
                 "Вы действительно хотите выйти из приложения?",
                 "Завершение программы",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
                );
                if (dialog == DialogResult.Yes) // Возвращение значения диалогового окна
                {
                    this.Close(); // Закрытие приложения

                }
            }


            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            this.Hide();
            af.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 af = new Form3();
            this.Hide();
            af.Show();
        }
    }
    }

