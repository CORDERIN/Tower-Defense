using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMissil : MonoBehaviour
{
    [SerializeField] float velocidade;

    public int Dano = 2;

    private GameObject alvo;


    //public void DefineAlvo(GameObject inimigo){

        //alvo = inimigo;

    //}


    void OnTriggerEnter(Collider elementoColidido)
    {

        if (elementoColidido.CompareTag("Inimigo"))
        {

            Destroy(this.gameObject);

            Inimigo inimigo = elementoColidido.GetComponent<Inimigo>();
            inimigo.RecebeDano(Dano);

        }
    }
    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.FindWithTag("Inimigo") != null)
        {

            alvo = GameObject.FindWithTag("Inimigo");

        }

        Destroy(this.gameObject, 5);

    }

    // Update is called once per frame
    void Update()
    {

        if (alvo == null) Destroy(this.gameObject);

        if (alvo != null)
        {

            Vector3 direcao = transform.position;
            Vector3 direcaoInimigo = alvo.transform.position;
            Vector3 novaDirecao = direcaoInimigo - direcao;
            transform.rotation = Quaternion.LookRotation(novaDirecao);
            Vector3 posicaoAtual = transform.position;
            Vector3 frente = transform.forward;
            Vector3 deslocamento = frente * velocidade * Time.deltaTime; ;
            transform.position = posicaoAtual + deslocamento;

        }


    }
}
