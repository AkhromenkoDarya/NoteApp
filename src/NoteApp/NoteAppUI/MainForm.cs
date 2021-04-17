using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле для хранения экземпляра проекта <see cref="Project"/>.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Создает экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);
            RefreshDataInNotesListBox();
        }

        /// <summary>
        /// Метод для добавления новой заметки в проект.
        /// </summary>
        private void AddNote()
        {
            var noteForm = new NoteForm();
            noteForm.Note = new Note();
            noteForm.ShowDialog();

            // Если пользователь подтверждает добавление новой заметки нажатием на кнопку "ОК",
            // необходимо сохранить ее в проект, в противном случае - не сохранять.
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var addedNote = noteForm.Note;
                _project.Notes.Add(addedNote);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                RefreshDataInNotesListBox();

                // Текущей заметкой становится добавленная в проект заметка.
                NotesListBox.SelectedItem = _project.Notes[_project.Notes.Count - 1];
            }
        }

        /// <summary>
        /// Метод для редактирования текущей заметки проекта.
        /// </summary>
        private void EditNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var selectedNote = _project.Notes[selectedIndex];

            // При редактировании заметки работаем с ее копией (клоном).
            var noteForm = new NoteForm();
            noteForm.Note = (Note)selectedNote.Clone();
            noteForm.ShowDialog();

            // Если пользователь подтверждает внесенные изменения нажатием на кнопку "ОК",
            // необходимо применить эти изменения, в противном случае - оставить заметку
            // без изменений.
            if (noteForm.DialogResult == DialogResult.OK)
            {
                var editedNote = noteForm.Note;
                _project.Notes.RemoveAt(selectedIndex);
                _project.Notes.Insert(selectedIndex, editedNote);
                RefreshDataInNotesListBox();
                NotesListBox.SelectedIndex = selectedIndex;
            }
        }

        /// <summary>
        /// Метод для удаления текущей заметки из проекта.
        /// </summary>
        private void RemoveNote()
        {
            var selectedIndex = NotesListBox.SelectedIndex;

            if (selectedIndex == -1)
            {
                return;
            }

            var selectedNote = _project.Notes[selectedIndex];

            DialogResult result = MessageBox.Show("Do you really want to remove this note: \"" +
            selectedNote.Title + "\"?", "Remove Note", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            // Заметка будет удалена из проекта, только если пользователь подтвердит удаление.
            if (result == DialogResult.OK)
            {
                _project.Notes.RemoveAt(selectedIndex);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                RefreshDataInNotesListBox();
            }
        }

        /// <summary>
        /// Метод, обновляющий источник данных для выпадающего списка категорий заметки
        /// <see cref="NotesListBox"/>. 
        /// </summary>
        private void RefreshDataInNotesListBox()
        {
            NotesListBox.DataSource = null;
            NotesListBox.DataSource = _project.Notes;
        }

        /// <summary>
        /// Метод, вызывающий окно "О программе".
        /// </summary>
        private void ShowAboutForm()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
            Application.Exit();
        }

        private void AddNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void EditNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditNote();
        }

        private void RemoveNoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveNote();
        }

        private void AboutF1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAboutForm();
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранную пользователем заметку.
            var selectedNote = (Note)NotesListBox.SelectedItem;

            // Если выбранная заметка не пустая, отображаем все данные этой заметки в правой панели
            // главного окна. В противном случае оставляем незаполненными название, категорию и текст
            // текущей заметки.
            //
            if (selectedNote != null)
            {
                TitleLabel.Text = selectedNote.Title;
                CategoryTextBox.Text = selectedNote.Category.ToString();
                TextBox.Text = selectedNote.Text;
                CreationTimeDateTimePicker.Value = selectedNote.CreationTime;
                ModificationTimeDateTimePicker.Value = selectedNote.ModificationTime;
            }
            else
            {
                TitleLabel.Text = "";
                CategoryTextBox.Text = "";
                TextBox.Text = "";
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                // По нажатию пользователем клавиши "F1" отображаем окно "О программе".
                ShowAboutForm();
            }
            else if(e.KeyCode == Keys.Delete)
            {
                // Если же пользователь нажал клавишу "Delete", отображаем окно с предложением
                // удалить текущую заметку (если она выбрана).
                RemoveNote();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }
    }
}
