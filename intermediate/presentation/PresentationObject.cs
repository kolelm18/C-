using System;


namespace Project1
{
    public class PresentationObject
    {
        public int Witdh { get; set; }
        public int Height { get; set; }
        public void Copy()
        {
            Console.WriteLine("Object copied");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object duplicated");
        }
    }
}
