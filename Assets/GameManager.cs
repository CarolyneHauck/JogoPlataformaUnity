using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager gm; //referencia a classe nao objeto

    private int vidas = 2;
    private int moedas = 0;

    // Chama a função antes de iniciar a cena.
    void Awake () {

        if (gm == null)
        {
            gm = this;
            DontDestroyOnLoad(gameObject);
        }

        else
            Destroy(gameObject);
		
	}
	
	// Update is called once per frame
	void Update () {

    }

    void Start()
    {
        AtualizaHud();
    }

    public void SetVidas(int vida)
    {
        vidas += vida;
        if(vidas >= 0)
        AtualizaHud();
    }

    public int GetVidas()
    {
        return vidas;
    }

    public void SetMoedas(int moeda)
    {
        moedas += moeda;
        if(moedas >= 25)
        {
            moedas = 0;
            vidas += 1;
        }

        AtualizaHud();
    }

    public void AtualizaHud()
    {
        GameObject.Find("VidasText").GetComponent<Text>().text = vidas.ToString();
        GameObject.Find("MoedaText").GetComponent<Text>().text = moedas.ToString();
    }

    public void OnLevelWasLoaded()
    {
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            vidas = 2;
            moedas = 0;
        }
    }
}
