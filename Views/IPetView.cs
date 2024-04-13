using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SuperCRUDWinFormsMVP.Views
{
    public interface IPetView
    {
        //definindo as propriedades do pet view
        string PetId { get; set; }
        string PetNome { get; set; }
        string PetTipo { get; set; }
        string PetCor {  get; set; }

        string ProcurarValor { get; set; } 
        //definimos outras propriedades para procurar o
        //valor, editar estado e operação bem sucedida
        bool Editar { get; set; }
        bool BemSucedido { get; set; }
        string Menssagem { get; set; }

        //adicionar eventos para operações do usuario, por exemplo:
        //eventos de procurar, adicionar, editar, salvar mudanças e cancelar ao clicar em um botão
        event EventHandler ProcurarEvent;
        event EventHandler NovoEvent;
        event EventHandler EditarEvent;
        event EventHandler DeletarEvent;
        event EventHandler SalvarEvent;
        event EventHandler CancelarEvent;

        //Metodos ou funções
        void SetListaPetBindingSource(BindingSource listaPet); //classa pertencente ao windows forms
        void Show(); //opcional
    }
}
