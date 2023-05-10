namespace singleton
{

    public class SampleLazyClass
    {

        //微软封装的单例
        private SampleLazyClass() { }

        private static readonly Lazy<SampleLazyClass> Lazy = new Lazy<SampleLazyClass>(() => new SampleLazyClass());

        public static SampleLazyClass GetLazyClass()
        {
            return Lazy.Value;
        }
    }
}