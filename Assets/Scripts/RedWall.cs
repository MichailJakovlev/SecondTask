using UnityEngine;
using System;

public class RedWall : MonoBehaviour
{
    public static Action RedScore;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "RedCube")
        {
            Destroy(collision.gameObject);
            RedScore?.Invoke();
        }
    }
}
