using System;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// <para>Текстовая заметка пользователя.</para>
    /// <para>Хранит информацию о названии, категории, тексте, времени создания и времени 
    /// последнего изменения заметки.</para>
    /// <para>Реализует интерфейс <see cref="ICloneable"/>.</para>
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// <para>Название заметки.</para>
        /// <para>Ограничено 50 символами. Значение по умолчанию - "Без названия".</para>
        /// </summary>
        private string _title;

        /// <summary>
        /// Категория заметки.
        /// </summary>
        private NoteCategory _category;

        /// <summary>
        /// Текст заметки.
        /// </summary>
        private string _text;

        /// <summary>
        /// Возвращает и задает название заметки.
        /// </summary>
        /// <exception cref="ArgumentException">Возникает, если название заметки содержит более 
        /// 50 символов.</exception>
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                // Если название заметки содержит больше 50 символов, то...
                if (value.Length > 50)
                {
                    // ...бросаем исключение, сообщающее, что аргумент, передаваемый свойству,
                    // является недопустимым.
                    throw new ArgumentException("The title of the note should contain no more " +
                        "than 50 characters.");
                }
                else
                {
                    _title = value;
                    ModifyTime();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает категорию заметки.
        /// </summary>
        public NoteCategory Category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
                ModifyTime();
            }
        }

        /// <summary>
        /// Возвращает и задает текст заметки.
        /// </summary>
        public string Text
        {
            get
            {
                return _text;
            }

            set
            {
                _text = value;
                ModifyTime();
            }
        }

        /// <summary>
        /// Возвращает и задает время создания заметки.
        /// </summary>
        public DateTime CreationTime { get; private set; }

        /// <summary>
        /// Возвращает и задает время последнего изменения заметки.
        /// </summary>
        public DateTime ModificationTime { get; private set; }


        public Note(NoteCategory category) :this("Без названия", category, "")
        {

        }

        /// <summary>
        /// Создает экземпляр <see cref="Note"/>.
        /// </summary>
        /// <param name="category"><para>Категория заметки.</para> 
        /// <para>Может принимать одно из следующих значений: "Работа", "Дом", "Здоровье и спорт", 
        /// "Люди", "Документы", "Финансы", "Разное".</param>
        /// <param name="text">Текст заметки.</param>
        /// <param name="title">Название заметки. Ограничено 50 символами.</param>
        public Note(string title = "Без названия", NoteCategory? category = null, string text = "") :
            this(title, category, text, DateTime.Now, DateTime.Now)
        {
            
        }

        /// <summary>
        /// Создает экземпляр <see cref="Note"/>.
        /// </summary>
        /// <param name="title">Название заметки. Ограничено 50 символами.</param>
        /// <param name="category"><para>Категория заметки.</para> 
        /// <para>Может принимать одно из следующих значений: "Работа", "Дом", "Здоровье и спорт", 
        /// "Люди", "Документы", "Финансы",
        /// "Разное".</para></param>
        /// <param name="text">Текст заметки.</param>
        /// <param name="creationTime">Время создания заметки.</param>
        /// <param name="modificationTime">Время последнего изменения заметки.</param>
        [JsonConstructor]
        private Note(string title, NoteCategory? category, string text, DateTime creationTime,
            DateTime modificationTime)
        {
            Title = title;
            Category = category ?? (NoteCategory)Enum.GetValues(typeof(NoteCategory)).GetValue(0);
            Text = text;
            CreationTime = creationTime;
            ModificationTime = modificationTime;
        }

        /// <summary>
        /// Метод, реализующий интерфейс <see cref="ICloneable"/> для создания копии 
        /// объекта <see cref="Note"/>.
        /// </summary>
        /// <returns> Поверхностная копия объекта <see cref="Note"/>.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Метод, возвращающий строковое представление названия заметки.
        /// </summary>
        /// <returns>Строковое представление <see cref="Title"/>.</returns>
        public override string ToString()
        {
            return Title;
        }

        /// <summary>
        /// Метод, изменяющий время последнего изменения заметки при каждом изменении 
        /// названия, категории или текста заметки.
        /// </summary>
        private void ModifyTime()
        {
            ModificationTime = DateTime.Now;
        }
    }
}
