using MarsTerrainRobot.Model;

namespace MarsTerrainRobot;

public class Plateau
{
  RobotPosition _robotPosition;
  PlateauSize _plateauSize;
  public Plateau(RobotPosition robotPosition, PlateauSize plateauSize)
  {
    _robotPosition = robotPosition;
    _plateauSize = plateauSize;
  }

  public void SetPlateauSize(string PlateauSizeStr)
  {
    var sizeList = PlateauSizeStr.ToLower().Split('x');

    if (sizeList.Length == 2)
    {
      _plateauSize.X = Convert.ToInt32(sizeList[0]);
      _plateauSize.Y = Convert.ToInt32(sizeList[1]);
    }
    else
    {
      throw new InvalidOperationException();
    }
  }

  public void PlateauSizeChecker(string DirectionWay, int Value)
  {
    if (DirectionWay == "X" && (_robotPosition.X + Value <= _plateauSize.X) && (_robotPosition.X + Value >= 1))
    {
      _robotPosition.X += Value;
    }
    else if(DirectionWay == "Y" && (_robotPosition.Y + Value <= _plateauSize.Y) && (_robotPosition.Y + Value >= 1))
    {
      _robotPosition.Y += Value;
    }
  }
}
