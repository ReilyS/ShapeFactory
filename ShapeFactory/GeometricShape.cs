/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: GeometricShape.cs
 *  Description: This interface creates a function for drawing to be overriden by the different types of shape objects
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeFactory
{
    interface GeometricShape
    {
        public void draw();
    }
}
