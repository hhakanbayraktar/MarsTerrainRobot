using MarsTerrainRobot;
using MarsTerrainRobot.Model;

Console.WriteLine("Plateau grid size :");
var gridSize = Console.ReadLine();

Console.WriteLine("Command :");
var command = Console.ReadLine();

RobotPosition robotPosition = new RobotPosition();
PlateauSize plateauSize = new PlateauSize();

Plateau plateau = new Plateau(robotPosition, plateauSize);
plateau.SetPlateauSize(gridSize);

NavigateCommands nvgCmd = new NavigateCommands(robotPosition, plateauSize);
nvgCmd.Navigate(command);

Console.WriteLine(robotPosition.X + "," + robotPosition.Y + "," + robotPosition.Direction.ToString());
