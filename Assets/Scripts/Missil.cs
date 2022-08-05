using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public GameObject MissilPrefab;
    public GameObject posicaoDoPontoDeDisparo;
    private float momentoDoUltimoDisparo = 0;
    public float tempoDeRecarga;
    public int raioDeAlcance = 30;

    private void Atira(Inimigo inimigo)
    {
        float tempoAtual = Time.time;
        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
        {
            momentoDoUltimoDisparo = tempoAtual;

            Vector3 PontoDeDisparo = posicaoDoPontoDeDisparo.transform.position;
            GameObject projetilObject = (GameObject)Instantiate(MissilPrefab, PontoDeDisparo, Quaternion.identity);
            MovimentoMissil missil = projetilObject.GetComponent<MovimentoMissil>();
            //missil.DefineAlvo(inimigo);
        }
    }


    private bool EstaNoRaioDeAlcance(GameObject inimigo)
    {
        Vector3 posicaoDoInimigoNoPlano = Vector3.ProjectOnPlane(inimigo.transform.position, Vector3.up);
        Vector3 posicaoDaTorreNoPlano = Vector3.ProjectOnPlane(this.transform.position, Vector3.up);
        float distanciaParaInimigo = Vector3.Distance(posicaoDaTorreNoPlano, posicaoDoInimigoNoPlano);
        return (distanciaParaInimigo <= raioDeAlcance);
    }

    private Inimigo EscolheAlvo()
    {
        GameObject[] inimigos = GameObject.FindGameObjectsWithTag("Inimigo");

        foreach (GameObject inimigoAtual in inimigos)
        {

            if (EstaNoRaioDeAlcance(inimigoAtual))
            {

                return inimigoAtual.GetComponent<Inimigo>();
            }
        }

        return null;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float tempoAtual = Time.time;

        if (tempoAtual > momentoDoUltimoDisparo + tempoDeRecarga)
        {
            momentoDoUltimoDisparo = tempoAtual;
            Vector3 PosicaoDisparo = posicaoDoPontoDeDisparo.transform.position;
            Instantiate(MissilPrefab, PosicaoDisparo, transform.rotation);
        }

    }
}

