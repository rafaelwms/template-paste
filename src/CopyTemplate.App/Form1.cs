namespace CopyTemplate.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtInputFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnOutputFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtOutputFolder.Text = dialog.SelectedPath;
                }
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string originFolder = txtInputFolder.Text;
            string destinationFolder = txtOutputFolder.Text;
            string originTemplate = txtInput.Text;
            string destinationTemplate = txtOutput.Text;

            if (Directory.Exists(originFolder) && Directory.Exists(destinationFolder))
            {
                CopyAndReplace(originFolder, destinationFolder, originTemplate, destinationTemplate);
                MessageBox.Show("Copy and replace completed successfully!");
            }
            else
            {
                MessageBox.Show("Please select valid folders.");
            }
        }

        private void CopyAndReplace(string originFolder, string destinationFolder, string originTemplate, string destinationTemplate)
        {
            foreach (string dirPath in Directory.GetDirectories(originFolder, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(originFolder, destinationFolder).Replace(originTemplate, destinationTemplate));
            }

            foreach (string filePath in Directory.GetFiles(originFolder, "*.*", SearchOption.AllDirectories))
            {
                string newFilePath = filePath.Replace(originFolder, destinationFolder).Replace(originTemplate, destinationTemplate);
                string fileContent = File.ReadAllText(filePath);
                fileContent = fileContent.Replace(originTemplate, destinationTemplate);
                File.WriteAllText(newFilePath, fileContent);
            }
        }
    }
}
