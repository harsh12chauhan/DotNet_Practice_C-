using System;
using System.IO;

namespace FileHandling
{
    internal class FileManager
    {
        // 1. Create directory
        public void CreateDirectory(string directoryPath)
        {
            Directory.CreateDirectory(directoryPath);
            Console.WriteLine("Directory created.");
        }

        // 2. Check if file exists
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath);
        }

        // 3. Write / overwrite file
        public void WriteFile(string filePath, string content)
        {
            File.WriteAllText(filePath, content);
            Console.WriteLine("File written successfully.");
        }

        // 4. Append data to file
        public void AppendFile(string filePath, string content)
        {
            File.AppendAllText(filePath, content);
            Console.WriteLine("Data appended successfully.");
        }

        // 5. Read complete file
        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        // 6. Read file line by line
        public string[] ReadAllLines(string filePath)
        {
            return File.ReadAllLines(filePath);
        }

        // 7. Delete file
        public void DeleteFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                Console.WriteLine("File deleted.");
            }
        }

        // 8. Copy file
        public void CopyFile(string sourcePath, string destinationPath)
        {
            File.Copy(sourcePath, destinationPath);
            Console.WriteLine("File copied.");
        }

        // 9. Move / rename file
        public void MoveFile(string sourcePath, string destinationPath)
        {
            File.Move(sourcePath, destinationPath);
            Console.WriteLine("File moved.");
        }

        // 10. Get file name
        public string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        // 11. Get file extension
        public string GetFileExtension(string filePath)
        {
            return Path.GetExtension(filePath);
        }

        // 12. Combine paths
        public string CombinePath(string directory, string fileName)
        {
            return Path.Combine(directory, fileName);
        }

        // 13. Write using StreamWriter
        public void WriteUsingStreamWriter(
            string filePath,
            string[] lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    writer.WriteLine(line);
                }
            }
        }

        // 14. Read using StreamReader
        public void ReadUsingStreamReader(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;

                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}