namespace factory
{
    public interface IHuman
    {
        void GetColor();
        void Talk();
    }
    public class YellowMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("Yellow");
        }

        public void Talk()
        {
            Console.WriteLine("Yellow Talk");
        }
    }
    public class WhiteMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("White");
        }

        public void Talk()
        {
            Console.WriteLine("White Talk");
        }
    }
    public class BlackMan : IHuman
    {
        public void GetColor()
        {
            Console.WriteLine("Black");
        }

        public void Talk()
        {
            Console.WriteLine("Black Talk");
        }
    }
}
