using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinglePlayButton : MonoBehaviour
{
    private GameObject singlePlayMenuCanvas = null;

    void Awake()
    {
        singlePlayMenuCanvas = GameObject.Find("RootCanvas").transform.Find("SinglePlayMenuCanvas").gameObject;
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        singlePlayMenuCanvas.SetActive(true);
    }
}
