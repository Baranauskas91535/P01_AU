using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDaFaca : MonoBehaviour
{
    public float velocFaca;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up* velocFaca* Time.deltaTime);

        if ( transform.position.y > 35.5f){
            Destroy(this.gameObject);
        }
    }
}
