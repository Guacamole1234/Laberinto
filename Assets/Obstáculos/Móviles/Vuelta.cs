using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vuelta : MonoBehaviour
{
    bool rotar = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotar == true)
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * 180);
        }
        else
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * -180);
        }
        if (transform.position.z >= 0) { 
        rotar = true;
        }
        else if (transform.position.z <= 180)
        {
            rotar = false;
        }
    }
}
