using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject[] musicbox;
    private float[] _timing;
    private int[] _lineNum;

    public string filePass;
    private int _noteCount = 0;

    private AudioSource _audioSource;
    private float _startTime = 0;

    public float timeOffset = -1;

    private bool _isPlaying = false;
    //public GameObject start;

    // Start is called before the first frame update
    void Start()
    {
        _audioSource = GameObject.Find("GameMusic").GetComponent<AudioSource>();
        _timing = new float[1024];
        _lineNum = new int[1024];
        LoadCSV ();

        _startTime = Time.time;
        _audioSource.Play();
        _isPlaying = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (_isPlaying)
        {
            CheckNextNotes();
        }
        
    }

    public void StartGame()
    {
        //start.SetActive(false);
        //_startTime = Time.time;
        //_audioSource.Play();
        //_isPlaying = true;
    }
    void CheckNextNotes()
    {
        while (_timing[_noteCount] + timeOffset<GetMusicTime()&&_timing[_noteCount]!=0 )
        {
            SpawnNotes (_lineNum[_noteCount]);
            _noteCount++;
        }
    }

    void SpawnNotes(int num)
    {

        if (num == 0)
        {
            Instantiate(musicbox[num], new Vector3(-3.02f , 0.35f, 20), Quaternion.identity); //pink
        }
        else if(num == 1)
        {
            Instantiate(musicbox[num], new Vector3(-0.99f, 0.35f, 20), Quaternion.identity); //green
        }
        else if( num == 2)
        {
            Instantiate(musicbox[num], new Vector3(1.01f, 0.35f, 20), Quaternion.identity); //blue
        }
        else if (num == 3)
        {
            Instantiate(musicbox[num], new Vector3(3.05f, 0.35f, 20), Quaternion.identity); //orange
        }
        else if(num == 4)
        {
            Instantiate(musicbox[num], new Vector3(-6.0f, 0.35f, 20), Quaternion.identity); //red
        }
    
    }

    void LoadCSV()
    {
        int i = 0, j;
        TextAsset csv = Resources.Load (filePass) as TextAsset;
        Debug.Log(csv.text);
        StringReader reader = new StringReader (csv.text);

        while (reader.Peek() > -1)
        {
            string line = reader.ReadLine ();
            string[] valuse = line.Split(',');
            for(j = 0; j < valuse.Length; ++j)
            {
                _timing[i] = float.Parse(valuse[0]);
                _lineNum[i] = int.Parse(valuse[1]);
            }
            ++i;
        }
    }
    float GetMusicTime(){
        return Time.time - _startTime;
    }
    public void GoodTimingFunc(int num)
    {
        Debug.Log("Line:" + num + " good!");
        Debug.Log(GetMusicTime());
    }
}
