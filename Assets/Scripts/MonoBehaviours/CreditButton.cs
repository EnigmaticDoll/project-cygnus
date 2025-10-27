using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditButton : MonoBehaviour
{
    private GameObject creditCanvas = null;

    void Awake()
    {
        creditCanvas = GameObject.Find("RootCanvas").transform.Find("CreditCanvas").gameObject;
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(OnClick);
    }

    void OnClick()
    {
        creditCanvas.SetActive(true);
    }
}
