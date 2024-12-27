
//Question 1:

//What is the primary purpose of an interface in C#?
//a) To provide a way to implement multiple inheritance
//b) To define a blueprint for a class
//c) To declare abstract methods and properties
//d) To create instances of objects

//the answer is b 

////---------------------------------------------------------------------------------------------------------------------

//Question 2:
//Which of the following is NOT a valid access modifier for interface members in C#?
//a) private
//b) protected
//c) internal
//d) public

//  the answer is a

////---------------------------------------------------------------------------------------------------------------------

//Question 3:
//Can an interface contain fields in C#?
//a) Yes
//b) No
//c) Only if they are static
//d) Only if they are readonly

//    the answer is b 

//  //---------------------------------------------------------------------------------------------------------------------

//Question 4:

//In C#, can an interface inherit from another interface?
//a) No, interfaces cannot inherit from each other
//b) Yes, interfaces can inherit from multiple interfaces
//c) Yes, but only if they have the same methods
//d) Only if the interfaces are in the same namespace

//    the answer is b

////---------------------------------------------------------------------------------------------------------------------

//Question 5:
//Which keyword is used to implement an interface in a class in C#?
//a) inherit
//b) use
//c) extends
//d) implements

//    the answer is d

////---------------------------------------------------------------------------------------------------------------------

//Question 6:
//Can an interface contain static methods in C#?
//a) Yes
//b) No
//c) Only if the interface is sealed
//d) Only if the methods are private

//    the answer is a

////---------------------------------------------------------------------------------------------------------------------

//Question 7:

//In C#, can an interface have explicit access modifiers for its members?
//a) Yes, for all members
//b) No, all members are implicitly public
//c) Yes, but only for abstract members
//d) Only if the interface is sealed

//    the answer is b

////---------------------------------------------------------------------------------------------------------------------

//Question 8:
//What is the purpose of an explicit interface implementation in C#?
//a) To hide the interface members from outside access
//b) To provide a clear separation between interface and class members
//c) To allow multiple classes to implement the same interface
//d) To speed up method resolution

//    the answer is b

////---------------------------------------------------------------------------------------------------------------------

//Question 9:

//In C#, can an interface have a constructor?
//a) Yes, but it must be private
//b) No, interfaces cannot have constructors
//c) Yes, but only if the interface is sealed
//d) Only if the constructor is static

//    the answer is b

////---------------------------------------------------------------------------------------------------------------------

//Question 10:

//How can a C# class implement multiple interfaces?
//a) By using the "implements" keyword
//b) By using the "extends" keyword
//c) By separating interface names with commas
//d) A class cannot implement multiple interfaces

//    the answer is c

//    //---------------------------------------------------------------------------------------------------------------------

using System;

namespace InterfaceExample
{
    public interface IShape
    {
        double Area { get; }
        void DisplayShapeInfo();
    }

    public interface ICircle : IShape { }
    public interface IRectangle : IShape { }

    public class Circle : ICircle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {Radius}, Area = {Area:F2}");
        }
    }

    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area => Width * Height;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {Width}, Height = {Height}, Area = {Area:F2}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICircle circle = new Circle(5);
            circle.DisplayShapeInfo();

            IRectangle rectangle = new Rectangle(4, 7);
            rectangle.DisplayShapeInfo();
        }
    }
}
