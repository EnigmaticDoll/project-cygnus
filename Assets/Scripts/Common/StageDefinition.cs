using System;
using System.Collections.Generic;
using UnityEngine;

public struct StageDefinition
{
    uint stageID;
    Dictionary<float, Action> stageEvents;
    Vector2 stageSize;
    float timeLimit;
}
