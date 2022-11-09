using MarsTerrainRobot.Model;

namespace MarsTerrainRobot.Test;

public class PlateauTest
{
  #region Set_Plateau_Size
  [Test]
  public void Set_Plateau_Size()
  {
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(new RobotPosition(), plateauSize);
    plateau.SetPlateauSize("41x42");

    Assert.That(plateauSize.X, Is.EqualTo(41));
    Assert.That(plateauSize.Y, Is.EqualTo(42));
  }
  #endregion

  #region PlateauSizeChecker Direction X Tests
  [Test]
  public void PlateauSizeChecker_Direction_X_Increase()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.X = 1;
    plateau.PlateauSizeChecker("X", +1);

    Assert.That(robotPosition.X, Is.EqualTo(2));
  }

  [Test]
  public void PlateauSizeChecker_Direction_X_Decrease()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.X = 2;
    plateau.PlateauSizeChecker("X", -1);

    Assert.That(robotPosition.X, Is.EqualTo(1));
  }

  [Test]
  public void PlateauSizeChecker_Direction_X_MinLimit()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.X = 1;
    plateau.PlateauSizeChecker("X", -1);

    Assert.That(robotPosition.X, Is.EqualTo(1));
  }

  [Test]
  public void PlateauSizeChecker_Direction_X_MaxLimit()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.X = 5;
    plateau.PlateauSizeChecker("X", +1);

    Assert.That(robotPosition.X, Is.EqualTo(5));
  }
  #endregion

  #region PlateauSizeChecker Direction Y Tests
  [Test]
  public void PlateauSizeChecker_Direction_Y_Increase()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.Y = 1;
    plateau.PlateauSizeChecker("Y", +1);

    Assert.That(robotPosition.Y, Is.EqualTo(2));
  }

  [Test]
  public void PlateauSizeChecker_Direction_Y_Decrease()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.Y = 2;
    plateau.PlateauSizeChecker("Y", -1);

    Assert.That(robotPosition.Y, Is.EqualTo(1));
  }

  [Test]
  public void PlateauSizeChecker_Direction_Y_MinLimit()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.Y = 1;
    plateau.PlateauSizeChecker("Y", -1);

    Assert.That(robotPosition.Y, Is.EqualTo(1));
  }

  [Test]
  public void PlateauSizeChecker_Direction_Y_MaxLimit()
  {
    RobotPosition robotPosition = new RobotPosition();
    PlateauSize plateauSize = new PlateauSize();

    Plateau plateau = new Plateau(robotPosition, plateauSize);
    plateau.SetPlateauSize("5x5");
    robotPosition.Y = 5;
    plateau.PlateauSizeChecker("Y", +1);

    Assert.That(robotPosition.Y, Is.EqualTo(5));
  }
  #endregion
}
