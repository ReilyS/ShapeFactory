/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Circle.cs
 *  Description: This class inherits from the GeometricShape interface. The class has a function to allow the object to be drawn.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class Circle : GeometricShape
    {
        public void draw()
        {
            string shapeType = "Circle";
            Console.WriteLine($"{shapeType} is drawn.");
        }
    }
}
