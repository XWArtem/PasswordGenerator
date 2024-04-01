using System.Text;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly char[] charsBase = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        private readonly List<char> AmbiguousChars = new List<char> { 'i', 'l', '0', 'o', 'I', 'L', 'O', '1' };
        Random rand = new Random();
        private bool avoidAmbiguous = false;
        private static string ResultPass = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            int length = (int)passLen.Value;
            //avoidAmbiguous = false;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                char nextChar = GenerateNextChar();
                if (avoidAmbiguous && AmbiguousChars.Contains(nextChar))
                {
                    while (AmbiguousChars.Contains(nextChar)) nextChar = GenerateNextChar();
                }
                sb.Append(nextChar);
            }
            passwordField.Text = sb.ToString();
            ResultPass = sb.ToString();
        }

        private char GenerateNextChar()
        {
            return charsBase[rand.Next(0, charsBase.Length)];
        }

        private void AvoidAmbiguous_CheckedChanged(object sender, EventArgs e)
        {
            avoidAmbiguous = avoidAmbiguousCheckmark.Checked;
        }

        private void CopyPass_Click(object sender, EventArgs e)
        {
            if (ResultPass == string.Empty) return;
            Clipboard.SetText(ResultPass);
        }
    }
}