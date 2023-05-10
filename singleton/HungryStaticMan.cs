namespace singleton
{
    public class HungryStaticMan
    {
        private HungryStaticMan() { }

        public static class InnerClass
        {
            public static HungryStaticMan _HungryStaticMan = new HungryStaticMan();
        }

        public static HungryStaticMan GetHungryStaticMan()
        {
            return InnerClass._HungryStaticMan;
        }
    }
}