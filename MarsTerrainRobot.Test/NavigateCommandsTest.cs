using MarsTerrainRobot.Enum;
using MarsTerrainRobot.Model;

namespace MarsTerrainRobot.Test;

public class NavigateCommandsTest
{
  #region Navigate and Turn
  [Test]
  public void Navigate_Turn_Left_Equal_West()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    nvgCmd.Navigate("L");

    Assert.That(robotPosition.Direction, Is.EqualTo(FacingDirection.West));
  }

  [Test]
  public void Navigate_Double_Turn_Left_Equal_South()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    nvgCmd.Navigate("LL");

    Assert.That(robotPosition.Direction, Is.EqualTo(FacingDirection.South));
  }

  [Test]
  public void Navigate_Turn_Right_Equal_East()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    nvgCmd.Navigate("R");

    Assert.That(robotPosition.Direction, Is.EqualTo(FacingDirection.East));
  }

  [Test]
  public void Navigate_Double_Turn_Right_Equal_South()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    nvgCmd.Navigate("RR");

    Assert.That(robotPosition.Direction, Is.EqualTo(FacingDirection.South));
  }

  [Test]
  public void Navigate_Right_Left_Turn_Equal_South()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    nvgCmd.Navigate("RL");

    Assert.That(robotPosition.Direction, Is.EqualTo(FacingDirection.North));
  }
  #endregion


  #region Navigate and Move
  [Test]
  public void Navigate_Move_North()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    robotPosition.Direction=FacingDirection.North;
    nvgCmd.Navigate("F");

    Assert.That(robotPosition.Y, Is.EqualTo(2));
  }

  [Test]
  public void Navigate_Move_East()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    robotPosition.Direction = FacingDirection.East;
    nvgCmd.Navigate("F");

    Assert.That(robotPosition.X, Is.EqualTo(2));
  }

  [Test]
  public void Navigate_Move_South()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    robotPosition.Direction = FacingDirection.South;
    robotPosition.Y = 2;
    nvgCmd.Navigate("F");

    Assert.That(robotPosition.Y, Is.EqualTo(1));
  }

  [Test]
  public void Navigate_Move_West()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");

    NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
    robotPosition.X = 2;
    robotPosition.Direction = FacingDirection.West;
    nvgCmd.Navigate("F");

    Assert.That(robotPosition.X, Is.EqualTo(1));
  }
  #endregion
}
