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
    public class HGZone : Obstacle
    {
        #region Public Methods
        public override Obstacle GenerateObstacle()
        {
            return new HGZone();
        }

        public override void OnEnter(PlayerController player)
        {
            player.CharacterMovement.InHGZone = true;
        }

        public override void OnExit(PlayerController player)
        {
            player.CharacterMovement.InHGZone = false;
        }
        #endregion
    }
}
