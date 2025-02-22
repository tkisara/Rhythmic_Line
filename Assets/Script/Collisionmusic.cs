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

    //スコアやScoretextをアタッチしているscorecounttextを格納する
    public Scoretext Sms;

    //コンボやCombotextをアタッチしているcombocounttextを格納する
    public Combotext Smc;

    //gaugeをアタッチしているscoregaugeを格納する
    public ScoregaugeManager Ssg;


    //スコア加算したいtextと紐付ける
    public float Score;
    public TextMeshProUGUI scorecounttext;

    //コンボ加算したいtextと紐付ける
    public float Combo;
    public TextMeshProUGUI combocounttext;

    //スライダーを格納する
    public float gauge;
    public Slider scoregauge;

    //private AudioSource SE;

    //エフェクト
    [SerializeField]
    [Tooltip("発生させるエフェクト(パーティクル)")]
    private ParticleSystem particle;


    internal static void SetScoretext()
    {
        throw new NotImplementedException();
    }
    internal static void SetSgauge()
    {
        throw new NotImplementedException();
    }
    //Combotextにアクセスして実行する
    internal static void SetCombotext()
    {
        throw new NotImplementedException();
    }
    //Start is called before the first frame update
    private void Start()
    {
        //コンポーネントからscorecounttextを検出する
        Sms = GameObject.Find("scorecounttext").GetComponent<Scoretext>();
        //0からスタートする
        Score = 0;

        //コンポーネントからscoregaugeを検出する
        Ssg = GameObject.Find("scoregauge").GetComponent<ScoregaugeManager>();
        gauge = 0;
       

        //コンポーネントからcombocounttextを検出する
        Smc = GameObject.Find("combocounttext").GetComponent<Combotext>();
        //0からスタートする
        Combo = 0;

    }

   

    public class Trigger : MonoBehaviour
    {

        public void PointerDown()
        {
            //オブジェクトをアクティブにする
            this.gameObject.SetActive(true);
        }

        public void PointerUp()
        {
            //オブジェクトを非アクティブにする
            this.gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collision)
    {

        //"Player"タグがついているオブジェクトに衝突した場合
        if (collision.gameObject.tag == "Player")
        {

            //0.2秒後にオブジェクトが消える
            Destroy(gameObject, 0.05f);

            //スコア20増加する
            Sms.Score += 20;

            //0.06増加する
            Ssg.gauge += 0.06f;

            //コンボ1増加する
            Smc.Combo += 1;

            // パーティクルシステムのインスタンスを生成する。
            ParticleSystem newParticle = Instantiate(particle);
            // パーティクルの発生場所をこのスクリプトをアタッチしているGameObjectの場所にする。
            newParticle.transform.position = this.transform.position;
            // パーティクルを発生させる。
            newParticle.Play();
            Destroy(newParticle.gameObject, 0.5f);

           
        }
        //"reset"タグのオブジェクトに衝突した場合 
        if (collision.gameObject.tag == "resetbox")
        {
            //コンボを0にする
            Smc.Combo = 0;

            //スコア20減少する
            Sms.Score -= 5;

            //オブジェクトが消える
            Destroy(this.gameObject);

            //0.02減少する
            Ssg.gauge -= 0.02f;
        }
    }

    void Update()
    {

    }

}
