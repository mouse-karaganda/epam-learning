using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    /// <summary>
    /// Animal
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Title of animal
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Weight of animal
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Animal eats
        /// </summary>
        public virtual void Eat()
        {
            Console.WriteLine($"{Title} eats food, weight {Weight:F2} kg");
        }

        /// <summary>
        /// Create animal
        /// </summary>
        /// <param name="title">Title of animal</param>
        /// <param name="weight">Weight of animal</param>
        public Animal(string title, double weight)
        {
            this.Title = title;
            this.Weight = weight;
        }
    }

    /// <summary>
    /// Bird
    /// </summary>
    public class Bird : Animal, IBird, IDomestic
    {
        private string Food { get; set; }

        /// <summary>
        /// Bird fly
        /// </summary>
        public void Fly()
        {
            Console.WriteLine(string.Format("{0} flies", Title));
        }

        public void Sound()
        {
            Console.WriteLine(string.Format(@"{0} screams ""kukareku""", Title));
        }

        public void Feed()
        {
            Food = "insect";
        }

        /// <summary>
        /// Bird eats
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine($"{Title} eats {Food}, weight {Weight:F2} kg");
        }


        /// <summary>
        /// Create bird
        /// </summary>
        /// <param name="title">Title of bird</param>
        /// <param name="weight">Weight of bird</param>
        public Bird(string title, double weight)
            : base(title, weight)
        {
            Food = "corn";
        }
    }
}
