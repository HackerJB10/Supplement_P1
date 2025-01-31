namespace Supplements;

public class Supplement_P1
{
   /// <summary>
   /// Returns the area of a rectangle.
   /// If the length matches the width, the does length * length instead.
   /// </summary>
   /// <param name="length">length of the rectangle</param> 
   /// <param name="width">width of the rectangle</param> 
   /// <returns> Area of the rectangle</returns>

    public static double AreaOfRectangle(double length, double width){
      
        if(length == width){
         return length * length;

       }else{
         return length * width;
      }

      
 
    }
/// <summary>
    /// Returns the radius of a circle 
    /// </summary>
    /// <param name="radius">Circle radius</param>
    /// <returns>The area of a unit circle witha given radius</returns>

     public static double AreaOfCircle(double radius){
       return double.Pow(radius,2.0) * double.Pi;
    }

/// <summary>
/// Returns the area of a triangele. With a given value
/// </summary>
/// <param name="Tribase">The Triangle's base value</param>
/// <param name="TriHeight">The Triangle's Height Value</param>
/// <returns>Returns the area of a Triangle with a given value</returns>

     public static double AreaOfTriangle(double Tribase, double TriHeight){
       return Tribase * TriHeight / 2;

    }

}
