using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class MethodStudent
    {
        private string _FIO;
        private int _groupName;
        private int _gradeBookNum;
        private string _SNILS;


        public void SetFIO(string fio) => _FIO = fio;
        public string GetFIO() => _FIO;

        public int GetGroupName() => _groupName;
        public int GetGradeBookNum() => _gradeBookNum;

        public void SetSNILS(string snils) => _SNILS = snils;
        public string GetSNILS() => _SNILS;

        public string Info()
        {
            return $"ФИО: {_FIO}, номер группы: {_groupName}, номер зачетной книжки: {_gradeBookNum}, СНИЛС: {_SNILS}";
        }



        public MethodStudent(string fIO, int groupName, int gradeBookNum)
        {
            _FIO = fIO;
            _groupName = groupName;
            _gradeBookNum = gradeBookNum;
        }
    }
}