using System.Collections.Generic;
using Simple_Graphical_TSP.util;

namespace AustraliaMapVisualizer
{
    public class City
    {
        public string Name { get; }
        public Point2D Point2D { get; }
        public List<string> NextCities { get; }

        public City(string name, Point2D point2D, List<string> nextCities)
        {
            Name = name;
            Point2D = point2D;
            NextCities = nextCities;
        }

        public City()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is City city &&
                   Name == city.Name &&
                   EqualityComparer<Point2D>.Default.Equals(Point2D, city.Point2D) &&
                   EqualityComparer<List<string>>.Default.Equals(NextCities, city.NextCities);
        }

        public override int GetHashCode()
        {
            var hashCode = 589605748;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<Point2D>.Default.GetHashCode(Point2D);
            hashCode = hashCode * -1521134295 + EqualityComparer<List<string>>.Default.GetHashCode(NextCities);
            return hashCode;
        }
    }
}
