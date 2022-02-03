namespace SingletonDesignPattern
{
    public class Singleton
    {
        private static Singleton _instance;
        public static Singleton Instance => _instance ?? (_instance = new Singleton());
        private Singleton() { }
        //{
        //get =>  _instance ?? (_instance = new Singleton());
        //{
        //    if (_instance != null)
        //    {
        //        _instance = new Singleton();
        //    }
        //    return _instance;
        //}
        // }

        // Static Constructor version.
        //static Singleton()
        //{
        //    _instance = new Singleton();
        //}

        //public static Singleton GetInstance()
        //{
        //    //if (_instance != null)
        //    //{
        //    //    _instance = new Singleton();
        //    //}
        //    return _instance;
        //}
    }
}