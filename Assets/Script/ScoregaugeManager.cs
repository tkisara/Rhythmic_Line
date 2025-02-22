using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoregaugeManager : MonoBehaviour
{
    //加算したいVauleと紐付ける
    public float gauge;
    public Slider scoregauge;

    //sliderにアクセスして実行する
    internal static void SetSgauge()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        //0からスタートする
        gauge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //加算設定する
        scoregauge.value = gauge;
    }
}