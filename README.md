# Singleton C#
```c#
public class Singleton
{
      private static Singleton instance;
      Singleton() { }

      public static Singleton Instance
      {
          get
          {
              if (instance == null)
              {
                  instance = new Singleton();
              }
              return instance;
          }
      }
}
```
