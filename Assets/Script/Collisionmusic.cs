using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;

public class Collisionmusic : MonoBehaviour
{

    //�X�R�A��Scoretext���A�^�b�`���Ă���scorecounttext���i�[����
    public Scoretext Sms;

    //�R���{��Combotext���A�^�b�`���Ă���combocounttext���i�[����
    public Combotext Smc;

    //gauge���A�^�b�`���Ă���scoregauge���i�[����
    public ScoregaugeManager Ssg;


    //�X�R�A���Z������text�ƕR�t����
    public float Score;
    public TextMeshProUGUI scorecounttext;

    //�R���{���Z������text�ƕR�t����
    public float Combo;
    public TextMeshProUGUI combocounttext;

    //�X���C�_�[���i�[����
    public float gauge;
    public Slider scoregauge;

    //private AudioSource SE;

    //�G�t�F�N�g
    [SerializeField]
    [Tooltip("����������G�t�F�N�g(�p�[�e�B�N��)")]
    private ParticleSystem particle;


    internal static void SetScoretext()
    {
        throw new NotImplementedException();
    }
    internal static void SetSgauge()
    {
        throw new NotImplementedException();
    }
    //Combotext�ɃA�N�Z�X���Ď��s����
    internal static void SetCombotext()
    {
        throw new NotImplementedException();
    }
    //Start is called before the first frame update
    private void Start()
    {
        //�R���|�[�l���g����scorecounttext�����o����
        Sms = GameObject.Find("scorecounttext").GetComponent<Scoretext>();
        //0����X�^�[�g����
        Score = 0;

        //�R���|�[�l���g����scoregauge�����o����
        Ssg = GameObject.Find("scoregauge").GetComponent<ScoregaugeManager>();
        gauge = 0;
       

        //�R���|�[�l���g����combocounttext�����o����
        Smc = GameObject.Find("combocounttext").GetComponent<Combotext>();
        //0����X�^�[�g����
        Combo = 0;

    }

   

    public class Trigger : MonoBehaviour
    {

        public void PointerDown()
        {
            //�I�u�W�F�N�g���A�N�e�B�u�ɂ���
            this.gameObject.SetActive(true);
        }

        public void PointerUp()
        {
            //�I�u�W�F�N�g���A�N�e�B�u�ɂ���
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {

        //"Player"�^�O�����Ă���I�u�W�F�N�g�ɏՓ˂����ꍇ
        if (collision.gameObject.tag == "Player")
        {

            //0.2�b��ɃI�u�W�F�N�g��������
            Destroy(gameObject, 0.05f);

            //�X�R�A20��������
            Sms.Score += 20;

            //0.06��������
            Ssg.gauge += 0.06f;

            //�R���{1��������
            Smc.Combo += 1;

            // �p�[�e�B�N���V�X�e���̃C���X�^���X�𐶐�����B
            ParticleSystem newParticle = Instantiate(particle);
            // �p�[�e�B�N���̔����ꏊ�����̃X�N���v�g���A�^�b�`���Ă���GameObject�̏ꏊ�ɂ���B
            newParticle.transform.position = this.transform.position;
            // �p�[�e�B�N���𔭐�������B
            newParticle.Play();
            Destroy(newParticle.gameObject, 0.5f);

           
        }
        //"reset"�^�O�̃I�u�W�F�N�g�ɏՓ˂����ꍇ 
        if (collision.gameObject.tag == "resetbox")
        {
            //�R���{��0�ɂ���
            Smc.Combo = 0;

            //�X�R�A20��������
            Sms.Score -= 5;

            //�I�u�W�F�N�g��������
            Destroy(this.gameObject);

            //0.02��������
            Ssg.gauge -= 0.02f;
        }
    }

    void Update()
    {

    }

}
