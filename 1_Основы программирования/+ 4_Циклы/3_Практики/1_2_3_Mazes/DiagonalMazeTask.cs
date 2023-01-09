using System;

namespace Mazes
{
    public static class DiagonalMazeTask
    {
        public static void MoveOut(Robot robot, int width, int height)
        {
            int stepCountSmallSide = 1;
            int stepCountLargeSide = width > height ?
                (int)Math.Round((double)width / height, 0) : (int)Math.Round((double)height / width, 0);

            while (!robot.Finished)
            {
                if (width > height) WidthLongerHeightMove(robot, stepCountSmallSide, stepCountLargeSide);
                else HeightLongerWidthMove(robot, stepCountSmallSide, stepCountLargeSide);
            }
        }

        private static void HeightLongerWidthMove(Robot robot, int stepCountSmallSide, int stepCountLargeSide)
        {
            Move(robot, Direction.Down, stepCountLargeSide);
            if (!robot.Finished)
                Move(robot, Direction.Right, stepCountSmallSide);
        }

        private static void WidthLongerHeightMove(Robot robot, int stepCountSmallSide, int stepCountLargeSide)
        {
            Move(robot, Direction.Right, stepCountLargeSide);
            if (!robot.Finished)
                Move(robot, Direction.Down, stepCountSmallSide);
        }

        private static void Move(Robot robot, Direction direction, int stepCount)
        {
            for (int i = 0; i < stepCount; i++)
                robot.MoveTo(direction);
        }
    }
}