using UnityEngine;

public class Aprender : MonoBehaviour
{
    public string materia;

    public double horario;

    public bool atividade;

    public void materiaEstudo(string conteudo)
    { 
        materia = conteudo;
    }

    public void horarioEstudo(double horas)
    {
        horario = horas;
    }

    public void atividadeEstudo(bool resolvido)
    {
        atividade = resolvido;
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
            Aprender segunda = new Aprender();
        segunda.materiaEstudo("Animação 2D");
        Debug.Log(segunda.materia);
            Aprender terca = new Aprender();
        terca.materiaEstudo("Química");
        Debug.Log(terca.materia);
            Aprender quarta = new Aprender();
        quarta.materiaEstudo("POO e motores");
        Debug.Log(quarta.materia);
            Aprender quinta = new Aprender();
        quinta.materiaEstudo("Matemática");
        Debug.Log(quinta.materia);
            Aprender sexta = new Aprender();
        sexta.materiaEstudo("Inglês");
        Debug.Log(sexta.materia);

        
            Aprender acordar = new Aprender();
        acordar.horarioEstudo(7.30);
        Debug.Log(acordar.horario);
            Aprender chegar = new Aprender();
        chegar.horarioEstudo(20.30);
        Debug.Log(chegar.horario);
        
        Aprender AtvResolvida = new Aprender();
        AtvResolvida.atividadeEstudo(false);
        if (AtvResolvida)
        {
            atividadeEstudo(true);
        }
        Debug.Log(atividade);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
