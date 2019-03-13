﻿
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
            List<Animal> animals = new List<Animal>();
            // Define a new List of dogs
            List<Dog> dogs = new List<Dog>();
            
            // Instantiate some dog objects
            Dog dog1 = new Dog("Muppet", 20, "Rolf");
            Dog dog2 = new Dog("Golden Retriever", 30, "Air Bud");

            // Add the dogs to the list
            animals.Add(dog1);
            animals.Add(dog2);

            // Loop through the list and call a method on the objects
           
            Duck duck1 = new Duck(25, "Harry");
            Duck duck2 = new Duck(45, "Henrietta");
            List<Duck> ducks = new List<Duck>();
            animals.Add(duck1);
            animals.Add(duck2);

            
            Frog frog1 = new Frog(2, "Bob", "Not Poisonous");
            Frog frog2 = new Frog(4, "Robert", "Poisonous");
            List<Frog> frogs = new List<Frog>();
            animals.Add(frog1);
            animals.Add(frog2);

            
            WoollyBear woollybear1 = new InheritanceIntro.WoollyBear(1, "oof", "brown");
            WoollyBear woollybear2 = new InheritanceIntro.WoollyBear(10, "yeet", "white");
            List<WoollyBear> woollybears = new List<WoollyBear>();
            animals.Add(woollybear1);
            animals.Add(woollybear2);

            foreach (Animal animal in animals)
            {
                animal.SayName();
                MessageBox.Show("The height is " + animal.Height);
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
