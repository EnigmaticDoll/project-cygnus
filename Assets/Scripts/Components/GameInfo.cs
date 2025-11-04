using Unity.Entities;

public enum GamePlayMode
{
    SinglePlay,
    MultiPlay
}

public struct GameInfo : IComponentData
{
    GamePlayMode gamePlayMode;
    uint playerMechType;
}
