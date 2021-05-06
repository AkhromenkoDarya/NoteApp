using System;
using System.Windows.Forms;
using System.Drawing;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Окно создания/редактирования текстовой заметки пользователя. 
    /// </summary>
    public partial class NoteForm : Form
    {
        /// <summary>
        /// Текстовая заметка пользователя, подлежащая добавлению или редактированию.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Флаг, определяющий, корректны ли введенные пользователем данные текущей заметки.
        /// </summary>
        private bool _hasErrors = false;

        /// <summary>
        /// Цвет, который принимает поле окна <see cref="NoteForm"/> содержащее некорректные данные. 
        /// </summary>
        private Color _errorColor = Color.FromArgb(252, 58, 90);

        /// <summary>
        /// Возвращает и задает текстовую заметку пользователя, подлежащую добавлению или редактированию. 
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }

            set
            {
                _note = value ?? new Note();
                TitleTextBox.Text = _note.Title;
                CategoryComboBox.SelectedItem = _note.Category;
                TextBox.Text = _note.Text;
                CreationTimeDateTimePicker.Value = _note.CreationTime;
                ModificationTimeDateTimePicker.Value = _note.ModificationTime;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="NoteForm"/>.
        /// </summary>
        /// <param name="note"> Текстовая заметка пользователя.</param>
        public NoteForm()
        {
            InitializeComponent();
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Title = TitleTextBox.Text;
                ModificationTimeDateTimePicker.Value = Note.ModificationTime;
                TitleTextBox.BackColor = SystemColors.Window;
                _hasErrors = false;
                TitleToolTip.Active = false;
            }
            catch (ArgumentException exception)
            {
                TitleTextBox.BackColor = _errorColor;
                _hasErrors = true;
                TitleToolTip.Active = true;
                TitleToolTip.SetToolTip(TitleTextBox, exception.Message);
            }
        }

        private void CategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Text = TextBox.Text;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(!_hasErrors)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("You need to correct the following data:\n\n" + 
                    TitleToolTip.GetToolTip(TitleTextBox), "Error List", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
