public class Singleton1
    {
        private static Singleton1 singleton = null;
        private Singleton1() { }
        public static Singleton1 GetInstance
        {
            get
            {
                if (singleton == null)
                    singleton = new Singleton1();
                return singleton;
            }
        }
    }

    public class Singleton2
    {
        private static readonly Singleton2 singleton= new Singleton2();

        private Singleton2() { }
        public static Singleton2 GetInstance
        {
            get
            {
                return singleton;
            }
        }
    }

    public class Singleton_Eager
    {
        private static readonly Singleton_Eager singleton = new Singleton_Eager();
        private static readonly object obj = new object();
        int counter = 0;
        private Singleton_Eager()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static Singleton_Eager GetInstance
        {
            get
            {
                lock (obj)
                {
                    return singleton;   
                }
            }
        }
    }

    public class Singleton_Lazy
    {
        private static readonly Lazy<Singleton_Lazy> instance = new Lazy<Singleton_Lazy>(()=>new Singleton_Lazy());
        int counter = 0;
        private Singleton_Lazy()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static Singleton_Lazy GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
    }