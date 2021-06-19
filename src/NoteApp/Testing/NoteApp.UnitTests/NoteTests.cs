using System;
using NUnit.Framework;
using NoteApp.Model;

namespace NoteApp.UnitTests
{
    [TestFixture]
    public class NoteTests
    {
        /// <summary>
        /// Время создания заметки.
        /// </summary>
        private readonly DateTime _creationTime = new DateTime(2021, 06, 16, 09, 45, 00);

        /// <summary>
        /// Время последнего изменения заметки.
        /// </summary>
        private readonly DateTime _modificationTime = new DateTime(2021, 06, 16, 09, 55, 00);

        /// <summary>
        /// Метод для инициализации тестового экземпляра <see cref="Note"/>.
        /// </summary>
        /// <returns>Тестовый экземпляр <see cref="Note"/>.</returns>
        public Note InitNote()
        {
            return new Note("Название заметки", NoteCategory.HealthAndSport, 
                "Текст заметки", _creationTime, _modificationTime);
        }

        [Test(Description = "Позитивный тест геттера Title")]
        public void Title_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = InitNote();
            var expected = "Название заметки";

            // Act
            var actual = note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Title")]
        public void Title_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var note = InitNote();
            var expected = note.Title;

            // Act
            note.Title = expected;
            var actual = note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Присвоение пустой строки в качестве названия заметки")]
        public void Title_EmptyValue_SetsDefaultValue()
        {
            // Setup
            var note = InitNote();
            var expected = "Без названия";

            // Act
            note.Title = "";
            var actual = note.Title;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Присвоение неправильного названия заметки более 50 символов")]
        public void Title_TooLongValue_ThrowsArgumentException()
        {
            // Setup
            var note = InitNote();
            var wrongTitle = "Слишком длинное название заметки, которое должно вызвать " +
                "исключение";

            // Assert
            Assert.Throws<ArgumentException>(
                () =>
                {
                    // Act
                    note.Title = wrongTitle;
                });
        }

        [Test(Description = "Позитивный тест геттера Category")]
        public void Category_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = InitNote();
            var expected = NoteCategory.HealthAndSport;

            // Act
            var actual = note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Category")]
        public void Category_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var note = InitNote();
            var expected = note.Category;

            // Act
            note.Category = expected;
            var actual = note.Category;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера Text")]
        public void Text_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = InitNote();
            var expected = "Текст заметки";

            // Act
            var actual = note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Text")]
        public void Text_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var note = InitNote();
            var expected = note.Text;

            // Act
            note.Text = expected;
            var actual = note.Text;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера CreationTime")]
        public void CreationTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = InitNote();
            var expected = _creationTime;

            // Act
            var actual = note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера CreationTime")]
        public void CreationTime_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var note = InitNote();
            var expected = note.CreationTime;

            // Act
            note.CreationTime = expected;
            var actual = note.CreationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера ModificationTime")]
        public void ModificationTime_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var note = InitNote();
            var expected = _modificationTime;

            // Act
            var actual = note.ModificationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера ModificationTime")]
        public void ModificationTime_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var note = InitNote();
            var expected = note.ModificationTime;

            // Act
            note.ModificationTime = expected;
            var actual = note.ModificationTime;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест метода копирования экземпляра заметки")]
        public void Clone_NoteCopy_ReturnsNoteCopy()
        {
            // Act
            var note = InitNote();
            var actual = (Note)note.Clone();

            // Assert
            Assert.AreEqual(note, actual);
        }
    }
}
