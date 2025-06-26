using System.Runtime.CompilerServices;
using UnityEngine;

public class Pirata : Personagem
{
    public int balas;
    public int Gancho;
    public bool TiroCanhão;

    public bool Atirou()
    {
        return TiroCanhão;
    }

    public int Tambor(int pistola)
    {
          return balas = pistola;
    }

    public int distancia( int corda)
    {
        return Gancho = corda;
    }

    public void ataqueEspecial(bool BolaCanhão)
    {
        if(balas == 0)
        {
            TiroCanhão = true;
           
        }
    }
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
