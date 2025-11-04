using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using UnityEngine;
using UnityEngine.UIElements;

[DisableAutoCreation]
partial class UserInterfaceViewModelBindingSystem : SystemBase
{
    Dictionary<IComponentData, BindableElement> bindings = new Dictionary<IComponentData, BindableElement>();



    Dictionary<Entity, GameObject> userInterfaces = new Dictionary<Entity, GameObject>();
    Dictionary<uint, Action> OnMouseDown = new Dictionary<uint, Action>();
    public GameObject canvasObj;

    protected override void OnCreate()
    {
        //GetCom
        //Label x;
        //x.RegisterCallback<MouseDownEvent>(OnU)



        //canvasObj = SpawnCanvas();
    }

    protected override void OnStartRunning()
    {
        ttt();
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

    void ttt()
    {
        VisualElement ve = MonoBehaviour.FindAnyObjectByType<UIDocument>().rootVisualElement;
        Button singlePlayButton = ve.Q<Button>("SinglePlayButton");

        var x1 = ve.Q<ListView>().binding;
        var x2 = ve.Q<RadioButtonGroup>().binding;
        var x3 = ve.Q<RadioButton>().binding;
        if(singlePlayButton != null) Debug.Log("G");
    }

    //private GameObject SpawnCanvas()
    //{
    //    GameObject obj = new GameObject("ECS.canvas");
    //    Canvas canvas = obj.AddComponent<Canvas>();

    //    canvas.additionalShaderChannels =
    //        AdditionalCanvasShaderChannels.TexCoord1
    //        | AdditionalCanvasShaderChannels.Normal
    //        | AdditionalCanvasShaderChannels.Tangent;
    //    canvas.pixelPerfect = true;
    //    canvas.renderMode = RenderMode.ScreenSpaceOverlay;
    //    canvas.sortingOrder = 0;
    //    canvas.vertexColorAlwaysGammaSpace = false;

    //    CanvasScaler scaler = obj.AddComponent<CanvasScaler>();
    //    scaler.uiScaleMode = CanvasScaler.ScaleMode.ConstantPixelSize;
    //    scaler.scaleFactor = 1;
    //    scaler.referencePixelsPerUnit = 100;

    //    obj.AddComponent<GraphicRaycaster>();

    //    return obj;
    //}
}
