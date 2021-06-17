using System;
using NUnit.Framework;
using NoteApp.Model;

namespace NoteApp.UnitTests
{
    public class NoteTest
    {
        /// <summary>
        /// Экземпляр <see cref="Note"/>, необходимый для работы тестов.
        /// </summary>
        private Note _note;

        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private readonly DateTime _creationTime = new DateTime(2021, 06, 16, 09, 45, 00);

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private readonly DateTime _modificationTime = new DateTime(2021, 06, 16, 09, 55, 00);

        /// <summary>
        /// Метод, выполняющийся каждый раз перед запуском каждого теста.
        /// <para>Создает экземпляр <see cref="Note"/>.</para>
        /// </summary>
        [SetUp]
        public void InitNote()
        {
            _note = new Note("Название заметки", NoteCategory.HealthAndSport, 
                "Текст заметки", _creationTime, _modificationTime);
        }

        [Test(Description = "Позитивный тест геттера Title")]
        public void Title_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = "Название заметки";

            // Act
            var actual = _note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Title")]
        public void Title_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = _note.Title;

            // Act
            _note.Title = expected;
            var actual = _note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Присвоение пустой строки в качестве названия заметки")]
        public void Title_EmptyValue_SetsDefaultValue()
        {
            // Setup
            var expected = "Без названия";

            // Act
            _note.Title = "";
            var actual = _note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Присвоение неправильного названия заметки более 50 символов")]
        public void Title_TooLongValue_ThrowsArgumentException()
        {
            // Setup
            var wrongTitle = "Слишком длинное название заметки, которое должно вызвать " +
                "исключение";

            // Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    _note.Title = wrongTitle;
                });
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void Category_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = NoteCategory.HealthAndSport;

            // Act
            var actual = _note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void Category_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = _note.Category;

            // Act
            _note.Category = expected;
            var actual = _note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void Text_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = "Текст заметки";

            // Act
            var actual = _note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Text")]
        public void Text_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = _note.Text;

            // Act
            _note.Text = expected;
            var actual = _note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера CreationTime")]
        public void CreationTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = _creationTime;

            // Act
            var actual = _note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера CreationTime")]
        public void CreationTime_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = _note.CreationTime;

            // Act
            _note.CreationTime = expected;
            var actual = _note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера ModificationTime")]
        public void ModificationTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = _modificationTime;

            // Act
            var actual = _note.ModificationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера ModificationTime")]
        public void ModificationTime_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = _note.ModificationTime;

            // Act
            _note.ModificationTime = expected;
            var actual = _note.ModificationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест метода копирования экземпляра заметки")]
        public void Clone_NoteCopy_ReturnsNoteCopy()
        {
            // Act
            var actual = (Note)_note.Clone();

            // Assert
            Assert.AreEqual(_note, actual);
        }
    }
}
