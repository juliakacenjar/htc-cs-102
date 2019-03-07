
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace InheritanceIntro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Bark_Button_Click(object sender, RoutedEventArgs e)
        {
            Dog dog = new Dog();
            dog.Bark();
        }

        private void SayName_Button_Click(object sender, RoutedEventArgs e)
        {
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            dogs.Add(dog1);
            dogs.Add(dog2);

            // Loop through the list and call a method on the objects
            foreach (Dog d in dogs)
            {
                d.SayName();
            }
            Duck duck1 = new Duck(25, "Harry");
            Duck duck2 = new Duck(45, "Henrietta");
            List<Duck> ducks = new List<Duck>();
            ducks.Add(duck1);
            ducks.Add(duck2);

            foreach (Duck duck in ducks)
            {
                duck.SayName();
            }
            Frog frog1 = new Frog(2, "Bob", "Not Poisonous");
            Frog frog2 = new Frog(4, "Robert", "Poisonous");
            List<Frog> frogs = new List<Frog>();
            frogs.Add(frog1);
            frogs.Add(frog2);

            foreach (Frog frog in frogs)
            {
                frog.SayName();
            }
            WoollyBear woollybear1 = new InheritanceIntro.WoollyBear(1, "oof", "brown");
            WoollyBear woollybear2 = new InheritanceIntro.WoollyBear(10, "yeet", "white");
            List<WoollyBear> woollybears = new List<WoollyBear>();
            woollybears.Add(woollybear1);
            woollybears.Add(woollybear2);

            foreach ( WoollyBear woollybear in woollybears)
            {
                woollybear.SayName();
            }
        }


        private void Quack_Button_Click(object sender, RoutedEventArgs e)
        {
            Duck duck = new Duck();
            duck.Quack();

          
        }

        private void Ribbit_Button_Click(object sender, RoutedEventArgs e)
        {
            Frog frog = new InheritanceIntro.Frog();
            frog.Ribbit();
        }

        private void silence_Button_Click(object sender, RoutedEventArgs e)
        {
            WoollyBear woollybear = new InheritanceIntro.WoollyBear();
            woollybear.silence();
        }
    }
}
