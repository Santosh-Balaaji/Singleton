using System;

namespace Singleton
{
    public sealed class Program
    {
        public  DateTime Datetime { get; set; }
        private static readonly Lazy<Program> lazy = new Lazy<Program>(() => new Program(DateTime.UtcNow)); 
        private  Program(DateTime datetime)
        {
            Datetime = datetime;
        }

        public static Program Instance {
            get {
                return lazy.Value;
                }
        }

        static void Main(string[] args)
        {

            Console.WriteLine(Program.Instance.Datetime);
        }
    }
}
