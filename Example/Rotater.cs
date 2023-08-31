using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteInEditMode]
public class Rotater : MonoBehaviour
{
    public Vector3 speed = Vector3.one;
    void Update()
    {
        transform.Rotate(speed);
    }
}
