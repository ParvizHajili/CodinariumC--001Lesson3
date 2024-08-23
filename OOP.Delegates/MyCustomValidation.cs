namespace OOP.Delegates
{
    public class MyCustomValidation
    {
        //Func<>

        //Action<>

        //Predicate<Student> predicate;

        public static List<Student> Students = new List<Student>();

        public delegate bool MyValidationDelegate(Student student);


        public static MyValidationDelegate nameNullValidation = CheckStudentNameNullOrEmpty;
        public static MyValidationDelegate nameLengthValidation = CheckStudentNameLength;
        public static MyValidationDelegate nonNegativeGpaValidation = CheckStudentGpaNonNegativeValue;


        public static void StudentAdd(Student student)
        {
            bool value = MyValidationHandler(student, nameNullValidation, nameLengthValidation, nonNegativeGpaValidation);

            if(value)
            {
                Students.Add(student);
                Console.WriteLine("Data added succesfully");
            }
            else
            {
                Console.WriteLine("Məlumatlar düzgün daxil edilməyib");
            }
        }


        public static bool CheckStudentNameNullOrEmpty(Student student)
        {
            return !string.IsNullOrEmpty(student.Name);
        }

        public static bool CheckStudentGpaNonNegativeValue(Student student)
        {
            if (student.Gpa < 0)
                return false;

            return true;
        }

        public static bool CheckStudentNameLength(Student student)
        {
            return student.Name.Length > 3;
        }


        public static bool MyValidationHandler(Student student, params MyValidationDelegate[] myValidationDelegate)
        {
            foreach (var item in myValidationDelegate)
            {
                if (!item(student))
                    return false;
            }
            return true;
        }

    }
}
