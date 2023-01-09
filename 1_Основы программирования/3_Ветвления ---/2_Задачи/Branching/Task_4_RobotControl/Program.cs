namespace Task_4_RobotControl
{
    internal class Program
    {
        static bool ShouldFire2(bool enemyInFront, string enemyName, int robotHealth)
        {
            return enemyInFront && (robotHealth >= 50 || enemyName != "boss");
        }
    }
}
