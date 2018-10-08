using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
  /// <summary>
  /// Geometry figure class
  /// </summary>
  abstract class Figure
  {
    /// <summary>
    /// Calculating figure area
    /// </summary>
    public virtual double Area() { return 1; }
    /// <summary>
    /// Figure class
    /// </summary>
    string _type;
    public string type
    {
      get { return this._type; }
      protected set { this._type = value; }
    }
    /// <summary>
    /// Override method ToString
    /// </summary>
    public override string ToString()
    {
      return this.type + " area = " + this.Area().ToString();
    }
  }
  /// <summary>
  /// Legacy class Rectangle, basic class - Figure
  /// </summary>
  class Rectangle : Figure, IPrint
  {
    public Rectangle(double w, double h) { this.width = w; this.height = h; this.type = "Rectangle"; }

    protected double _width = 0;
    public double width
    {
      get { return _width; }
      set { _width = value; }
    }

    private double _height = 0;
    public double height
    {
      get { return _height; }
      set { _height = value; }
    }
    /// <summary>
    /// Calculating figure area
    /// </summary>
    /// <returns></returns>
    public override double Area()
    {
      return this.width * this.height;
    }
    /// <summary>
    /// Show general figure parametres
    /// </summary>
    public void Print()
    {
      Console.WriteLine(ToString());
    }
  }
  /// <summary>
  /// Legacy class Square, basic class - Rectangle
  /// </summary>
  class Square : Rectangle, IPrint
  {
    public Square(double a) : base(a, a) { this.type = "Square"; }
    /// <summary>
    /// Show general figure parametres
    /// </summary>
    public void Print()
    {
      Console.WriteLine(ToString());
    }
  }
  /// <summary>
  /// Legacy class Circle, basic class - Figure
  /// </summary>
  class Circle : Figure, IPrint
  {
    public Circle(double r) { this.radius = r; this.type = "Circle"; }

    private double _radius = 0;
    public double radius
    {
      get { return _radius; }
      set { _radius = value; }
    }
    /// <summary>
    /// Calculating figure area
    /// </summary>
    /// <returns></returns>
    public override double Area()
    {
      return this.radius * this.radius * Math.PI;
    }
    /// <summary>
    /// Show general figure parametres
    /// </summary>
    public void Print()
    {
      Console.WriteLine(ToString());
    }
  }

  interface IPrint
  {
    /// <summary>
    /// Show general figure parametres
    /// </summary>
    void Print();
  }

  interface IComparable {
    int CompareTo(object obj);
  }
  class Program
  {
    static void Main(string[] args)
    {
    }
  }
}
