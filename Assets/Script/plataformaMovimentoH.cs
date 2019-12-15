using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMovimentoH : MonoBehaviour
{

    public float velocidade;
    public float duracaoPosicao;
    public float tempo;
    public bool posicao;

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        //Aumenta o tempo que esta na posiçao atual
        tempo += Time.deltaTime;

        //Se o tempo 
        if (tempo >= duracaoPosicao)
        {
            //Zera contagem
            tempo = 0;

            //Muda a posiçao
            if (posicao)
            {
                posicao = false;
            }
            else
            {
                posicao = true;
            }
        }
        //movimenta
        if (posicao)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.up * velocidade * Time.deltaTime);
        }
    }

    void OnCollisionStay2D(Collision2D colisor)
    {
        if (colisor.gameObject.name == "Player")
        {
            colisor.gameObject.transform.parent = transform;
        }
    }
}
