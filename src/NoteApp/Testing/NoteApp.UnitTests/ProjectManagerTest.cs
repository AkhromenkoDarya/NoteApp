using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using NUnit.Framework;
using NoteApp.Model;

namespace NoteApp.UnitTests
{
    class ProjectManagerTest
    {
        /// <summary>
        /// Расположение сборки, которая содержит код, исполняемый в данный момент.
        /// </summary>
        private static readonly string LocalPath = Assembly.GetExecutingAssembly().Location;

        /// <summary>
        /// Информация о каталогах пути, по которому расположена сборка.
        /// </summary>
        private static readonly string DirectoryInformation = Path.GetDirectoryName(LocalPath);

        /// <summary>
        /// Путь к файлу, содержащему проект <see cref="Project"/> с корректными данными>.
        /// </summary>
        private readonly string _correctProjectFileName = DirectoryInformation +
            @"\TestData\CorrectProject.json";

        /// <summary>
        /// Путь к файлу, содержащему проект <see cref="Project"/> с поврежденными данными>.
        /// </summary>
        private readonly string _corruptedProjectFilename = DirectoryInformation +
            @"\TestData\CorruptedProject.json";

        /// <summary>
        /// Путь к папке, в которой лежит сохраняемый файл проекта <see cref="Project"/>.
        /// </summary>
        private static readonly string OutputDirectoryPath = DirectoryInformation +
            @"\Output";

        /// <summary>
        /// Путь к сохраняемому файлу проекта <see cref="Project"/>.
        /// </summary>
        private readonly string _outputProjectFilename = OutputDirectoryPath +
            @"\SavingProject.json";

        /// <summary>
        /// Путь к файлу проекта <see cref="Project"/> по умолчанию.
        /// </summary>
        private readonly string _defaultPath = Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData) + @"\Akhromenko\NoteApp\NoteApp.notes";

        [Test(Description = "Позитивный тест геттера DefaultPath")]
        public void DefaultPath_CorrectValue_ReturnsSameValue()
        {
            // Setup
            var expected = _defaultPath;

            // Act
            var actual = ProjectManager.DefaultPath;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Позитивный тест сеттера DefaultPath")]
        public void DefaultPath_CorrectValue_SetsValueCorrectly()
        {
            // Setup
            var expected = ProjectManager.DefaultPath;

            // Act
            ProjectManager.DefaultPath = expected;
            var actual = ProjectManager.DefaultPath;

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Сохранение проекта в файл")]
        public void SaveToFile_SaveCorrectProject_ProjectIsSavedCorrectly()
        {
            // Setup
            var savingProject = GetCorrectProject();

            if (Directory.Exists(OutputDirectoryPath))
            {
                Directory.Delete(OutputDirectoryPath, true);
            }

            // Act
            ProjectManager.SaveToFile(savingProject, _outputProjectFilename);

            // Assert
            Assert.IsTrue(Directory.Exists(OutputDirectoryPath), "Папка для хранения " +
                "выходного файла не была создана");
            Assert.IsTrue(File.Exists(_outputProjectFilename), "Файл для сохранения " +
                "данных не был создан");

            var expected = File.ReadAllText(_correctProjectFileName);
            var actual = File.ReadAllText(_outputProjectFilename);

            Assert.AreEqual(expected, actual);
        }

        [Test(Description = "Загрузка правильно сохраненного файла проекта")]
        public void LoadFromFile_LoadCorrectProject_ProjectIsLoadedCorrectly()
        {
            // Setup
            var expectedProject = GetCorrectProject();

            // Act
            var actualProject = ProjectManager.LoadFromFile(_correctProjectFileName);

            // Assert
            Assert.AreEqual(expectedProject.Notes.Count, actualProject.Notes.Count);

            Assert.Multiple(() =>
            {
                for (var i = 0; i < expectedProject.Notes.Count; i++)
                {
                    var expected = expectedProject.Notes[i];
                    var actual = actualProject.Notes[i];

                    Assert.AreEqual(expected, actual);
                }
            });
        }

        [Test(Description = "Попытка загрузки поврежденного проекта из файла")]
        public void LoadFromFile_LoadCorruptedProject_ReturnsEmptyProject()
        {
            // Act
            var actualProject = ProjectManager.LoadFromFile(_corruptedProjectFilename);

            // Assert
            Assert.IsNotNull(actualProject);
            Assert.AreEqual(actualProject.Notes.Count, 0);
        }

        [Test(Description = "Попытка загрузки проекта из несуществующего файла")]
        public void LoadFromFile_LoadNonExistentProject_ReturnsEmptyProject()
        {
            // Act
            var actualProject = ProjectManager.LoadFromFile(@"\TestData\NonExistentProject.json");

            // Assert
            Assert.IsNotNull(actualProject);
            Assert.AreEqual(actualProject.Notes.Count, 0);
        }

        /// <summary>
        /// Метод для создания экземпляра <see cref="Project"/>, содержащего список 
        /// из 3-х заметок.
        /// </summary>
        /// <returns> Экземпляр <see cref="Project"/>.</returns>
        private Project GetCorrectProject()
        {
            var correctProject = new Project();

            correctProject.Notes.AddRange
            (
                new List<Note>
                {
                    new Note("Заметка №1", NoteCategory.Home, "Текст заметки №1",
                        new DateTime(), new DateTime()),
                    new Note("Заметка №2", NoteCategory.Documents, "Текст заметки №2",
                        new DateTime(), new DateTime()),
                    new Note("Заметка №3", NoteCategory.Sundry, "Текст заметки №3",
                        new DateTime(), new DateTime())
                }
            );

            return correctProject;
        }
    }
}
