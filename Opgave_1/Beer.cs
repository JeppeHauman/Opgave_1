using System;

namespace Opgave_1
{
    public class Beer
    {
        private string _name;
        private int _price;
        private double _abv;

        public Beer(int id, string name, int price, double abv)
        {
            Id = id;
            Name = name;
            Price = price;
            Abv = abv;
        }

        public Beer()
        {
        }

        public int Id { get; set; }

        /// <summary>
        /// Needs to be minimum 4 chars
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentException();
                _name = value;
            }
        }

        /// <summary>
        /// Price needs to be more than 0
        /// </summary>
        public int Price
        {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        /// <summary>
        /// ABV(Alcohol by volume) should be more than 0 and less than 100
        /// </summary>
        public double Abv
        {
            get => _abv;
            set
            {
                if (value <= 0 || value >= 100) throw new ArgumentOutOfRangeException();
                _abv = value;
            }
        }

        public override string ToString()
        {
            return $"Nr. {Id}, Name {Name}, Price {Price}, Abv {Abv} ";
        }
    }
}
