using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class FeatereStudenti
    {
        private string _FIO;
        private int _groupName;
        private int _zachetBook;


        public string FIO
        {
            get { return _FIO; }
            set { _FIO = value; }
        }

        public int GroupName { get; }
        public int GradeBookNum { get; }
        public string SNILS { get; }

        public string Info() => $"ФИО: {FIO}, номер группы: {GroupName}, номер зачетной книжки: {GradeBookNum}, СНИЛС: {SNILS}";

        public FeatereStudenti(string fIO, int groupName, int gradeBookNum)
        {
            FIO = fIO;
            GroupName = groupName;
            GradeBookNum = gradeBookNum;
        }
    }
}