using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public GameObject MissilPrefab;
    public GameObject posicaoDoPontoDeDisparo;

    private float momentoDoUltimoDisparo = 0;
    public float tempoDeRecarga = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 PosicaoDisparo = posicaoDoPontoDeDisparo.transform.position;
        Instantiate (MissilPrefab, PosicaoDisparo, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        float tempoAtual = Time.time;

        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga) {

            momentoDoUltimoDisparo = tempoAtual;

           Vector3 PosicaoDisparo = posicaoDoPontoDeDisparo.transform.position;
           Instantiate (MissilPrefab, PosicaoDisparo, transform.rotation);
        }
    }
}
