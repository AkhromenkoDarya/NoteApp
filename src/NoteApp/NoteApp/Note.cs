using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// <para>Класс "Заметка".</para>
    /// <para>Хранит информацию о названии, категории, тексте, дате и времени создания,
    /// а также дате и времени последнего изменения текстовой заметки пользователя.</para>
    /// <para>Реализует интерфейс <see cref="ICloneable"/>.</para>
    /// </summary>
    public class Note : ICloneable
    {
        /// <summary>
        /// <para>Название заметки.</para>
        /// <para>Ограничено 50-ю символами. Значение по умолчанию - "Без названия".</para>
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
        /// <exception cref="ArgumentException">Возникает при попытке присвоения 
        /// переменной <see cref="_title"/> значения null или в случае, когда название 
        /// заметки превышает 50 символов.</exception>
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentException("Попытка присваивания переменной _title " +
                        "значения null.");
                }

                // Название заметки ограничено 50 символами.
                else if (value.Length > 50)
                {
                    throw new ArgumentException("Название заметки не должно превышать " +
                        "50 символов.");
                }
                else
                {
                    _title = value;
                    UpdateLastChangeDateTime();
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
                UpdateLastChangeDateTime();
            }
        }

        /// <summary>
        /// Возвращает и задает текст заметки.
        /// </summary>
        /// <exception cref="ArgumentException">Возникает при попытке присвоения 
        /// переменной <see cref="_text"/> значения null.</exception>
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
                    throw new ArgumentException("Попытка присваивания переменной _text " +
                        "значения null.");
                }
                else
                {
                    _text = value;
                    UpdateLastChangeDateTime();
                }
            }
        }

        /// <summary>
        /// Возвращает и задает дату и время создания заметки.
        /// </summary>
        public DateTime CreationDateTime { get; private set; }

        /// <summary>
        /// Возвращает и задает дату и время последнего изменения заметки.
        /// </summary>
        public DateTime LastChangeDateTime { get; private set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="Note"/>.
        /// </summary>
        /// <param name="category"><para>Категория заметки.</para> 
        /// <para>Может принимать одно из следующих значений, содержащихся в перечислении 
        /// "Категория заметки":</para> 
        /// <para>"Работа", "Дом", "Здоровье и Спорт", "Люди", "Документы", "Финансы",
        /// "Разное".</para></param>
        /// <param name="text"><para>Текст заметки.</para>  
        /// <para>Не может иметь значение null.</para></param>
        /// <param name="title"><para>Название заметки.</para> 
        /// <para>Не может иметь значение null или превышать 50 символов.</para></param>
        public Note(NoteCategory category, string text, string title = "Без названия") : 
            this(title, category, text, DateTime.Now, DateTime.Now)
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Note"/>.
        /// </summary>
        /// <param name="title"><para>Название заметки.</para> 
        /// <para>Не может иметь значение null или превышать 50 символов.</para></param>
        /// <param name="category"><para>Категория заметки.</para> 
        /// <para>Может принимать одно из следующих значений, содержащихся в перечислении 
        /// "Категория заметки":</para> 
        /// <para>"Работа", "Дом", "Здоровье и Спорт", "Люди", "Документы", "Финансы",
        /// "Разное".</para></param>
        /// <param name="text"><para>Текст заметки.</para>  
        /// <para>Не может иметь значение null.</para></param>
        /// <param name="creationDateTime">Дата и время создания заметки.</param>
        /// <param name="lastChangeDateTime">Дата и время последнего изменения заметки.</param>
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

        /// <summary>
        /// Метод, реализующий интерфейс <see cref="ICloneable"/> для создания копии 
        /// экземпляра класса <see cref="Note"/>.
        /// </summary>
        /// <returns> Поверхностная копия экземпляра класса <see cref="Note"/>.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// Метод, обновляющий дату и время последнего изменения заметки при каждом 
        /// изменении названия, категории или текста заметки.
        /// </summary>
        private void UpdateLastChangeDateTime()
        {
            LastChangeDateTime = DateTime.Now;
        }
    }
}
