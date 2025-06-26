using UnityEngine;

public class Personagem : MonoBehaviour
{
    public int velocidade;
    public int pulo;
    public int vida; 
    string nome;

   /*public int dedos;

  public  int lerDedos()
    {
       return this.dedos; 
    }

   public void AdicionarDedos(int dedos)
    {
        this.dedos = dedos;
    }*/

//aqui é pra ler
    public int LerVelocidade()
    {
        return this.velocidade;
    }
//aqui é pra escrever
    public void velocidadePersonagem(int agilidade)
    { 
        this.velocidade = agilidade;
    }
    
//aqui é pra ler
    public int LerPulo()
    {
        return this.pulo;
    }
//aqui é pra escrever    
    public void puloPersonagem(int acima)
    {
        this.pulo = acima;
    }
    
//aqui é pra ler
    public int LerVida()
    {
        return this.vida;
    }
  
    public void vidaPersonagem(int coracao)
    {
        this.vida = coracao;    
    }
//aqui é pra ler
    public string LerNome()
    {
        return nome;
    }
//aqui é pra escrever    
    public void nomePersonagem(string apelido)
    {
        nome = apelido;
    }
    
    
    void Start()
    {
         
    }
    
    void Update()
    {
        
    }
}
