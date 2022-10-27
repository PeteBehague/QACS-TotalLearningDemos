namespace WinFormsDemo
{

    public partial class Form1 : Form
    {
        private int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateCount()
        {
            CountLabel.Text = $"Count: {count}";
        }

        private void CountButton_Click(object sender, EventArgs e)
        {
            count++;
            UpdateCount();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateCount();
            UpdateMessage();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateMessage();
        }

        private void ShowMoviesButton_Click(object sender, EventArgs e)
        {
            int YearOfBirth = DateTime.Now.Year - (int)(NudAge.Value);
            Form form = new Form2(YearOfBirth);
            form.ShowDialog();
        }

        private void UpdateMessage()
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                MessageLabel.Text = $"Hello {NameTextBox.Text}, you are {NudAge.Value} years old!";
                ShowMoviesButton.Enabled = true;
            }
            else
            {
                MessageLabel.Text = "";
                ShowMoviesButton.Enabled = false;
            }
        }

        private void NudAge_ValueChanged(object sender, EventArgs e)
        {
            UpdateMessage();
        }
    }
}