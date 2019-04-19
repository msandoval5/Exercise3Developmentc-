using System;
namespace exc3
{
    public class B : A , IA
    {
        public void Display()
        {
            Console.WriteLine("Hello Interface");
        }

    }
    public interface IA
    {
        void Display();
    }

}
