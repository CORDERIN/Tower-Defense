using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
    public GameObject gameOver;

    public Jogador jogador;

    public void RecomecaJogo()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    private bool JogoAcabou()
    {
        return !jogador.EstaVivo();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (JogoAcabou())
        {
            gameOver.SetActive(true);
        }

    }
}
