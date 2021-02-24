using System;

namespace Relation
{
  public interface IShape
    {
       public  void area(int a , int b);
    }
    public class CalculateArea : IShape
    {

        public void area(int a, int b)
        {
            int ar = a * b;
            Console.WriteLine($"area is : {ar}");
        }
    }
    public class Prop
    {
        IShape _shape;
        public Prop(IShape shape)
        {
            _shape = shape;
        }
        public void action()
        {
            _shape.area(3,4);
        }
    }
    class program
    {
        public static void Main(string[] args)
        {
            var Prop = new Prop(new CalculateArea());
            Prop.action();
        }
    }
   
}
