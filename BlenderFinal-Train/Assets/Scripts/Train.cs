using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train : MonoBehaviour
{
    
    public float _speed = 100f;

    void Update()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
    
    
}
