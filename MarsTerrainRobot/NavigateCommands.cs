using MarsTerrainRobot.Enum;
using MarsTerrainRobot.Model;

namespace MarsTerrainRobot;

public class NavigateCommands : Plateau
{
  RobotPosition _robotPosition;
  public NavigateCommands(RobotPosition robotPosition, PlateauSize plateauSize) : base(robotPosition, plateauSize)
  {
    _robotPosition = robotPosition;

    _robotPosition.X = 1;
    _robotPosition.Y = 1;
    _robotPosition.Direction = FacingDirection.North;
  }

  public void Navigate(string Command)
  {
    foreach (char letter in Command)
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
    int currentDirection = Convert.ToInt16(_robotPosition.Direction);

    if (currentDirection + TurnValue < 0)
    {
      _robotPosition.Direction = FacingDirection.West;
    }
    else
    {
      _robotPosition.Direction = (FacingDirection)((currentDirection + TurnValue) % 4);
    }
  }

  public void Move()
  {
    switch (_robotPosition.Direction)
    {
      case FacingDirection.North:
        PlateauSizeChecker("Y", +1);
        break;
      case FacingDirection.East:
        PlateauSizeChecker("X", +1);
        break;
      case FacingDirection.South:
        PlateauSizeChecker("Y", -1);
        break;
      case FacingDirection.West:
        PlateauSizeChecker("X", -1);
        break;
    }
  }
}
