using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float veloc ;

    public float entradaHorizontal;
    public float entradaVertical;

    public GameObject pfFaca;

    private float tempoDeDisparo = 1.0f;

    private float podeDisparar = 0.0f;

  
    void Start()
    {

    
        veloc = 111.0f;
        transform.position = new Vector3(0,0,0);

    }

    void Update()
    {
        Movimento(); 
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){
            Disparo();
           }
    }               
          
      
        void Movimento()
        {
          float entradaHorizontal = Input.GetAxis("Horizontal");
          transform.Translate(Vector3.right * entradaHorizontal * Time.deltaTime * veloc);
          if ( transform.position.y > 0){
            transform.position = new Vector3(transform.position.x,0,0);
          }else if (transform.position.y < -18.0f){
            transform.position = new Vector3 (transform.position.x,-18.0f,0);
          }

         float entradaVertical = Input.GetAxis("Vertical");
         transform.Translate(Vector3.up * entradaVertical * Time.deltaTime * veloc);

         if ( transform.position.x > 58.4f){
            transform.position = new Vector3( -60.3f,transform.position.y,0);
            } else if (transform.position.x < -60.3f){
             transform.position = new Vector3( 58.4f,transform.position.y,0);
          }

        }


            void Disparo() 
            {    
                if (Time.time > podeDisparar) {
                Instantiate(pfFaca,transform.position + new Vector3 (0,1.1f,0),Quaternion.identity);
                podeDisparar = Time.time + tempoDeDisparo ;
            
                }
               
                         
            }    
}
