using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoretext : MonoBehaviour
{
    //�X�R�A���Z������text�ƕR�t����
    public float Score;
    public TextMeshProUGUI scorecounttext;

    //Scoretext�ɃA�N�Z�X���Ď��s����
    internal static void SetScoretext()
    {
        throw new NotImplementedException();
    }

    //Score��END�V�[���ł��o���p�̊֐�
    

    // Start is called before the first frame update
    void Start()
    {
        //0����X�^�[�g����
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //text�̃t�H�[�}�b�g��ݒ肷��
        scorecounttext.text = string.Format("{0}", Score);
    }
}
