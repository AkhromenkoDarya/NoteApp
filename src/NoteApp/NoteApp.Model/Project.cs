using System.Collections.Generic;
using System.Linq;

namespace NoteApp.Model
{
    /// <summary>
    /// <para>Проект.</para>
    /// <para>Содержит список всех заметок, созданных в приложении.</para>
    /// <para>Для хранения заметок использует список <see cref="List{T}"/>, принимающий
    /// в качестве аргумента <see cref="Note"/>.</para>
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает и задает список всех заметок.
        /// </summary>
        public List<Note> Notes { get; set; } = new List<Note>();

        /// <summary>
        /// Возвращает и задает индекс текущей заметки в NotesListBox.
        /// </summary>
        public int CurrentNoteIndex { get; set; }

        /// <summary>
        /// Метод для сортировки списка заметок по времени последнего изменения.
        /// </summary>
        /// <returns></returns>
        public List<Note> SortByModificationTime()
        {
            var sortedNotes =
                Notes.OrderByDescending(note => note.ModificationTime).ToList();

            return sortedNotes;
        }

        /// <summary>
        /// Метод для сортировки списка заметок определенной категории по времени 
        /// последнего изменения.
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public List<Note> SortByModificationTimeAndCategory(NoteCategory category)
        {
            var sortedNotesCategory =
                Notes.Where(note => note.Category == category).ToList();
            var sortedNotes =
                sortedNotesCategory.OrderByDescending(note => note.ModificationTime).ToList();

            return sortedNotes;
        }
    }
}
