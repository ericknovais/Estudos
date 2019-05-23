using System;

public class Aluno1
{
    private int _matricula;
    public int Matricula
    {
        get { return this._matricula; }
        set { this._matricula = value; }
    }

    private string _nome;
    public string Nome
    {
        get { return this._nome; }
        set { this._nome = value; }
    }

    public Aluno1(int matricula, string nome)
    {
        this._matricula = matricula;
        this._nome = nome;
    }

    public Aluno1()
    {
        this._matricula = 0;
        this._nome = "Sem nome";
    }

    

    //public Aluno(int matricula, string nome)
    //{
    //    this._matricula = matricula;
    //    this._nome = nome;
    //}
}

