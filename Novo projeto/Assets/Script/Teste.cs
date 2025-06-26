using Unity.VisualScripting;
using UnityEngine;

public class Teste : MonoBehaviour
{
    private Pirata _a;
    private Personagem _p;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _a = new Pirata();
        _p = new Personagem();

        _p.velocidadePersonagem(10);
        _p.vidaPersonagem(20);
        _p.nomePersonagem("Ace");
        _p.puloPersonagem(15);

        _a.distancia(15);
        _a.ataqueEspecial(true);
        _a.Tambor(6);
       
        Debug.Log(_p.LerVelocidade() + " de agilidade");
        Debug.Log(_p.LerVida() + " de vida" );
        Debug.Log(_p.LerNome() + " é um pirata");
        Debug.Log(_p.LerPulo() + " de pulo");

        Debug.Log(_a.distancia( 15) + " Metros do gancho");
        Debug.Log(_a.Atirou() + " Bola de canhão");
        Debug.Log(_a.Tambor(6) + " balas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
