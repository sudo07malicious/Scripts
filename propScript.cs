using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class propScript : MonoBehaviour
{
    // Start is called before the first frame update
    private float propSpeed = 100.0f;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * Time.deltaTime * propSpeed);
    }
}
