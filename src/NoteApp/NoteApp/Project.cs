using System.Collections.Generic;

namespace NoteApp
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
        public List<Note> Notes { get; } = new List<Note>();
    } 
}
