using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Manager : MonoBehaviour
{
    public GameObject ShowWin;

    public static Manager manager;

    public  int Score = 0; 
    // Start is called before the first frame update
    void Start()
    {
        manager = this;


    }

    // Update is called once per frame
    void Update()
    {
        if (Score == 3)
        {
            ShowWin.SetActive(true);
        }
    }
}
