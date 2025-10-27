using System.Numerics;
using Unity.Entities;
using UnityEngine;

public struct UIRectTransform : IComponentData
{
    UnityEngine.Vector3 position;
    UnityEngine.Vector2 size;
    UnityEngine.Vector2 anchorMin;
    UnityEngine.Vector2 anchorMax;
    UnityEngine.Vector2 pivot;
    UnityEngine.Vector3 rotation;
    UnityEngine.Vector3 scale;
}
