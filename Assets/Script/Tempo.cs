using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Tempo : MonoBehaviour
{
    public Text displayContagem;
    public float contagem = 60;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (contagem > 0)
        {
            contagem -= Time.deltaTime;
            displayContagem.text = contagem.ToString();
            displayContagem.text = "Tempo: " + contagem.ToString();
            if (contagem < 0)
            {
                displayContagem.text = "GAME OVER!";
                SceneManager.LoadScene("GameOver");
            }
            GameManager.gm.AtualizaHud();
        }
    }

    public void OnLevelWasLoaded()
    {
        if (SceneManager.GetActiveScene().buildIndex == 60)
        {
            contagem = 60;
        }
    }
}
