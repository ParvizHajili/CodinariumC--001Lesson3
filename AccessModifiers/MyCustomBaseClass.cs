namespace AccessModifiers
{
    public class MyCustomBaseClass : ProtectedClass
    {
        public MyCustomBaseClass()
        {
            base.MyMethod2();
            base.MyMethod1();
            base.MyMethod3();
        }
    }
}
