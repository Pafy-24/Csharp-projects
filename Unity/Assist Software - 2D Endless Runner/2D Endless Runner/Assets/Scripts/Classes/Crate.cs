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
    public class Crate : Obstacle
    {
        #region Const Members
        private const float kReducedSpeedOnCollision = 0.75f;
        #endregion

        #region Public Methods
        public override Obstacle GenerateObstacle()
        {
            return new Crate();
        }

        public override void OnEnter(PlayerController player)
        {
            //Implementation code:
            //Improve actual functionality when the player is colliding with the crate

            player.CharacterMovement.PlayerSpeed *= kReducedSpeedOnCollision;
        }

        public override void OnExit(PlayerController player)
        {
            //notImplemented
        }
        #endregion
    }
}
