using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Choque : MonoBehaviour
{
  
    bool golpe = false;
    private Rigidbody2D cuerpo;
    // Start is called before the first frame update
    void Start()
    {
        cuerpo = GetComponent<Rigidbody2D>(); 
    }
    
    // Update is called once per frame
    void Update()
    {
        if(golpe == true)
        { }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        golpe = true;    
        Debug.Log(collision.gameObject.name);      
    }
}
