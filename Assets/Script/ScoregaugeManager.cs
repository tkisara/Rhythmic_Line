using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoregaugeManager : MonoBehaviour
{
    //���Z������Vaule�ƕR�t����
    public float gauge;
    public Slider scoregauge;

    //slider�ɃA�N�Z�X���Ď��s����
    internal static void SetSgauge()
    {
        throw new NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        //0����X�^�[�g����
        gauge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //���Z�ݒ肷��
        scoregauge.value = gauge;
    }
}