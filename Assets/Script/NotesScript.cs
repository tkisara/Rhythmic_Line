using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesScript : MonoBehaviour
{
    public int lineNum;
    private GameController _gameController;
    //private bool isInLine = false;
    private KeyCode _lineKey;

    // Update is called once per frame
    void FixedUpdate()
    {

        //トランスフォームの取得
        Transform myTransform = this.transform;

        //座標の取得
        Vector3 pos = myTransform.position;

        //z方向の速度
        pos.z -= 0.08f;

        //座標の設定
        myTransform.position = pos;
    }

    // Start is called before the first frame update
    void Start()
    {
        _gameController = GameObject.Find("GameController").GetComponent<GameController>();
        _lineKey = GameUtil.GetKeyCodeByLineNum(lineNum);
    }

    // Update is called once per frame
    void Update()
    {
        /*
                if (isInLine)
                {
                    CheckInput(_lineKey);
                }

            }

            void OnTriggerEnter(Collider other)
            {
                isInLine = true;
            }

            void OnTriggerExit(Collider other)
            {
                isInLine = false;
            }

            void CheckInput(KeyCode key)
            {

                if (Input.GetKeyDown(key))
                {
                    _gameController.GoodTimingFunc(lineNum);
                }
            }
        */
    }
}
