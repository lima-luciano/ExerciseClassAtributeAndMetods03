using System;
using System.Globalization;

namespace ExerciseClassAtributeAndMetods03
{
    class Student
    {
        public string Name;
        public double Note1, Note2, Note3;


        public double FinalNote()
        {
            return Note1 + Note2 + Note3;
        }

        public bool Aproved()
        {
            if (FinalNote() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Remaining()
        {
            if (Aproved())
            {
                return 0.0;
            }
            else
            {
                return 60.00 - FinalNote();
            }
        }
        public override string ToString()
        {
            return "Final Note = " + FinalNote().ToString("F2", CultureInfo.InvariantCulture);
        }

    }    
}
