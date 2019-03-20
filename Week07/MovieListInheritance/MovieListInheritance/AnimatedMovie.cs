using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MovieList
{
    class AnimatedMovie : Movie
    {
        public string AnimationStudio { get; set; }
        public string AnimationType { get; set; }

        public AnimatedMovie(string title, int releaseYear, string animationStudio, string animationType)
        {
            this.Title = title;
            this.ReleaseYear = releaseYear;
            this.AnimationStudio = animationStudio;
            this.AnimationType = animationType;
        }
        public override void ShowDetails()
        {
            string infoString = "Title: " + this.Title;
            infoString += "\nRelease Year: " + this.ReleaseYear;
            MessageBox.Show(infoString);
        }
    }
}
