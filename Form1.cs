using CsvHelper;
using System.Globalization;

namespace W2SZ_Flea_Log
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RIN_Click(object sender, EventArgs e)
        {

        }

        private void RIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            var submission = new Submission
            {
                RIN = ID.Text
            };
            using (var stream = new FileStream(Properties.Settings.Default.Log, FileMode.Append))
            using (var writer = new StreamWriter(stream))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecord(submission);
                csv.NextRecord();
            }
            // Clear all input fields after submission
            ID.Text = string.Empty;

            // Submission message
            MessageBox.Show("Submission successful!");
        }
        private void RIN_Leave(object sender, EventArgs e)
        {
            int start = ID.Text.IndexOf('=') + 1;
            int end = ID.Text.LastIndexOf("0?");
            if (start > 0 && end > start)
            {
                string crop = ID.Text.Substring(start, end - start);
                ID.Text = crop;
            }
            else if (ID.Text.Length != 0)
            {
                if (!(ID.Text.StartsWith("66")) && ID.Text.Length != 9)
                {
                    MessageBox.Show("Invalid input: " + ID.Text + "\nWith length of: " + ID.Text.Length);
                }
                else if (ID.Text.StartsWith("66") && ID.Text.Length != 9)
                {
                    MessageBox.Show("Invalid input: " + ID.Text + "\nWith length of: " + ID.Text.Length + "\nRIN is 9 digits long");
                }
                else if (!ID.Text.StartsWith("66") && ID.Text.Length == 9)
                {
                    MessageBox.Show("Invalid input: " + ID.Text + "\nWith length of: " + ID.Text.Length + "\nInvalid RIN: All start with 66");
                }
            }

        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog logData = new SaveFileDialog();
            logData.Filter = "CSV File|*.csv";
            logData.Title = "Create log file";
            logData.FileName = "logData.csv";
            logData.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (logData.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (var writer = new StreamWriter(logData.FileName))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteHeader<Submission>();
                        csv.NextRecord();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating file: " + ex.Message);
                    return;
                }
                MessageBox.Show("Saved to: " + logData.FileName);
                Properties.Settings.Default.Log = logData.FileName;
                Properties.Settings.Default.Save();
                FileLocation.Text = "Log file location: " + Properties.Settings.Default.Log;
            }
        }

        private void FileLocation_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.Log))
            {
                FileLocation.Text = "Log file location: " + Properties.Settings.Default.Log;
            }
        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog logData = new OpenFileDialog();
            logData.Filter = "CSV File|*.csv";
            logData.Title = "Import log file";
            logData.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (logData.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.Log = logData.FileName;
                Properties.Settings.Default.Save();
                FileLocation.Text = "Log file location: " + Properties.Settings.Default.Log;
            }
        }
    }
}
