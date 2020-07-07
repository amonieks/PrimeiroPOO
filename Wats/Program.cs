using System;
using System.Collections.Generic;

namespace Wats
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            Contato c1 = new Contato("Tonho","(011) 22224 2222");
            Contato c2 = new Contato("Zeca","(011) 23253 2222");
            Contato c3 = new Contato("Jota","(011) 67676 2222");
        
        List<Contato> lista = new List<Contato>();

        agenda.Cadastrar(c1);

        agenda.Excluir(c2);

        foreach(Contato c in agenda.Listar()){
            Console.WriteLine($"Nome: {c.Nome} - Tel: {c.Telefone}");
        }
        Mensagem msg = new Mensagem();
        msg.Destinatario = c3;
        msg.Texto = "Alo" + msg.Destinatario.Nome + "!";
        Console.WriteLine( msg.Enviar() );
        }
    }
}
