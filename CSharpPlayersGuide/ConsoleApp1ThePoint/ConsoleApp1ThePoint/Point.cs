//Create a Point class to store a point in two dimensions. Each point is 
//represented by an x-coordinate (x), a side-to-side distance from a special central point called the origin,
//and a y-coordinate (y), an up-and-down distance away from the origin.
//Objectives:
//• Define a new Point class with properties for X and Y. 
//• Add a constructor to create a point from a specific x- and y-coordinate.
//• Add a parameterless constructor to create a point at the origin (0, 0).
//• In your main method, create a point at (2, 3) and another at (-4, 0). Display these points on the 
//console window in the format (x, y) to illustrate that the class works.;\

namespace ConsoleApp1ThePoint
{
    public  class Point
    {
        public int CentrePointXCoordinate { get; set; }

        public int CentrePointYCoordiante { get; set; }

        public Point(int x, int y)
        {
            CentrePointXCoordinate = x;
            CentrePointYCoordiante = y;
        }



    }
}
