using System.Diagnostics;

namespace COMP1551_coursework
{
    public partial class Form1 : Form
    {
        private ASCIIStringProcessor Encryptor;
        public Form1()
        {
            InitializeComponent();
            Encryptor = new ASCIIStringProcessor();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            string input = StringTBI.Text;
            if (!input.All(char.IsUpper) || input.Contains(" "))
            {
                label3.Text = "Warning: Please enter only capital letters without spaces.";
                StringTBI.Text = "";
                return;
            }
            else
            {
                label3.Text = "...";
            }
            int encryptor = (int)EncNumI.Value;
            string encrypted = Encryptor.LettersEncryptor(input, encryptor);
            string sorted1 = Encryptor.SortString1(encrypted);
            string sorted2 = Encryptor.SortString2(encrypted);

            OutputTB.Text = encrypted;
            SortedTB.Text = sorted1;
            SortedTB2.Text = sorted2;
        }
    }
}
