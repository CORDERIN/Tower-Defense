using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MostradorDeVida : MonoBehaviour
{
    public TextMeshProUGUI campoTexto;

    public Jogador jogador;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        campoTexto.text = "Vida: " + jogador.GetVida();
        
    }
}
