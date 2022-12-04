using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWhac : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);//将对象坐标换成屏幕坐标
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, pos.z);//让鼠标的屏幕坐标与对象坐标一致
        transform.position = new Vector3(Camera.main.ScreenToWorldPoint(mousePos).x, transform.position.y, Camera.main.ScreenToWorldPoint(mousePos).z);//将正确的鼠标屏幕坐标换成世界坐标交给物体

        //  transform.position =new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, transform.position.z) ;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.LogError("xxx");
        other.transform.GetComponent<MeshRenderer>().material.color = Color.red;
        StartCoroutine(CHhange(other.transform));
    }
    IEnumerator CHhange(Transform transform)
    {

        yield return new WaitForSeconds(0.8f);
        transform.GetComponent<MeshRenderer>().material.color = Color.black;

    }
}
