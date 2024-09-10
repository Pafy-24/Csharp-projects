//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.LevelPlayer;

namespace EndlessRunnerSpine.LevelObstacles
{
    public abstract class Obstacle
    {
        public abstract Obstacle GenerateObstacle(); 
        public abstract void OnEnter(PlayerController player);
        public abstract void OnExit(PlayerController player);
    }
}
