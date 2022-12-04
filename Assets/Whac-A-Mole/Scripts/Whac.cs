using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whac : MonoBehaviour
{
    public GameObject[] Hamsters;

    private int TimeNum = 20;


    private Vector3 VecY =new Vector3( 0, 1.9f,0);

    private bool isVecy = true;

    private int Index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isVecy)
        {
            TimeNum--;
        }
       

        if (TimeNum == 0 && isVecy)
        {
            Index = Random.Range(0, Hamsters.Length);
               isVecy = false;
               TimeNum = 20;
            Hamsters[Index].transform.position += VecY;
            StartCoroutine(ReturnBack());
        }
    }
    IEnumerator  ReturnBack()
    {
        yield return new WaitForSeconds(1);
        Hamsters[Index].transform.position -= VecY;
        isVecy = true;
    }
}
