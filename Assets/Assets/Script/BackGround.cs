using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
   public float velocidade = 40.0f;
   public float reposicao = -112.6f;
   public Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       float novoposicao =  Mathf.Repeat(Time.time * velocidade,reposicao);
       transform.position = posicaoInicial + Vector3.down * novoposicao;
    }
}
