using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCreditButton : MonoBehaviour
{
    [SerializeField]
    private Canvas canvas;

    void Awake()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        if (null != canvas) canvas.gameObject.SetActive(false);
    }
}
