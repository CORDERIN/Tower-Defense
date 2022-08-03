using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMissil : MonoBehaviour
{
    [SerializeField] float velocidade;
    // Start is called before the first frame update
    void Start()
    {
        Destroy (this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posicaoAtual = transform.position;
        Vector3 frente = transform.forward;
        Vector3 deslocamento = frente * velocidade * Time.deltaTime;;
        transform.position = posicaoAtual + deslocamento;
        GameObject alvo = GameObject.Find("Inimigo");
        Vector3 direcao = transform.position;
        Vector3 direcaoInimigo = alvo.transform.position;
        Vector3 novaDirecao = direcaoInimigo - direcao;
        transform.rotation = Quaternion.LookRotation (novaDirecao);

    }
}
