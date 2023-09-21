using System;
using System.IO;

using LectureDll;

namespace LectureApp.Lesson1
{
    class Unit2
    {
        public void LogResult()
        {
            ConstAndReadOnly CR = new ConstAndReadOnly();
            File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Lesson1_2.txt"), $"Const:{ConstAndReadOnly._Const}-ReadOnly:{CR._ReadOnly}");
            //Console.Write($"Const:{ConstAndReadOnly._Const}-ReadOnly:{CR._ReadOnly}");
        }
    }
}
