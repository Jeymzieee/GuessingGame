using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] words = new[]{"Salamander","Panda","Marathon","Carousel",
                               "Ramses","Fresco","Lighthouse","Mount Everest",
                                "Shakespeare","Penguin","Backpack","Narwhal"};
        int index = 0, score = 0;
        Random random = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            displayWord();
            Guess.Enabled = false;
            Next.Enabled = true;
            Result.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            checkWord();

        }

        private string originalWord;
        public void displayWord()
        {

            int pos1 = random.Next(words[index].Length);
            int pos3 = random.Next(words[index].Length);
            int pos2 = random.Next(words[index].Length);

            originalWord = words[index];
            string word = originalWord;

            word = word.Remove(pos1, 1).Insert(pos1, "_");
            word = word.Remove(pos2, 1).Insert(pos2, "_");
            Words.Text = word;
            UserInput.Text = "";
        }

        public void checkWord()
        {
            string userInput = UserInput.Text;
            if (userInput.Equals(originalWord, StringComparison.OrdinalIgnoreCase))
            {
                Result.ForeColor = Color.Black;
                Result.Text = "Correct";
                Result.BackColor = Color.LightSkyBlue;
                displayWord();
                ListBox.Items.Clear();

            }
            else
            {
                Result.Text = "Try Again";
                Result.BackColor = Color.DarkRed;
                Result.ForeColor = Color.White;
                ListBox.Items.Add(UserInput.Text);
                UserInput.Text = "";
            }

        }

        private void WrongGuess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
