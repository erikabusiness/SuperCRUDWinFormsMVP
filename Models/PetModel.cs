using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel; // esse namespace permite provide atributos de classes
                             // que são usados para definir metadados que permitem validação de 
                             //um ou mais atributos

namespace SuperCRUDWinFormsMVP.Models
{
    public class PetModel
    {
        //fields, anemic model, nós não vamos implementar interface pois iremos implementar aqui apenas lógicas de negócio.
        //Faremos operações de leitura e escrevendo dados
        //regra de negocio sempre em portugês e a parte de lógica em inglês

        private int id;
        private string nome;
        private string tipo;
        private string cor;
        //encapsulei os campos

        //propriedades - validações
        //nos vamos colocar validações para não permitir valores nulos
        //vamos usar validadores anotations de dados e adicionar uma referencia

        [DisplayName("ID do Pet")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Nomde do Pet")]
        [Required(ErrorMessage = "O nome do pet é requerido")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="O nome do pet deve ter entre 3 e 50 caracteres")]
        public string Nome { get => nome; set => nome = value; }

        [DisplayName("Tipo do pet")]
        [Required(ErrorMessage = "O nome do pet deve ter entre 3 e 50 caracteres")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="O tipo do pet deve ter entre 3 e 50 caracteres")]
        public string Tipo { get => tipo; set => tipo = value; }

        [DisplayName("Cor do pet")]
        [Required(ErrorMessage = "Está faltando a cor do pet")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "O tipo do pet deve ter entre 3 e 50 caracteres")]
        public string Cor { get => cor; set => cor = value; }
    }
}
