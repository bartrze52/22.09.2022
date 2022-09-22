namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox2.Text.Length == 0 && textBox3.Text.Length == 0)
            { MessageBox.Show("Nie podano wszystkich danych."); }
            else if ( textBox3.Text.Length == 0)
            { MessageBox.Show("Nie podano wszystkich danych."); }
            else if (textBox2.Text.Length == 0 )
            { MessageBox.Show("Nie podano wszystkich danych."); }
            else 
            { MessageBox.Show("Podane imie: " +textBox3.Text + ", nazwisko: " + textBox2.Text + ", data urodznia: " + dateTimePicker1.Text); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}