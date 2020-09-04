/*  Author: Reily Stanford
 *  Date: 09/04/2020
 *  File: ShapeFactory.cs
 *  Description: This file houses the ShapeFactory class and ShapeType enum. The ShapeFactory class
 *      has a public function getShape that returns a Shape corresponding to the number given the parameters
 */

using System;
using System.Collections.Specialized;

namespace ShapeFactory
{
    class ShapeFactory
    {
        public GeometricShape getShape(ShapeType type)
        {
            GeometricShape returnShape;
            switch(type){
                case (ShapeType)0:
                    return returnShape = new Line();
                case (ShapeType)1:
                    return returnShape = new Circle();
                case (ShapeType)2:
                    return returnShape = new Rectangle();
                case (ShapeType)3:
                    return null;
                default:
                    return null;
            }
        }
    }

    enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE
    }
}
