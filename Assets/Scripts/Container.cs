using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Container : MonoBehaviour
{

    public GameObject torrePrefab;
    private Vector3 posicaoDoElemento;

    void Start()
    {

    }

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
           

            Vector3 pontoDoClique = Input.mousePosition;
            Ray raioDaCamera = Camera.main.ScreenPointToRay(pontoDoClique);
            float comprimentoMaximo = 1000000.0f;
            Physics.Raycast(raioDaCamera, out RaycastHit infoDoRaio, comprimentoMaximo);

            if (infoDoRaio.collider != null)
            {
                posicaoDoElemento = infoDoRaio.point;
                posicaoDoElemento.y += 370;
                posicaoDoElemento.z += 200;
                posicaoDoElemento.x -= 80;
                Instantiate(torrePrefab, posicaoDoElemento, Quaternion.identity);
            }

              
        }
     }
}

