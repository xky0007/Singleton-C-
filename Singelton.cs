public class Singelton1
    {
        private static Singelton1 singelton = null;
        private Singelton1() { }
        public static Singelton1 GetInstance
        {
            get
            {
                if (singelton == null)
                    singelton = new Singelton1();
                return singelton;
            }
        }
    }

    public class Singelton2
    {
        private static readonly Singelton2 singelton= new Singelton2();

        private Singelton2() { }
        public static Singelton2 GetInstance
        {
            get
            {
                return singelton;
            }
        }
    }

    public class Singelton_Eager
    {
        private static readonly Singelton_Eager singelton = new Singelton_Eager();
        private static readonly object obj = new object();
        int counter = 0;
        private Singelton_Eager()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static Singelton_Eager GetInstance
        {
            get
            {
                lock (obj)
                {
                    return singelton;   
                }
            }
        }
    }

    public class Singelton_Lazy
    {
        private static readonly Lazy<Singelton_Lazy> instance = new Lazy<Singelton_Lazy>(()=>new Singelton_Lazy());
        int counter = 0;
        private Singelton_Lazy()
        {
            counter++;
            Console.WriteLine(counter);
        }

        public static Singelton_Lazy GetInstance
        {
            get
            {
                return instance.Value;
            }
        }
    }