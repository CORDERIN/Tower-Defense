using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour
{

    public int vida;

    public void RecebeDano(int pontosDeDano) {
        
        vida -= pontosDeDano;
        if (vida <= 0) {
        Destroy(this.gameObject);
    }
}

    // Start is called before the first frame update

    void Start()
    {
       UnityEngine.AI.NavMeshAgent agente = GetComponent<UnityEngine.AI.NavMeshAgent>();
       GameObject fimDoCaminho = GameObject.Find ("FimDoCaminho");
       Vector3 posicaoDoFimDoCaminho = fimDoCaminho.transform.position;
       agente.SetDestination (posicaoDoFimDoCaminho);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
