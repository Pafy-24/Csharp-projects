//
// Copyright(c) 2021 2D ENDLESS RUNNER Assist-Software
// https://www.assist.ro
//
// For information about the licensing and copyright of this software please
// contact assist at  contact@assist.ro
//

using EndlessRunnerSpine.LevelPlayer;

namespace EndlessRunnerSpine.LevelCollectables
{
    public class Coin : Collectable
    {
        #region Const Members
        private const float kReducedSpeedOnCollision = 0.75f;
        #endregion

        #region Public Methods
        public override Collectable GenerateCollectable()
        {
            return new Coin();
        }

        public override void OnEnter(PlayerController player)
        {
            player.CharacterMovement.PlayerSpeed *= kReducedSpeedOnCollision;
        }

        public override void OnExit(PlayerController player)
        {
            //notImplemented
        }
        #endregion
    }
}
