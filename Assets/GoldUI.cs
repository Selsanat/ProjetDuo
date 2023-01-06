using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GoldUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] public static int _golds =0;

    // Update is called once per frame
    public void Update()
    {
        _text.text = "Gold : " + _golds;
    }
}
