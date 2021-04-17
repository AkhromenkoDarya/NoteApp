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
        /// Текстовое сообщение, которое описывает ошибки, допущенные пользователем при вводе
        /// данных текущей заметки.
        /// </summary>
        private string _exceptionMessage;

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

            set
            {
                if(value != null)
                {
                    _note = value;
                }
                else
                {
                    _note = new Note();
                }

                // При загрузке окна добавления/редактирования заметки предварительно
                // заполняем все поля данными заметки.
                //
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

            // Для возможности выбора пользователем категории заметки "привязываем" к выпадающему
            // списку перечисление с возможными категориями.
            CategoryComboBox.DataSource = Enum.GetValues(typeof(NoteCategory));
        }

        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Note.Title = TitleTextBox.Text;
                ModificationTimeDateTimePicker.Value = Note.ModificationTime;

                // Восстанавливаем "нормальный" цвет фона текстового поля с названием заметки,
                // если значение поля корректно.
                TitleTextBox.BackColor = SystemColors.Window;

                // Также указываем, что никаких ошибок ввода на данный момент нет.
                _hasErrors = false;
                _exceptionMessage = "";
            }
            catch (ArgumentException exception)
            {
                // В случае некорректной длины названия заметки подсвечиваем текстовое поле
                // с ее названием заметки красным цветом.
                TitleTextBox.BackColor = Color.Salmon;

                // Указываем, что возникла ошибка ввода, и сохраняем сведения об этой ошибке, чтобы
                // в дальнейшем сообщить о них пользователю (с помощью всплывающей подсказки или окна
                // с предупреждением).
                _hasErrors = true;
                _exceptionMessage = exception.Message;
            }
        }

        private void TitleTextBox_MouseEnter(object sender, EventArgs e)
        {
            if(!_hasErrors)
            {
                // В случае, если в текстовое поле с названием заметки введено корректное
                // значение, скрываем всплывающую подсказку.
                //
                TitleToolTip.Active = false;
            }
            else
            {
                // В случае, если в текстовое поле с названием заметки введено некорректное
                // значение, отображаем пользователю всплывающую подсказку с текстом ошибки.
                //  
                TitleToolTip.Active = true;
                TitleToolTip.SetToolTip(TitleTextBox, _exceptionMessage);
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
                // Если какие-либо указанные пользователем данные некорректны, отображаем окно
                // со списком ошибок, которые необходимо исправить, чтобы можно было сохранить
                // изменения для текущей заметки.
                MessageBox.Show("You need to correct the following data:\n\n" + _exceptionMessage,
                    "Error List", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CancelChangesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
