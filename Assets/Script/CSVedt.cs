using UnityEngine;
using System.Collections;
using System.IO;  // <- �����ɒ���

public class CSVedt : MonoBehaviour
{

    public string fileName; // �ۑ�����t�@�C����

    //�e�X�g�p
      void Start()
    {
        //WriteCSV("Hello,wWorld");
    }

    // CSV�ɏ������ޏ���
    public void WriteCSV(string txt)
    {
        StreamWriter streamWriter;
        FileInfo fileInfo;
        fileInfo = new FileInfo(Application.dataPath + "/" + fileName + ".csv");
        streamWriter = fileInfo.AppendText();
        streamWriter.WriteLine(txt);
        streamWriter.Flush();
        streamWriter.Close();
    }
}