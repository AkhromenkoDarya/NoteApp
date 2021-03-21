using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    /// <summary>
    /// <para>Класс "Менеджер проекта".</para>
    /// <para>Реализует метод для сохранения экземпляра класса <see cref="Project"/> 
    /// в файл и метод загрузки проекта из файла.</para>
    /// </summary>
    public static class ProjectManager
    {
        /// <summary>
        /// Имя файла, в который осуществляется сохранение и из которого производится
        /// загрузка экземпляра класса <see cref="Project"/>.
        /// </summary>
        private const string Filename = "NoteApp.notes";

        /// <summary>
        /// Путь по умолчанию к файлу, имя которого задано закрытой константой 
        /// <see cref="Filename"/>. 
        /// </summary>
        public static string DefaultPath { get; set; } = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
                "NoteApp", Filename);

        /// <summary>
        /// Метод, осуществляющий сохранение экземпляра класса <see cref="Project"/>
        /// в файл, имя которого задано закрытой константой <see cref="Filename"/>.
        /// </summary>
        /// <param name="path"><para>Путь к файлу, в который осуществляется сохранение 
        /// данных.</para> 
        /// <para>Путь по умолчанию указан в <see cref="DefaultPath"/>.</para></param>
        /// <param name="path"></param>
        public static void SaveToFile(Project data, string path)
        {
            if(!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, data);
            }
        }

        /// <summary>
        /// Метод, осуществляющий загрузку данных из файла, имя которого задано закрытой
        /// константой <see cref="Filename"/>, в экземпляр класса <see cref="Project"/>.
        /// </summary>
        /// <param name="path"><para>Путь к файлу, из которого осуществляется загрузка 
        /// данных.</para> 
        /// <para>Путь по умолчанию указан в <see cref="DefaultPath"/>.</para></param>
        /// <returns>Экземпляр класса <see cref="Project"/>.</returns>
        public static Project LoadFromFile(string path)
        {
            Project project = null;

            JsonSerializer serializer = new JsonSerializer();

            if (!File.Exists(path))
            {
                return new Project();
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
            }
            catch(Exception)
            {
                return new Project();
            }

            return project ?? new Project();
        }
    }
}
