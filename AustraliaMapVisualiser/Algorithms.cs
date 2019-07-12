using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AustraliaMapVisualizer
{
    public class Algorithms
    {
        private readonly Form1 _form1;

        public Algorithms(Form1 form1)
        {
            _form1 = form1;
        }
        public double TourLength(List<City> cities)
        {
            var length = 0.0;

            for (var i = 0; i <= cities.Count - 1; i++)
                length += _form1.MapWithCities.getDistance(cities[i].Name, cities[i + 1].Name);

            return length;
        }
        public async Task<List<City>> GreedyAlgorithm()
        {
            var currentPosition = _form1.RouteStartPosition;
            List<string> possibleNextLocations;
            var finalCityPath = new List<City>
            {
                new City(_form1.RouteStartPosition,
                    _form1.MapWithCities.getPosition(_form1.RouteStartPosition), null)
            };
            var remainingCities = new List<City>(_form1.AllCities);
            var oldMinimum = 0.0;
            await Task.Run(() =>
            {
                while (currentPosition != _form1.RouteEndPosition)
                {
                    var minimum = double.MaxValue;
                    var cityName = "";
                    if (currentPosition == string.Empty) break;
                    possibleNextLocations = _form1.MapWithCities?.getPossibleNextLocations(currentPosition);
                    remainingCities.Remove(remainingCities.Find(city => city.Name.Equals(currentPosition)));
                    foreach (var nextLocation in possibleNextLocations)
                    {
                        if (nextLocation == null) continue;
                        var newDistance = _form1.MapWithCities.getPosition(nextLocation)
                            .distance(_form1.MapWithCities.getPosition(_form1.RouteEndPosition));
                        if (minimum >= newDistance &&
                            remainingCities.Contains(remainingCities.Find(city => city.Name.Equals(nextLocation))))
                        {
                            minimum = newDistance;
                            cityName = nextLocation;
                        }
                    }

                    _form1.TourDistance += oldMinimum - minimum;
                    oldMinimum = minimum;
                    if (cityName != string.Empty)
                        finalCityPath.Add(new City(cityName, _form1.MapWithCities.getPosition(cityName), null));
                    currentPosition = cityName;
                }
            });
            return finalCityPath;
        }

        /*private async Task<List<City>> SimulatedAnnealing()
        {
            await Task.Run(async () =>
            {
                List<City> initialSolution = await GreedyAlgorithm();
            });
            return null;
        }*/
    }
}