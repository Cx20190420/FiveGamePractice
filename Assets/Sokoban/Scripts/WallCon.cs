using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCon : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Wall"))
        {
            Manager.manager.Score++;
            transform.GetComponent<MeshRenderer>().material.color = Color.grey;
        }
    }
}
