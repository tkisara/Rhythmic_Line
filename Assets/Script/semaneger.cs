using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class semaneger : MonoBehaviour
{
    //���f�[�^�̍Đ����u���i�[����
    private new AudioSource audio;

    //���f�[�^���i�[����
    [SerializeField]
    private AudioClip sound;
    private AudioSource SE;

    // Start is called before the first frame update
    void Start()
    {
        SE = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            SE.PlayOneShot(SE.clip);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SE.PlayOneShot(SE.clip);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SE.PlayOneShot(SE.clip);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            SE.PlayOneShot(SE.clip);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            SE.PlayOneShot(SE.clip);
        }
    }
}
