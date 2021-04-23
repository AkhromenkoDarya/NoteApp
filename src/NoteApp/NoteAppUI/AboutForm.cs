using System.Windows.Forms;
using System.Diagnostics;

namespace NoteAppUI
{
    /// <summary>
    /// Окно "О программе".
    /// </summary>
    public partial class AboutForm : Form
    {
        /// <summary>
        /// Создает экземпляр <see cref="AboutForm"/>.
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
        }

        private void EmailLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("mailto:otulissa2012@yandex.ru");
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/AkhromenkoDarya/NoteApp");
        }
    }
}
