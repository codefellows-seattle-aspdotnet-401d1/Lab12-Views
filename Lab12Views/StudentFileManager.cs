using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Lab12Views.ViewModels;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace Lab12Views
{
    public class StudentFileManager
    {
        static string fileName = "student-file.txt";
        string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", fileName);
        MemoryStream stream1 = new MemoryStream();
        DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(Student));

        public String Post(string name, int age)
        {
            Student newStudent = new Student(name, age);
            ser.WriteObject(stream1, newStudent);
            stream1.Position = 0;
            StreamReader sr = new StreamReader(stream1);
            string jStudent = sr.ReadToEnd();

            string path = Path.Combine(Environment.CurrentDirectory, @"StudentData\", "Student-File.txt");
            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(jStudent);
            }

            return $"Saved {name} Age: {age} to database.";
        }

        public List<Student> ViewStudents()
        {
            string[] freddyVSjson;
            using (StreamReader sr = File.OpenText(path))
            {
                //creates an array of json strings from student file
                freddyVSjson = File.ReadAllLines(path);
            }

            List<Student> allStudents = new List<Student>();

            foreach (var s in freddyVSjson)
            {
                allStudents.Add(JsonConvert.DeserializeObject<Student>(s));
            }

            return allStudents;
       
        }
    }
}
