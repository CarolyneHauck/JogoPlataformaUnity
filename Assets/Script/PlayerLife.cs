using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour {

    Animator anim;

    bool vivo = true;

    public AudioClip deadSound;
    private AudioSource audioS;

    // Use this for initialization
    void Start ()
    {
        audioS = gameObject.GetComponent<AudioSource>();
        anim = gameObject.GetComponent<Animator>();
        GameManager.gm.AtualizaHud();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PerdeVida()
    {
        if (vivo)
        {
            audioS.clip = deadSound;
            audioS.Play();

            vivo = false;
            anim.SetTrigger("Morreu");
            GameManager.gm.SetVidas(-1);
            gameObject.GetComponent<PlayerAttack>().enabled = false;
            gameObject.GetComponent<PlayerController>().enabled = false;
            gameObject.GetComponent<Espinho>().enabled = false;
        }
    }

    public void Reset()
    {
        if(GameManager.gm.GetVidas() >= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        else
        {
            SceneManager.LoadScene(4);
        }
    }
}
