using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InheritanceIntro
{
    class WoollyBear : Animal
    {

        public string color;

        public void silence()
        {
            MessageBox.Show("...(silence). . .");
        }

        public WoollyBear()
        {

        }
        public WoollyBear(int height, string name, string color)
        {
            Height = height;
            Name = name;

        }
    }
}
