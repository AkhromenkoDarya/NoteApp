using System;
using System.Windows.Forms;
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
        /// Возвращает и задает текстовую заметку пользователя, подлежащую добавлению или
        /// редактированию. 
        /// </summary>
        public Note Note
        {
            get
            {
                return _note;
            }

            private set
            {
                _note = value;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="NoteForm"/>.
        /// </summary>
        /// <param name="note"> Текстовая заметка пользователя.</param>
        public NoteForm(Note note)
        {
            InitializeComponent();
            Note = note;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            TitleTextBox.Text = Note.Title;
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));

            // Если пользователь добавляет новую заметку (т.е. если время ее создания совпадает
            // с текущим временем с точностью до секунд), то при загрузке окна не заполняем текущий
            // элемент выпадающего списка с категориями заметки. Иначе, если пользователь редактирует
            // ранее созданную заметку, выбранным элементом списка будет текущая категория этой заметки.
            // 
            if (Note.CreationTime.ToString("ddMMyyyyHHmmss") == DateTime.Now.ToString("ddMMyyyyHHmmss"))
            {
                CategoryComboBox.SelectedIndex = -1;
            }
            else
            {
                CategoryComboBox.SelectedIndex = (int)Note.Category;
            }

            TextBox.Text = Note.Text;
            CreationTimeDateTimePicker.Value = Note.CreationTime;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Title = TitleTextBox.Text;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void CategoryComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Если категория заметки на данный момент не выбрана из списка категорий, в таком
            // случае оставляем категорию заметки без изменений.
            if (CategoryComboBox.SelectedIndex != -1)
            {
                Note.Category = (NoteCategory)CategoryComboBox.SelectedItem;
                ModificationTimeDateTimePicker.Value = Note.ModificationTime;
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Note.Text = TextBox.Text;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
