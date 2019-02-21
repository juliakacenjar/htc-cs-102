using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ClassesIntro
{
    public class Dog
    {
        public string Breed;
        public int Height;
        public string Name;

        public Dog(string name, int height, string breed)
        {
            Name = name;
            Height = height;
            Breed = breed;
        }
        public void Bark()
        {
            MessageBox.Show("Woof! Woof!");
        }
        public void SayName()
        {
            MessageBox.Show("Woof, My name is "+ Name);
        }
      
    }
}