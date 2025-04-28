using System.Diagnostics;

namespace rename_file
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using var ofd = new OpenFileDialog { Multiselect = false };
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    txtFileSource.Text = ofd.FileName;
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while opening the file.", ex);
            }
        }

        private async Task<bool> RenameFileAsync(string source, string destination, bool overwritePrompt)
        {
            try
            {
                // Validate source and destination paths
                if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(destination))
                    return ShowError("Source or destination file path is invalid.");

                // Validate source file existence
                if (!File.Exists(source))
                    return ShowError($"Source file not found: {source}");

                // Check for destination file conflict
                if (!overwritePrompt && File.Exists(destination))
                    return ShowError($"Destination file already exists: {destination}");

                // Perform file rename
                File.Move(source, destination);

                // Verify the rename operation
                return File.Exists(destination) || ShowError("File rename operation failed.");
            }
            catch (Exception ex)
            {
                return ShowError("An error occurred during the file rename operation.", ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using var sfd = new SaveFileDialog { DefaultExt = Path.GetExtension(txtFileSource.Text) };
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    txtFileDestination.Text = sfd.FileName;
                    txtFileDestination.Tag = sfd.OverwritePrompt;
                }
            }
            catch (Exception ex)
            {
                ShowError("An error occurred while saving the file.", ex);
            }
        }

        private async void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields
                if (string.IsNullOrWhiteSpace(txtFileSource.Text) || string.IsNullOrWhiteSpace(txtFileDestination.Text))
                {
                    ShowError("Please provide both source and destination file paths.");
                    return;
                }

                // Perform the rename operation
                bool overwritePrompt = txtFileDestination.Tag is bool tag && tag;
                if (await RenameFileAsync(txtFileSource.Text, txtFileDestination.Text, overwritePrompt))
                {
                    MessageBox.Show("File renamed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowError("An unexpected error occurred.", ex);
            }
        }

        private bool ShowError(string message, Exception ex = null)
        {
            string errorMessage = ex == null ? message : $"{message}\n\nDetails: {ex.Message}";
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
