using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{

    [SerializeField] private int vida;
    public bool EstaVivo()
    {
        return vida > 0;
    }
    public int GetVida()
    {
        return vida;
    }
    public void PerdeVida()
    {
        vida--;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
