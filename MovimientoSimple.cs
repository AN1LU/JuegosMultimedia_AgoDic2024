using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSimple : MonoBehaviour
{
    public float velocidad = 5;
    private Vector2 input;
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        input = new Vector2();
        if(Input.GetKey(KeyCode.LeftArrow)){ input.x = -1; }
        if(Input.GetKey(KeyCode.RightArrow)){ input.x = 1; }
        if(Input.GetKey(KeyCode.UpArrow)){ input.y = 1; }
        if(Input.GetKey(KeyCode.DownArrow)){ input.y = -1; }

        Vector3 movimientoLateral = Vector3.right *input.x *velocidad * Time.deltaTime;
        Vector3 arribaAbajo = Vector3.up * input.y* velocidad * Time.deltaTime;
        transform.Translate(movimientoLateral);
        transform.Translate(arribaAbajo);
    }

     void Start()
    {
        
    }
}
