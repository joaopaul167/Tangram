using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateSpeed = 30f;
    
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            this.gameObject.transform.Rotate(0, 0, Time.deltaTime * rotateSpeed);
        }
    }
}
