using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr intPtr, string text, string caption, uint type);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int SendMessage(IntPtr  hWnd, uint Msg, int wParam, string lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;
        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox(IntPtr.Zero, "Hello, World!", "Caption", 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            int userNumber = Convert.ToInt32(numericUpDown1.Value);
            int rand1;
            int count = 0;
            List<int> alreadyUsed = new List<int>();
            Random rand = new Random();
            rand1 = rand.Next(100);
            while (userNumber != rand1)
            {
                rand1 = rand.Next(100);
                if (!alreadyUsed.Contains(rand1))
                {
                    count++;
                    richTextBox1.Text += Convert.ToString(rand1) + $"-[{count}]\n";
                    alreadyUsed.Add(rand1);
                }
            };
            MessageBox(IntPtr.Zero, $"Attempts to guess: {count} (your num is {userNumber})", "Guessed!", 0);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 1)
                richTextBox1.Clear();
            if (numericUpDown1.Value != 0)
                numericUpDown1.Value = 0;
            panel1.Visible = !panel1.Visible;
        }
        private void button4_Click(object sender, EventArgs e)
        {

            IntPtr ParenthWnd = FindWindow("Notepad", null);
            if (ParenthWnd.Equals(IntPtr.Zero))
            {
                MessageBox(IntPtr.Zero, "Notepad Not Running", "", 0);
                return;
            }
              SendMessage(ParenthWnd, WM_SYSCOMMAND, SC_CLOSE, null);
            MessageBox(IntPtr.Zero, "Notepad closed", "", 0);
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }
    }
}