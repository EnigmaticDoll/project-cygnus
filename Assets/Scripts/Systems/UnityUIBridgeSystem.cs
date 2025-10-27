using System;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UI;

[DisableAutoCreation]
partial class UnityUIBridgeSystem : SystemBase
{
    Dictionary<Entity, GameObject> userInterfaces = new Dictionary<Entity, GameObject>();
    Dictionary<uint, Action> OnMouseDown = new Dictionary<uint, Action>();

    public GameObject canvasObj;

    protected override void OnCreate()
    {
        canvasObj = SpawnCanvas();
    }

    protected override void OnUpdate()
    {
        //foreach(var () in userInterfaces.Values)
        //{

        //}
    }

    protected override void OnDestroy()
    {
        foreach (var obj in userInterfaces.Values) MonoBehaviour.Destroy(obj);
        userInterfaces.Clear();
        MonoBehaviour.Destroy(canvasObj);
    }

    private GameObject SpawnCanvas()
    {
        GameObject obj = new GameObject("ECS.canvas");
        Canvas canvas = obj.AddComponent<Canvas>();

        canvas.additionalShaderChannels =
            AdditionalCanvasShaderChannels.TexCoord1
            | AdditionalCanvasShaderChannels.Normal
            | AdditionalCanvasShaderChannels.Tangent;
        canvas.pixelPerfect = true;
        canvas.renderMode = RenderMode.ScreenSpaceOverlay;
        canvas.sortingOrder = 0;
        canvas.vertexColorAlwaysGammaSpace = false;

        CanvasScaler scaler = obj.AddComponent<CanvasScaler>();
        scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
        scaler.scaleFactor = 1;
        scaler.referencePixelsPerUnit = 100;

        obj.AddComponent<GraphicRaycaster>();

        return obj;
    }
}
