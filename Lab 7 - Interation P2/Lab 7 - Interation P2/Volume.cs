// Lab 7 - Task 1 Volume Calculations

//1. Volume of Cube, Cylinder, Sphere
// Inputs: radius, length
// Output: volume
using System;

class Volume
{
    public double cubeVolume(double length)
    {
        return length * length * length;
    }

    public double cylinderVolume(double length, double radius)
    {
        double cylVolume = length * (Math.PI * radius * radius);
        return cylVolume;
    }

    public double sphereVolume(double radius)
    {
        return (4.0 / 3) * Math.PI * (radius * radius * radius);
    }
}