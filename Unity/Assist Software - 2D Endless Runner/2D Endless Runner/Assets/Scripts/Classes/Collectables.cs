

using EndlessRunnerSpine.LevelPlayer;

namespace EndlessRunnerSpine.LevelCollectables
{
    public abstract class Collectable
    {
        public abstract Collectable GenerateCollectable();
        public abstract void OnEnter(PlayerController player);
        public abstract void OnExit(PlayerController player);
    }
}