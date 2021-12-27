using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructVector3DLibrary
{
    public struct Vector3D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public double Length { get; private set; }

        public Vector3D(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;

            Length = Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public void Read()
        {
            Console.WriteLine("Введите координату X: ");
            X = CheckDoubleNumber();
            Console.WriteLine("Введите координату Y: ");
            Y = CheckDoubleNumber();
            Console.WriteLine("Введите координату Z: ");
            Z = CheckDoubleNumber();

            Length = Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public override string ToString()
        {
            return string.Format("Вектор с координатами: X: {0}, Y: {1}, Z: {2}.", X, Y, Z);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector3D))
                return false;

            Vector3D secondVector = (Vector3D)obj;
            return secondVector.X == this.X && secondVector.Y == this.Y && secondVector.Z == this.Z;
        }
        
        public override int GetHashCode()
        {
            double hash = this.X;
            hash = 29 * hash + this.Y;
            return (int)(hash * 29 + this.Z);
        }

        public void Display()
        {
            Console.WriteLine("Структура {0}. Экземпляр структуры: {1}", this.GetType(), this.ToString());
        }

        private double CheckDoubleNumber()
        {
            var x = Console.ReadLine();
            while (true)
            {
                if (double.TryParse(x, out _))
                {
                    return double.Parse(x);
                }
                else
                {
                    Console.WriteLine("Введите корректное число для значения координаты!");
                    x = Console.ReadLine();
                }
            }
        }


        public static Vector3D operator +(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D { X = vector1.X + vector2.X, Y = vector1.Y + vector2.Y, Z = vector1.Z + vector2.Z };
        }

        public static Vector3D operator -(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D { X = vector1.X - vector2.X, Y = vector1.Y - vector2.Y, Z = vector1.Z - vector2.Z };
        }

        public static double operator *(Vector3D vector1, Vector3D vector2)
        {
            return vector1.X * vector2.X + vector1.Y * vector2.Y + vector1.Z + vector2.Z;
        }

        public static Vector3D operator *(Vector3D vector, double num)
        {
            return new Vector3D { X = vector.X * num, Y = vector.Y * num, Z = vector.Z * num };
        }

        public static Vector3D operator ^(Vector3D vector1, Vector3D vector2)
        {
            return new Vector3D
            {
                X = vector2.Y * vector1.Z - vector1.Y * vector2.Z,
                Y = vector2.X * vector1.Z - vector1.X * vector2.Z,
                Z = vector1.X * vector2.Y - vector2.X * vector1.Y
            };
        }
    }
}
