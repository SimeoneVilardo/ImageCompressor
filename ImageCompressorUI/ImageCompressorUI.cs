using System;
using System.Windows.Forms;

namespace ImageCompressorUI
{
    public partial class ImageCompressorUI : Form
    {
        public ImageCompressorUI()
        {
            InitializeComponent();
        }

        private void btnBrowsePath_Click(object sender, EventArgs e)
        {
            FileDirectoryDialog dialog = new FileDirectoryDialog();
            dialog.BrowseFor = FileDirectoryDialog.BrowseForTypes.FilesAndDirectories;
            dialog.Title = "Seleziona un file o una directory";
            if (dialog.ShowDialog(this) == DialogResult.OK)
                txtPath.Text = dialog.Selected;
        }
    }
}
