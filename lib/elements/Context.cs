using System;
using System.Collections.Generic;
using System.Text;
using WeitProject.Lib.Elements;

namespace WeitProject.lib.elements
{
    internal static class Context
    {
        #region Student
        private static List<Student> _students;

        internal static void AddStudent(Student student)
        {
            if (_students != default)
                _students.Add(student);
            else
                _students = new List<Student>() { student };
        }
        internal static List<Student> GetAllStudent()
        {
            if (_students == default)
                _students = new List<Student>();

            return _students;
        }
        #endregion

        #region ClassRoom
        private static List<ClassRoom> _classroom;

        internal static void AddClassRoom(ClassRoom classroom)
        {
            if (_classroom != default)
                _classroom.Add(classroom);
            else
                _classroom = new List<ClassRoom>() { classroom };
        }
        internal static List<ClassRoom> GetAllClassRoom()
        {
            if (_classroom == default)
                _classroom = new List<ClassRoom>();

            return _classroom;
        }
        #endregion
    }
}
