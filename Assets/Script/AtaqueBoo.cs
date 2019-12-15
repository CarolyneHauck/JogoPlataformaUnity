using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueBoo : MonoBehaviour
{
    Rigidbody2D rb;
    bool facingRight = false;

    public float velocidade;
    public float duracaoPosicao;
    public float tempo;
    public bool posicao;

    // Use this for initialization
    void Start()
    {
    }


    // Update is called once per frame
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
                Flip();
            }
            else
            {
                posicao = true;
            }
        }
        //movimenta
        if (posicao)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
        }
        else
        {
            transform.Translate(-Vector2.right * velocidade * Time.deltaTime);
        }
    }

    void Flip()
    {
        facingRight = !facingRight;

        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<PlayerLife>().PerdeVida();
        }
    }
}
