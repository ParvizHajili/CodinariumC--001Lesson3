using AccessModifiers;

namespace Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //assembly
            #region Stcruct
            //Test test = new Test();

            //MyStruct myStruct = new MyStruct();
            #endregion

            #region AccesModifiers
            MyPublicClass myPublicClass = new MyPublicClass();
            //myPublicClass.MyPrivateMethod();

            //InternalProductClass ınternalProductClass = new();
            ProtectedClass protectedClass = new ProtectedClass();
            //protectedClass.MyMethod2();
            //protectedClass.MyMethod3();
            #endregion
        }

        #region Struct
        public interface IProduct
        {

        }
        public class BaseClass : IProduct
        {

        }


        public class Test
        {
            public string Name { get; set; }
            public bool Gender { get; set; }

            public BaseClass BaseClass { get; set; }
        }

        public struct MyStruct
        {
            public int Code { get; set; }
            public string Name { get; set; }
            public bool Value { get; set; }
            public BaseClass BaseClass { get; set; }
        }

        //public struct MyCustomStruct : MyStruct
        //{

        //}
        #endregion

    }
}
