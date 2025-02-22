using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;

public class ButtonData
{
    public string buttonType;
    public int buttonValue;
    public float frameCount;
    

    public ButtonData(string type, int value,float count)
    {
        buttonType = type;
        buttonValue = value;
        frameCount = count;
    }
}
public class ButtonController : MonoBehaviour
{
    public Button[] buttons;
    private List<ButtonData> buttonDataList;

    private Dictionary<string, int> buttonTypeValues; // �{�^���̎�ނƒl�̑Ή���ێ����鎫��

    void Start()
    {
        buttonDataList = new List<ButtonData>();

        // �{�^���̎�ނƒl�̑Ή���ݒ�
        buttonTypeValues = new Dictionary<string, int>()
        {
            {"Button_red", 4},
            {"Button_pink", 0},
            {"Button_green", 1},
            {"Button_blue", 2},
            {"Button_orange", 3}
           
        };

        foreach (Button button in buttons)
        {
            button.onClick.AddListener(() => TaskOnClick(button));
        }
    }

    void TaskOnClick(Button button)
    {
        // �����ꂽ�{�^���̎��
        string buttonType = button.name;

        // �{�^���̒l���擾
        int buttonValue = buttonTypeValues[buttonType];

        // �o�߃t���[����
        float frameCount = Time.frameCount;

        // �{�^���f�[�^�̍쐬�ƒǉ�
        ButtonData buttonData = new ButtonData(buttonType, buttonValue, frameCount);
        buttonDataList.Add(buttonData);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaveButtonDataToFile();
        }
    }

    void SaveButtonDataToFile()
    {
        string filePath = Application.persistentDataPath + "/buttonData.txt";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (ButtonData buttonData in buttonDataList)
            {
                writer.WriteLine(buttonData.buttonType + "," + buttonData.buttonValue + "," + buttonData.frameCount);
            }
        }

        Debug.Log("Button data saved!");
    }
}