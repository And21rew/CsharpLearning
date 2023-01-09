namespace Mazes
{
    public static class SnakeMazeTask
    {
        private static readonly int startPosition = 1;
        private static readonly int finishPosition = 2;
        private static readonly int wallSize = startPosition + finishPosition;

        public static void MoveOut(Robot robot, int width, int height)
        {
            int stepCountDown = finishPosition + wallSize;

            while (!robot.Finished)
            {
                Move(robot, Direction.Right, width);
                Move(robot, Direction.Down, stepCountDown);
                Move(robot, Direction.Left, width);
                if (!robot.Finished)
                    Move(robot, Direction.Down, stepCountDown);
            }
        }

        private static void Move(Robot robot, Direction direction, int stepCount)
        {
            for (int i = 0; i < stepCount - wallSize; i++)
                robot.MoveTo(direction);
        }
    }
}