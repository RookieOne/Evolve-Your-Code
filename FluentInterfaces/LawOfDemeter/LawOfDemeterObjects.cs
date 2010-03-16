namespace FluentInterfaces.LawOfDemeter
{
    public class A
    {
        public B ChildB { get; set; }

        public void DoStuffOnChild()
        {
            ChildB.DoStuff();
        }
    }

    public class B
    {
        public void DoStuff()
        {
        }
    }
}