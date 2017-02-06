namespace Sides.Objects
{
  public class TriangleVariables
  {
    public string Side1 { get; set; }
    public string Side2 { get; set; }
    public string Side3 { get; set; }

    public string Result() {
      int parsedSide1 = int.Parse(Side1);
      int parsedSide2 = int.Parse(Side2);
      int parsedSide3 = int.Parse(Side3);

      if ((parsedSide1 + parsedSide2) <= parsedSide3 || (parsedSide2 + parsedSide3) <= parsedSide1 || (parsedSide1 + parsedSide3) <= parsedSide2)
      {
        return "Not a triangle";
      }
      else
      {
        if (parsedSide1 == parsedSide2 && parsedSide2 == parsedSide3)
        {
          return "Equilateral";
        }
        else if (parsedSide1 == parsedSide2 || parsedSide2 == parsedSide3 || parsedSide3 == parsedSide1)
        {
          return "Isosceles";
        }
        else
        {
          return "Scalene";
        }
      }
    }
  }
}
