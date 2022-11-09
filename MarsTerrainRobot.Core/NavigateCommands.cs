using MarsTerrainRobot.Enum;

namespace MarsTerrainRobot.Core
{
  public class NavigateCommands
  {
    public int X { get; set; }
    public int Y { get; set; }
    public int PlateauXSize { get; set; }
    public int PlateauYSize { get; set; }

    public NavigateCommands()
    {
      X = 1;
      Y = 1;
      Direction = FacingDirection.N;
    }
    public FacingDirection Direction { get; set; }
    public void Navigate(string Navigate)
    {
      foreach (char letter in Navigate)
      {
        switch (char.ToUpper(letter))
        {
          case 'L':
            Turn(-1); break;
          case 'R':
            Turn(+1); break;
          case 'F':
            Move(); break;
          default:
            throw new InvalidOperationException();
        }
      }
    }

    public void Turn(int TurnValue)
    {
      Direction = (FacingDirection)(Convert.ToInt16(Direction + TurnValue) % 4);
    }
    public void Move()
    {
      switch (Direction)
      {
        case FacingDirection.N:
          PlateauSizeChecker("Y", +1);
          break;
        case FacingDirection.E:
          PlateauSizeChecker("X", +1);
          break;
        case FacingDirection.S:
          PlateauSizeChecker("Y", -1);
          break;
        case FacingDirection.W:
          PlateauSizeChecker("X", -1);
          break;
      }
    }
    public void PlateauSizeChecker(string DirectionWay, int Value)
    {

      if (DirectionWay == "Y" && Y != PlateauYSize && Y != 1)
      {
        Y = Y + Value;
      }
      else if (DirectionWay == "X" && X != PlateauXSize && X != 1)
      {
        X = X + Value;
      }
    }
    public void SetPlateauSize(string PlateauSizeStr)
    {
      var sizeList = PlateauSizeStr.ToLower().Split('x');

      if (sizeList.Length==2)
      {
        PlateauXSize = Convert.ToInt32(sizeList[0]);
        PlateauXSize = Convert.ToInt32(sizeList[1]);
      }
      else
      {
        throw new InvalidOperationException();
      }
    }
  }
}
