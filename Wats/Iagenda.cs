using System.Collections.Generic;

namespace Wats
{
    public interface Iagenda
    {
        
         void Cadastrar (Contato cont);

         void Excluir(Contato cont);

         List<Contato> Listar();
    }

    
}