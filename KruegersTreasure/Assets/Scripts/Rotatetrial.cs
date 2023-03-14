using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatetrial : MonoBehaviour
{
    public void Spin()
    {
        transform.Rotate(Vector3.forward, 45.0f);
    }
}
