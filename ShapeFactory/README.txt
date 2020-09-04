Name: Reily Stanford
Date: 09/04/2020
Description: This program is a ShapeFactory, it loops through creating every possble shape and printing when the shape is created.
    It uses the ShapeFactory class to do this and that class relies on other classes as well as an enum to create the shapes to give to main.

Needed Files: Program.cs
              ShapeFactory.cs
              GeometricShape.cs
              Line.cs
              Rectangle.cs
              Circle.cs

Design Decisions: In the main in Program.cs, I decided to check if the returned value from ShapeFactory's getShape 
                  was null before trying to print it in order to stay away from errors.
