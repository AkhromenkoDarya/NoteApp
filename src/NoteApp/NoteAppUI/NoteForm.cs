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
        /// Создает экземпляр <see cref="NoteForm"/>.
        /// </summary>
        /// <param name="note"> Текстовая заметка пользователя.</param>
        public NoteForm(Note note)
        {
            InitializeComponent();
            Note = note;
        }

        private void NoteForm_Load(object sender, EventArgs e)
        {
            // При загрузке окна добавления/редактирования заметки предварительно заполняем
            // все поля данными заметки.
            //
            TitleTextBox.Text = Note.Title;

            // Для возможности выбора пользователем категории заметки "привязываем" к выпадающему
            // списку перечисление с возможными категориями.
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
            CategoryComboBox.SelectedItem = Note.Category;

            TextBox.Text = Note.Text;
            CreationTimeDateTimePicker.Value = Note.CreationTime;
            ModificationTimeDateTimePicker.Value = Note.ModificationTime;
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Title = TitleTextBox.Text;
                ModificationTimeDateTimePicker.Value = Note.ModificationTime;

                // Восстанавливаем "нормальный" цвет фона текстового поля с названием заметки,
                // если значение поля корректно.
                TitleTextBox.BackColor = Color.Empty;
            }
            catch (ArgumentException)
            {
                // В случае некорректной длины названия заметки подсвечиваем текстовое поле
                // с ее названием заметки красным цветом.
                TitleTextBox.BackColor = Color.Salmon;
            }
        }

        private void TitleTextBox_MouseEnter(object sender, MouseEventArgs e)
        {
            try
            {
                // В случае, если в текстовое поле с названием заметки введено корректное
                // значение, скрываем всплывающую подсказку.
                // 
                Note.Title = TitleTextBox.Text;
                TitleToolTip.Active = false;
            }
            catch (ArgumentException exception)
            {
                // В случае, если в текстовое поле с названием заметки введено некорректное
                // значение, отображаем пользователю всплывающую подсказку с текстом ошибки.
                //  
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
            try
            {
                Note.Title = TitleTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(ArgumentException exception)
            {
                // Если какие-либо указанные пользователем данные некорректны, отображаем окно
                // со списком ошибок, которые необходимо исправить, чтобы можно было сохранить
                // изменения для текущей заметки.
                MessageBox.Show("You need to correct the following data:\n\n" + exception.Message,
                    "Error List", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
