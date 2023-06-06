﻿//create a Color class to represent a color. The pedestal includes an 
//etching of this diagram that illustrates its potential usage:
//The color consists of three parts or channels: red, green, and blue, which indicate how much those 
//channels are lit up. Each channel can be from 0 to 255. 0 means completely off; 255 means completely 
//on.
//The pedestal also includes some color names, with a set of numbers indicating their specific values for 
//each channel. These are commonly used colors: White(255, 255, 255), Black(0, 0, 0), Red(255, 0, 0), 
//Orange(255, 165, 0), Yellow(255, 255, 0), Green(0, 128, 0), Blue(0, 0, 255), Purple(128, 0, 128).
//Objectives:
//• Define a new Color class with properties for its red, green, and blue channels.
//• Add appropriate constructors that you feel make sense for creating new Color objects.
//• Create static properties to define the eight commonly used colors for easy access.
//• In your main method, make two Color-typed variables. Use a constructor to create a color instance 
//and use a static property for the other. Display each of their red, green, and blue channel values.
using ConsoleApp1TheColour;

Colour userColour1 = new Colour(233, 234, 235);
Colour userColour2 = Colour.White;


Console.WriteLine($"R={userColour1.Red}, G={userColour1.Green}, B={userColour1.Blue}");
Console.WriteLine($"R={userColour2.Red}, G={userColour2.Green}, B={userColour2.Blue}");





Colour colour = new Colour(1, 2, 3);
Console.WriteLine($"{colour.Red}, {colour.Green}, {colour.Blue}");