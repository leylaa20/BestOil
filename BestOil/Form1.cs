namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                textBox1.Text = "0,90";
            if (comboBox1.SelectedIndex == 1)
                textBox1.Text = "1,20";
            if (comboBox1.SelectedIndex == 2)
                textBox1.Text = "1,40";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                tbox_litr.ReadOnly = false;

            else if (radioButton2.Checked == true)
                tbox_amount.ReadOnly = false;
        }

        private void tbox_litr_MouseLeave(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_litr.Text) * float.Parse(textBox1.Text);
            label3.Text = r.ToString();
        }

        private void tbox_amount_MouseLeave(object sender, EventArgs e)
        {
            float r = float.Parse(tbox_amount.Text) / float.Parse(textBox1.Text);
            label3.Text = r.ToString();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) textBox3.ReadOnly = false;
            else { textBox3.ReadOnly = true; textBox3.Text = "0"; }

            if (checkBox2.Checked == true) textBox6.ReadOnly = false;
            else { textBox6.ReadOnly = true; textBox6.Text = "0"; }

            if (checkBox3.Checked == true) textBox8.ReadOnly = false;
            else { textBox8.ReadOnly = true; textBox8.Text = "0"; }

            if (checkBox4.Checked == true) textBox10.ReadOnly = false;
            else { textBox10.ReadOnly = true; textBox10.Text = "0"; }
        }

        private void textBox_MouseLeave(object sender, EventArgs e)
        {
            float r = float.Parse(textBox3.Text) * float.Parse(textBox4.Text);
            float r1 = float.Parse(textBox5.Text) * float.Parse(textBox6.Text);
            float r2 = float.Parse(textBox7.Text) * float.Parse(textBox8.Text);
            float r3 = float.Parse(textBox9.Text) * float.Parse(textBox10.Text);

            label4.Text = (r + r1 + r2 + r3).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float r = float.Parse(label3.Text) + float.Parse(label4.Text);
            label5.Text = r.ToString();
        }

    }
}