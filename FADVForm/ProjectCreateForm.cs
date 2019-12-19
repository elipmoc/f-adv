using System;
using System.Windows.Forms;
using FADVLib.ProjectServices;

namespace FADVForm
{
    public partial class ProjectCreateForm : Form
    {
        public ProjectCreateForm()
        {
            InitializeComponent();
        }

        private void ReferenceFolderButton_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                folderDialog.ShowDialog(this);
                projectPathTextBox.Text = folderDialog.SelectedPath;
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            ProjectInfoRepository.saveProjectInfo(
                projectPathTextBox.Text,
                new ProjectInfo.ProjectInfo(projectNameTextBox.Text)
            );
        }
    }
}
