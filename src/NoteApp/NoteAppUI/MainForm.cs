using System;
using System.Windows.Forms;
using System.Collections.Generic;
using NoteApp;

namespace NoteAppUI
{
    /// <summary>
    /// Главное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Константа, которая хранит индекс категории заметки "Все заметки", содержащейся в выпадающем 
        /// списке <see cref="ShowCategoryComboBox"/>.
        /// </summary>
        private const int _allCategoryIndex = 0;

        /// <summary>
        /// Константа, которая хранит название категории заметки "Все заметки", содержащейся в выпадающем 
        /// списке <see cref="ShowCategoryComboBox"/>.
        /// </summary>
        private const string _allCategory = "All";

        /// <summary>
        /// Поле для хранения экземпляра проекта <see cref="Project"/>.
        /// </summary>
        private Project _project;

        /// <summary>
        /// Дополнительный список заметок, который содержит заметки определенной категории, выбранной 
        /// пользователем из выпадающего списка <see cref="ShowCategoryComboBox"/>.
        /// </summary>
        private List<Note> _filteredNotes = new List<Note>();

        /// <summary>
        /// Создает экземпляр <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _project = ProjectManager.LoadFromFile(ProjectManager.DefaultPath);

            // Добавляем в выпадающий список заметок значения из перечисления "Категория заметки", а также
            // добавляем в него новое значение "Все заметки", при выборе которого должен отображаться весь
            // список заметок приложения.
            //
            List<string> categories = new List<string>();
            categories.AddRange(Enum.GetNames(typeof(NoteCategory)));
            categories.Insert(_allCategoryIndex, _allCategory);
            ShowCategoryComboBox.DataSource = categories;
        }

        /// <summary>
        /// Метод для добавления новой заметки в проект.
        /// </summary>
        private void AddNote()
        {
            var selectedCategory = (string)ShowCategoryComboBox.SelectedItem;
            var noteForm = new NoteForm();

            if (selectedCategory != _allCategory)
            {
                var category = (NoteCategory)Enum.Parse(typeof(NoteCategory), selectedCategory);
                noteForm.Note = new Note(category);
            }
            else
            {
                noteForm.Note = new Note();
            }

            noteForm.ShowDialog();

            if (noteForm.DialogResult == DialogResult.OK)
            {
                var addedNote = noteForm.Note;
                _project.Notes.Add(addedNote);
                var filteredNotesIndex = _filteredNotes.IndexOf(addedNote);
                AddNoteToFilteredNotes(addedNote, selectedCategory, filteredNotesIndex);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);

                // Текущей заметкой становится добавленная в проект заметка.
                NotesListBox.SelectedIndex = NotesListBox.Items.Count - 1;
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

            // Сохраняем индексы редактируемой заметки в отсортированном (отображаемом) списке заметок и
            // в списке всех заметок приложения.
            //
            var selectedNote = (Note)NotesListBox.SelectedItem;
            var projectIndex = _project.Notes.IndexOf(selectedNote);

            // При редактировании заметки работаем с ее копией (клоном).
            var noteForm = new NoteForm();
            noteForm.Note = (Note)selectedNote.Clone();
            noteForm.ShowDialog();

            if (noteForm.DialogResult == DialogResult.OK)
            {
                var editedNote = noteForm.Note;
                _project.Notes.RemoveAt(projectIndex);
                _project.Notes.Insert(projectIndex, editedNote);

                var selectedCategory = (string)ShowCategoryComboBox.SelectedItem;
                var filteredNotesIndex = _filteredNotes.IndexOf(selectedNote);
                AddNoteToFilteredNotes(editedNote, selectedCategory, filteredNotesIndex);

                // Текущей заметкой становится отредактированная заметка. 
                NotesListBox.SelectedIndex = _filteredNotes.IndexOf(editedNote);
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

            var selectedNote = (Note)NotesListBox.SelectedItem;

            DialogResult result = MessageBox.Show("Do you really want to remove this note: \"" + 
                selectedNote.Title + "\"?", "Remove Note", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question);

            // Заметка будет удалена из проекта, только если пользователь подтвердит удаление.
            //
            if (result == DialogResult.OK)
            {
                _project.Notes.Remove(selectedNote);
                _filteredNotes.Remove(selectedNote);
                ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
                RefreshDataInNotesListBox();

                if(NotesListBox.Items.Count != 0)
                {
                    if(selectedIndex == NotesListBox.Items.Count)
                    {
                        NotesListBox.SelectedItem = NotesListBox.Items[0];
                    }
                }
            }
        }

        /// <summary>
        /// Метод для добавления новой (или отредактированной) заметки в список заметок, отфильтрованный
        /// по категориям.
        /// </summary>
        /// <param name="addedNote"> Новая (или отредактированная) заметка, которую нужно добавить
        /// в отфильтрованный список.</param>
        /// <param name="selectedCategory"> Текущая категория заметок, согласно которой заметки на 
        /// данный момент отображены в левой части главного окна приложения.</param>
        /// <param name="addedNoteIndex"> Индекс добавляемой заметки в отфильтрованном списке.</param>
        private void AddNoteToFilteredNotes(Note addedNote, string selectedCategory, int addedNoteIndex)
        {
            if (selectedCategory != addedNote.Category.ToString() && selectedCategory != _allCategory)
            {
                ShowCategoryComboBox.SelectedItem = addedNote.Category.ToString();
            }
            else
            {
                if (addedNoteIndex == -1)
                {
                    _filteredNotes.Add(addedNote);
                }
                else
                {
                    _filteredNotes.RemoveAt(addedNoteIndex);
                    _filteredNotes.Insert(addedNoteIndex, addedNote);
                }

                RefreshDataInNotesListBox();
            }
        }

        /// <summary>
        /// Метод, обновляющий источник данных для списка заметок <see cref="NotesListBox"/>.
        /// </summary>
        private void RefreshDataInNotesListBox()
        {
            NotesListBox.DataSource = null;
            NotesListBox.DataSource = _filteredNotes;
        }

        /// <summary>
        /// Метод, вызывающий окно "О программе".
        /// </summary>
        private void ShowAboutForm()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedNote = (Note)NotesListBox.SelectedItem;

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

        private void ShowCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCategory = (string)ShowCategoryComboBox.SelectedItem;
            _filteredNotes.Clear();

            foreach (Note note in _project.Notes)
            {
                if (note.Category.ToString() == selectedCategory || selectedCategory == _allCategory)
                {
                    _filteredNotes.Add(note);
                }
            }

            RefreshDataInNotesListBox();

            if (NotesListBox.Items.Count != 0)
            {
                NotesListBox.SelectedItem = NotesListBox.Items[0];
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                ShowAboutForm();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                RemoveNote();
            }
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectManager.SaveToFile(_project, ProjectManager.DefaultPath);
        }
    }
}
