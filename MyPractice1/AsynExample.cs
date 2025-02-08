namespace MyPractice1
{
public static class AsynExample
{
    public static int Method1()
        {
            Thread.Sleep(500);
            return 10;
        }

        public static int Method2()
        {
            return 20;
        }

        public static int Method3()
        {
            return 30;
        }

}
}