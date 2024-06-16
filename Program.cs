﻿namespace MyProject
{
    public interface IMovable
    {
        public void Move();
    }

    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Car is moving");
        }
    }

    public class Bicycle : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Bicycle is moving");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move();

            Bicycle bicycle = new Bicycle();
            bicycle.Move();
        }
    }
}