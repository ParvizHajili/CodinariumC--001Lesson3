namespace AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             public 
             private 
             internal

             protected internal
             private protected
             */

            //InternalProductClass ınternalProductClass = new();

            ProtectedClass protectedClass = new ProtectedClass();
            protectedClass.MyMethod2();
            //protectedClass.
        }
    }


    public class MyPublicClass
    {
        public void MyPublicMethod()
        {

        }

        private void MyPrivateMethod() 
        {

        }
    }
}
