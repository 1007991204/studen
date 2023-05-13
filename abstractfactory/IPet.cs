namespace abstractfactory
{
    public interface IPet
    {
        void GetColor();
        void Talk();
    }
    public class YellowPet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("Pet");
        }

        public void Talk()
        {
            Console.WriteLine("Pet Talk");
        }
    }
    public class WhitePet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("Pet");
        }

        public void Talk()
        {
            Console.WriteLine("Pet Talk");
        }
    }
    public class BlackPet : IPet
    {
        public void GetColor()
        {
            Console.WriteLine("Pet");
        }

        public void Talk()
        {
            Console.WriteLine("Pet Talk");
        }
    }
}
