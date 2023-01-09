namespace Mazes
{
    public static class EmptyMazeTask
    {
        private static readonly int startPosition = 1;
        private static readonly int finishPosition = 2;
        private static readonly int wallSize = startPosition + finishPosition;

        public static void MoveOut(Robot robot, int width, int height)
        {
            Move(robot, Direction.Right, width);
            Move(robot, Direction.Down, height);
        }

        private static void Move(Robot robot, Direction direction, int stepCount)
        {
            for (int i = 0; i < stepCount - wallSize; i++)
                robot.MoveTo(direction);
        }
    }
}