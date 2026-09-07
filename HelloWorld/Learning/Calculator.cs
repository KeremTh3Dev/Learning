using System;

namespace Learning
{
    //static because accesible without extra work
    public static class Calculator
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }
        public static float Subtract(float a, float b)
        {
            return a - b;
        }
        public static float Multiply(float a, float b)
        {
            return a * b;
        }
        public static float Divide(float a, float b)
        {
            return a / b;
        }
        public static float NewtonForce(float m, float a)
        {
            return m * a;
        }
        public static float NewtonAcceleration(float f, float m)
        {
            return f / m;
        }
    //static because accesible without extra work

    }
}
