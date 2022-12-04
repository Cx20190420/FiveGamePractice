using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    private new Rigidbody rigidbody;

    public int Speed=10;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetKeyCode();
    }
    void GetKeyCode()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.LogError(rigidbody.velocity);
            rigidbody.AddForce(Speed * Time.deltaTime * Vector3.forward) ;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidbody.AddForce(Speed * Time.deltaTime * Vector3.back);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidbody.AddForce(Speed * Time.deltaTime * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidbody.AddForce(Speed * Time.deltaTime * Vector3.right); 
        }
    }
}
