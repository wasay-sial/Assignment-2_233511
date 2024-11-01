namespace Assignment_2_233511
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am abdul wasay sial", "Demo", MessageBoxButtons.OKCancel);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this ias a demo of label");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string s = string.Empty;

            if (checkBox1.Checked)
            {
                s += "\n windows";
            }
            else if (checkBox2.Checked)
            {
                s += "\n Mac";
            }
            else if (checkBox3.Checked)
            {
                s += "\n linux";
            }
            else
            {
                MessageBox.Show("Error");
            }

            MessageBox.Show("You bought: " + s);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string g;
            if (radioButton1.Checked == true)
            {
                g = "male";
            }
            else
            {
                g = "female";
            }

            MessageBox.Show(g.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            decimal price = numericUpDown1.Value;
            int quantity = (int)numericUpDown2.Value;
            decimal total;
            total = price * quantity;

            MessageBox.Show("The total price is: " + total);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] names = { "Tokyo", "shuibuya", "hiroshima" };
            foreach (string name in names)
            {
                comboBox1.Items.Add(name);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Tokyo")
            {
                comboBox2.Items.Add("Multan");
                comboBox2.Items.Add("Lahore");
            }
            if (comboBox1.SelectedItem.ToString() == "shibuya")
            {
                comboBox2.Items.Add("NagasaKI");
                comboBox2.Items.Add("Umc");
            }
            if (comboBox1.SelectedItem.ToString() == "hiroshima")
            {
                comboBox2.Items.Add("rawalpindi");
                comboBox2.Items.Add("islamabad");
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            OpenFileDialog o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(o.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
