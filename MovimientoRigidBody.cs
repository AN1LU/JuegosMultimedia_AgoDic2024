using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoRigidBody : MonoBehaviour
{
    public float velocidad=1;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);
        rb2d.AddForce(movimiento * velocidad);
    }
    void Update(){

    }
    }

      
    

