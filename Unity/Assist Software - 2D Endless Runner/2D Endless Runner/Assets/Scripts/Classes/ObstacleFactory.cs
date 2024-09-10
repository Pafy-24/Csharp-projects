//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.Enums;

namespace EndlessRunnerSpine.LevelObstacles
{
    public class ObstacleFactory
    {
        public Obstacle CreateObstacle(ObstacleType obstacleType)
        {
            switch (obstacleType)
            {
                case ObstacleType.Crate:
                    return new Crate();

                case ObstacleType.HGZone:
                    return new HGZone();

                default:
                    return null;
            }
        }
    }
}