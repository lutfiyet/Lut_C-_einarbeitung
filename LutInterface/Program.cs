using System;

namespace LutInterface
{
  public interface IArbeiter
    {
      public  void arbeiten();
    }
    public class Tobias : IArbeiter
    {
    public void arbeiten()
        {
            Console.WriteLine("Produkte Testen ist unser Arbeit");
        }
    }
    
  public class Marco : IArbeiter
    {
        public void arbeiten()
        {
            Console.WriteLine("Service und Support ist unser Arbeit");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IArbeiter[] arbeiters = new IArbeiter[2];
            arbeiters[0] = new Tobias();
            arbeiters[1] = new Marco();
            foreach(IArbeiter a in arbeiters)
            {
                a.arbeiten();
            }

        }
    }
}
