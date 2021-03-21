using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
    /// <summary>
    /// <para>Класс "Проект".</para>
    /// <para>Содержит список <see cref="List{T}"/> всех заметок, созданных 
    /// в приложении.</para>
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает и задает список всех заметок.
        /// </summary>
        public List<Note> Notes { get; private set; } = new List<Note>();
    } 
}
