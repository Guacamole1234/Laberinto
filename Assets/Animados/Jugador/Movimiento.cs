using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    private Rigidbody2D Cuerpo;
    // Start is called before the first frame update
    void Start()
    {
        Cuerpo = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        var speed = 4f;
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Cuerpo.velocity = new Vector2 (moveHorizontal*speed, moveVertical*speed);
        }
    }
