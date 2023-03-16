using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatetrial : MonoBehaviour
{
    public GameObject obj;
    public void Spin()
    {
        obj.transform.Rotate(Vector3.forward, 45.0f);
        obj.transform.Rotate(Vector3.up, 45.0f);
    }
}
