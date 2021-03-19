using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public DateTime CreationDateTime
        {
            get
            {
                return _creationDateTime;
            }

            private set
            {
                _creationDateTime = value;
            }
        }

        public DateTime LastChangeDateTime
        {
            get
            {
                return _lastChangeDateTime;
            }

            private set
            {
                _lastChangeDateTime = value;
            }
        }

        public Note(NoteCategory category, string text, DateTime creationDateTime, 
            DateTime lastChangeDateTime, string title = "Без названия")

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
