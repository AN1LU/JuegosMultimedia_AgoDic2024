using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Camara : MonoBehaviour
{
    public Transform objeto;
    public float SmoothSpeed = 4f;
    public Vector3 desfase;

    void LateUpdate()
    {
        Vector3 desiredPosition = objeto.position + desfase;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition,
        SmoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
