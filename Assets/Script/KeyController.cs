using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyController : MonoBehaviour
{
    [SerializeField] GameObject targetObjectred;
    [SerializeField] GameObject targetObjectpink;
    [SerializeField] GameObject targetObjectgreen;
    [SerializeField] GameObject targetObjectblue;
    [SerializeField] GameObject targetObjectorange;

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            targetObjectred.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            targetObjectpink.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            targetObjectgreen.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            targetObjectblue.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            targetObjectorange.SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            targetObjectred.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            targetObjectpink.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            targetObjectgreen.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.J))
        {
            targetObjectblue.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.K))
        {
            targetObjectorange.SetActive(false);
        }
    }
}
