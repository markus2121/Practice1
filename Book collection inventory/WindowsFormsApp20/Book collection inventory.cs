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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rlDataSet.отечественная_литература". При необходимости она может быть перемещена или удалена.
            this.отечественная_литератураTableAdapter.Fill(this.rlDataSet.отечественная_литература);

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 af = new Form1();
            this.Close();
            af.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            отечественная_литератураTableAdapter.Update(rlDataSet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 af = new Form2();
            this.Close();
            af.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 main = new Form2();
            if (main != null)
            {
                DataRow nRow = main.rlDataSet.Tables[0].NewRow();

                nRow[0] = textBox1.Text;
                nRow[1] = textBox2.Text;
                nRow[2] = textBox3.Text;
                nRow[3] = textBox4.Text;
                nRow[4] = textBox5.Text;
                nRow[5] = textBox6.Text;
                nRow[6] = textBox7.Text;




                main.rlDataSet.Tables[0].Rows.Add(nRow);
                main.отечественная_литератураTableAdapter.Update(main.rlDataSet.отечественная_литература);
                main.rlDataSet.Tables[0].AcceptChanges();
                main.dataGridView1.Refresh();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox8.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int s = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Неверный формат данных");
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
