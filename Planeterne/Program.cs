namespace Planeterne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet merkur = new Planet("Merkur", 4879, 1407.6, 0, 0.39, 430);
            Planet earth = new Planet("Earth", 12742, 23.9, 1, 1.00, 15);
            Planet mars = new Planet("Mars", 6779, 24.6, 2, 1.52, -60);
            Planet jupiter = new Planet("Jupiter", 139820, 9.9, 79, 5.20, -108);
            Planet saturn = new Planet("Saturn", 116460, 10.7, 82, 9.58, -139);
            Planet uranus = new Planet("Uranus", 50724, 17.2, 27, 19.18, -197);
            Planet neptun = new Planet("Neptun", 49244, 16.1, 14, 30.07, -201);
            Planet pluto = new Planet("Pluto", 2376, 153.3, 5, 39.48, -229);

            //creating a list "planets" and adding the Planet objects to it
            List<Planet> planets = new List<Planet>();
            planets.Add(merkur);
            planets.Add(earth);
            planets.Add(mars);
            planets.Add(jupiter);
            planets.Add(saturn);
            planets.Add(uranus);
            planets.Add(neptun);
            planets.Add(pluto);


            //Printing the list of planets to the console using a foreach loop
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (Planet planet in planets)
            {
               
                Console.WriteLine(planet + "\n");
            }
            Console.ResetColor();
        
            //instantialising new planet "venus" and inserting it at index 1 of the List "planets".
            Planet venus = new Planet("Venus", 12104, 5832.5, 0, 0.72, 462);
            planets.Insert(1, venus);

            Console.WriteLine("venus index: " + planets.IndexOf(venus)); //printing indexes of the first 3 planets to check that venus is inserted correctly
            Console.WriteLine("merkur index: " + planets.IndexOf(merkur));
            Console.WriteLine("earth index: " + planets.IndexOf(earth));

            //removing pluto
            foreach (Planet planet in planets)
            {
                if (planet.Equals(pluto))
                {
                    planets.Remove(planet);
                    break;
                }
            }

            //checking if Planet with name="pluto" exists in the list "planets"
            Console.WriteLine("Pluto is in the list: " + planets.Exists(x => x.Name == "Pluto"));

            
            //adding pluto again
            planets.Insert(8, pluto);
            Console.WriteLine("Pluto is back in the list: " + planets.Exists(x => x.Name == "Pluto"));  //checking that pluto is back in the list


          
            //counting items in list "planets" 
            Console.WriteLine(planets.Count);


            //Creating a new list, planetSubZero, and using LINQ to add items from the list "planets" with subzero temperatures
            List<Planet> planetsSubZero = new List<Planet>();
            planetsSubZero.AddRange(planets.Where(p => p.SurfaceTemp < 0)); //adding planets using LINQ

            List<Planet> psubZero = new List<Planet>(); 
            foreach(Planet p in planets)                                    //adding planets using foreach
            {
                if (p.SurfaceTemp < 0)
                {
                    psubZero.Add(p);
                }
            }
            
            foreach(Planet p in psubZero)                                  //printing the list of subzero planets
            {           
                Console.WriteLine(p + "\n");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;  //printing the new list with the selected planets in it
            foreach (Planet planet in planetsSubZero)
            {
                Console.WriteLine(planet + "\n");
            }
            Console.ResetColor();

            //Creating a new list "planeets10000to50000dm" and using linQ to add items from "planets" with diameters between 10- and 50.000
            List<Planet> planets10000to50000dm = new List<Planet>();
            planets10000to50000dm.AddRange(planets.Where(p => p.Diameter > 10000 && p.Diameter < 50000));

            Console.ForegroundColor = ConsoleColor.Red;  //printing the new list with selected planets in it
            foreach (Planet planet in planets10000to50000dm)
            {
                Console.WriteLine(planet + "\n");
            }
            Console.ResetColor();

            //clearing the list and checking that its empty by counting the items.
            planets10000to50000dm.Clear();
            Console.WriteLine("number of planets in the list planets10000to50000: "+planets10000to50000dm.Count);
        }
    }
}
