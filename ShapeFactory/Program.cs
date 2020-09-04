/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: Program.cs
 *  Description: This file houses the main which loops through every possible shape and prints what type of shape is made.
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    class Program
    {
        public static void Main()
        {
            ShapeFactory shapeCreator = new ShapeFactory();
            for(int i = 0; i < 5; i++)
            {
                if(shapeCreator.getShape((ShapeType)i) != null)
                    shapeCreator.getShape((ShapeType)i).draw();
                else
                {
                    Console.WriteLine("Requested shape not created!");
                }
            }
        }
    }
}
