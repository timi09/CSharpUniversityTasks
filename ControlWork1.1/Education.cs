using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1._1
{
    internal class Education
    {
        public EducationLevel Level { get; set; }
        public EducationForm Form { get; set; }
        public int Year { get; set; }
        public bool StateFunded { get; set; } //бюджет

        public Education(EducationLevel level, EducationForm form, int year, bool stateFunded)
        {
            Level = level;
            Form = form;
            Year = year;
            StateFunded = stateFunded;
        }

        public override bool Equals(object? obj)
        {
            if (obj != null && obj is Education)
            {
                Education education2 = obj as Education;

                if (Level == education2.Level && Form == education2.Form && Year == education2.Year && StateFunded == education2.StateFunded)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Степень: {LevelToString(Level)}, форма: {FormToString(Form)}, курс: {Year}";
        }

        private string LevelToString(EducationLevel level) 
        {
            switch (level)
            {
                case EducationLevel.Undergraduate: return "Бакалавриат";
                case EducationLevel.Specialty: return "Специалитет";
                case EducationLevel.Magistracy: return "Магистратура";
                case EducationLevel.Graduate: return "Аспирантура";
                default: return "Бакалавриат";
            }
        }

        private string FormToString(EducationForm form)
        {
            switch (form)
            {
                case EducationForm.FullTime: return "Очная";
                case EducationForm.PartTime: return "Очно-заочная";
                case EducationForm.Extramural: return "Заочная";
                default: return "Очная";
            }
        }
    }

    enum EducationLevel 
    {
        Undergraduate, //бакалавриат
        Specialty, //специалитет 
        Magistracy, //магистратура
        Graduate //аспирантура
    }

    enum EducationForm 
    {
        FullTime, //очная
        PartTime, //очно-заочная
        Extramural  //заочная
    }
}
