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

        //�g�����X�t�H�[���̎擾
        Transform myTransform = this.transform;

        //���W�̎擾
        Vector3 pos = myTransform.position;

        //z�����̑��x
        pos.z -= 0.08f;

        //���W�̐ݒ�
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
