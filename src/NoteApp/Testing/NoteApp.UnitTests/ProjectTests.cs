using System;
using System.Collections.Generic;
using NUnit.Framework;
using NoteApp.Model;

namespace NoteApp.UnitTests
{
    [TestFixture]
    class ProjectTests
    {
       /// <summary>
       /// Метод для инициализации тестового экземпляра <see cref="Project"/>.
       /// </summary>
       /// <returns>Тестовый экземпляр <see cref="Project"/>.</returns>
        public Project InitProject()
        {
            var project = new Project();
            project.Notes = GetUnorderedNotes();

            return project;
        }

        [Test(Description = "Позитивный тест геттера Notes")]
        public void Notes_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var project = InitProject();
            var expected = GetUnorderedNotes();

            // Act
            var actual = project.Notes;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера Notes")]
        public void Notes_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var project = InitProject();
            var expected = project.Notes;

            // Act
            project.Notes = expected;
            var actual = project.Notes;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест геттера CurrentNoteIndex")]
        public void CurrentNoteIndex_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var project = InitProject();
            var expected = 0;

            // Act
            var actual = project.CurrentNoteIndex;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера SelectedNote")]
        public void CurrentNoteIndex_CorrectValue_SetsValueCorrectly()
        {
            var project = InitProject();

            var currentNote = new Note("Заметка №2", NoteCategory.Work,
                "Текст заметки №2", new DateTime(2021, 07, 07, 12, 40, 25),
                new DateTime(2021, 08, 08, 22, 05, 38));

            var expected = project.Notes.IndexOf(currentNote);

            // Act
            project.CurrentNoteIndex = expected;
            var actual = project.CurrentNoteIndex;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест сортировки списка заметок по дате изменения")]
        public void SortByModificationTime_ReturnsSortedNotes()
        {
            // Setup
            var project = InitProject();

            var expected = new List<Note>
            {
                new Note("Заметка №4", NoteCategory.Work, "Текст заметки №4",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 10, 10, 18, 00, 53)),
                new Note("Заметка №3", NoteCategory.People, "Текст заметки №3",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 09, 09, 08, 15, 10)),
                new Note("Заметка №2", NoteCategory.Work, "Текст заметки №2",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 08, 08, 22, 05, 38)),
                new Note("Заметка №1", NoteCategory.Finance, "Текст заметки №1",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 07, 07, 15, 20, 00))
            };

            // Act
            var actual = project.SortByModificationTime();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест сортировки по дате изменения списка заметок " +
            "определенной категории ")]
        public void SortByModificationTimeAndCategory_ReturnsSortedNotes()
        {
            // Setup
            var project = InitProject();

            var expected = new List<Note>
            {
                new Note("Заметка №4", NoteCategory.Work, "Текст заметки №4",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 10, 10, 18, 00, 53)),
                new Note("Заметка №2", NoteCategory.Work, "Текст заметки №2",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 08, 08, 22, 05, 38))
            };

            // Act
            var actual = project.SortByModificationTimeAndCategory(NoteCategory.Work);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Тест сортировки списка заметок определенной категории " +
            "по дате изменения при отсутствии заметок указанной категории")]
        public void SortByModificationTimeAndCategory_NoSpecifiedCategory()
        {
            // Setup
            var project = InitProject();
            var expected = new List<Note>();

            // Act
            var actual = project.SortByModificationTimeAndCategory(NoteCategory.Sundry);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Метод, который возвращает список заметок, не упорядоченный по времени 
        /// их последнего изменения.
        /// </summary> 
        /// <returns></returns>
        private List<Note> GetUnorderedNotes()
        {
            return new List<Note>
            {
                new Note("Заметка №1", NoteCategory.Finance, "Текст заметки №1",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 07, 07, 15, 20, 00)),
                new Note("Заметка №2", NoteCategory.Work, "Текст заметки №2",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 08, 08, 22, 05, 38)),
                new Note("Заметка №3", NoteCategory.People, "Текст заметки №3",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 09, 09, 08, 15, 10)),
                new Note("Заметка №4", NoteCategory.Work, "Текст заметки №4",
                    new DateTime(2021, 07, 07, 12, 40, 25),
                    new DateTime(2021, 10, 10, 18, 00, 53))
            };
        }
    }
}
