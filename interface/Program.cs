using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guitar guitar = new Guitar();
            guitar.DoSmth();
            guitar.Play();
            Piano piano = new Piano();
            piano.Play();
        }
    }
    interface IPlayable
    {
        void Play();

    }
    class Guitar : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("трунь-трунь");
        }
        public void DoSmth()
        {
            Console.WriteLine("делать чтото");
        }
    }
    class Piano : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("до-ре-ми");
        }
    }
    class Bayan : IPlayable
    {
        public void Test() {
    }
}
