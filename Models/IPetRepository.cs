using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SuperCRUDWinFormsMVP.Models
{
    //abstração do repositorio
    //Uso de DIP: O DIP propõe que módulos de alto nível (que contêm lógica complexa) não devem depender diretamente de módulos de baixo nível (que fornecem funcionalidades utilitárias).
    //Em vez disso, ambos os módulos devem depender de abstrações.
    //Além disso, as abstrações não devem depender de detalhes, e sim o contrário: os detalhes devem depender das abstrações.
    public interface IPetRepository
    {
        void Adicionar(PetModel petModel);
        void Editar(PetModel petModel);
        void Deletar(int id);
        
        IEnumerable<PetModel> GetAll();
        IEnumerable<PetModel> GetByValue(string value);

        //Os detalhes devem depender das abstrações: a camada de acesso dos dados deve depender do modelo de dominio e não de outra coisa
        //é por isso que definimos essa interface de repositorio e a camada de acesso que serão as unicas implementadas os detalhes.
        //O modelo não dependerá da camada de acesso das interfaces que são mais usadas na maioria das arquiteturas e design patterns
        
    }
}
