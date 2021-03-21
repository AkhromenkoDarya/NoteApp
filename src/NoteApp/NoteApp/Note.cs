using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    public class Note : ICloneable
    {
        private string _title;

        private NoteCategory _category;

        private string _text;

        private DateTime _creationDateTime;

        private DateTime _lastChangeDateTime;

        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if(value == null)
                {
                    throw new ArgumentException("Попытка присваивания переменной _title значения null.");
                }

                // Название заметки ограничено 50 символами.
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Название заметки не должно превышать 50 символов.");
                }
                else
                {
                    _title = value;
                    SetLastChangeDateTime();
                }
            }
        }

        public NoteCategory Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
                SetLastChangeDateTime();
            }
        }

        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Попытка присваивания переменной _text значения null.");
                }
                else
                {
                    _text = value;
                    SetLastChangeDateTime();
                }
            }
        }

        public DateTime CreationDateTime { get; private set; }

        public DateTime LastChangeDateTime { get; private set; }

        public Note(NoteCategory category, string text, string title = "Без названия") : this(title,
            category, text, DateTime.Now, DateTime.Now)
        {

        }

        [JsonConstructor]
        private Note(string title, NoteCategory category, string text, DateTime creationDateTime, 
            DateTime lastChangeDateTime)
        {
            Title = title;
            Category = category;
            Text = text;
            CreationDateTime = creationDateTime;
            LastChangeDateTime = lastChangeDateTime;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        private void SetLastChangeDateTime()
        {
            LastChangeDateTime = DateTime.Now;
        }
    }
}
