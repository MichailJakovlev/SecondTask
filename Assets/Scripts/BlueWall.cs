using UnityEngine;
using System;

public class BlueWall : MonoBehaviour 
{
    public static Action BlueScore;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueCube")
        {
            Destroy(collision.gameObject);
            BlueScore?.Invoke();
        }
    }  
}
