using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_HW_6
{
    class Students
    {
        private List<string> students = new List<string>();

        public void AddStudent(string name)
        {
            students.Add(name);
        }

        public void RemoveStudent(string name)
        {
            students.Remove(name);
        }

        public void SearchStudent(string searchTerm)
        {
            foreach (var student in students)
            {
                if (student.Contains(searchTerm))
                {
                    Console.WriteLine($"Найден студент: {student}");
                }
            }
        }

        public int GetStudentCount()
        {
            return students.Count;
        }
    }
}
