/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Rectangle.cs
 *  Description: This class inherits from the GeometricShape interface. The class has a function to allow the object to be drawn.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class Rectangle : GeometricShape
    {
        public void draw()
        {
            string shapeType = "Rectangle";
            Console.WriteLine($"{shapeType} is drawn.");
        }
    }
}
