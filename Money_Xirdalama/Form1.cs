using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Money_Xirdalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sifirla()
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sifirla();

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                errorProvider1.SetError(textBox1, "Məbləğ daxil edin");
                return;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
            }

            int mebleg = 0;
            bool ugurlu = int.TryParse(textBox1.Text, out mebleg);

            if (!ugurlu || mebleg <= 0)
            {
                MessageBox.Show("Mənfi və ya sıfır məbləğ xırdalanmaz", "Diqqət", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[] nominal = { 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] say = new int[8];

            for (int i = 0; i < nominal.Length; i++)
            {
                if (mebleg >= nominal[i])
                {
                    say[i] = mebleg / nominal[i];
                    mebleg %= nominal[i];
                }
            }

            if (say[0] > 0)
            {
                label8.Text = say[0].ToString() + " ədəd";
                pictureBox8.Visible = true;
            }

            if (say[1] > 0)
            {
                label7.Text = say[1].ToString() + " ədəd";
                pictureBox7.Visible = true;
            }

            if (say[2] > 0)
            {
                label6.Text = say[2].ToString() + " ədəd";
                pictureBox6.Visible = true;
            }

            if (say[3] > 0)
            {
                label5.Text = say[3].ToString() + " ədəd";
                pictureBox5.Visible = true;
            }

            if (say[4] > 0)
            {
                label4.Text = say[4].ToString() + " ədəd";
                pictureBox4.Visible = true;
            }

            if (say[5] > 0)
            {
                label3.Text = say[5].ToString() + " ədəd";
                pictureBox3.Visible = true;
            }

            if (say[6] > 0)
            {
                label2.Text = say[6].ToString() + " ədəd";
                pictureBox2.Visible = true;
            }

            if (say[7] > 0)
            {
                label1.Text = say[7].ToString() + " ədəd";
                pictureBox1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}