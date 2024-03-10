using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSource : MonoBehaviour
{
    public Transform targetPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(targetPoint.position);
    }
}
