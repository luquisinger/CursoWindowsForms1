using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.Databases;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage ="Código do cliente é obrigatório")]
            [RegularExpression("[0-9]+",ErrorMessage ="Código do cliente aceita apenas valores numéricos. ")]
            [StringLength(6, MinimumLength = 6,ErrorMessage = "Código do cliente deve ter 6 dígitos")]
            public  string Id { get; set; }
            [Required(ErrorMessage = "O nome deve ser preenchido")]
            [StringLength(50, ErrorMessage = "O nome pode ter no máximo 50 caracteres")]
            public string Nome { get; set; }
            [StringLength(50, ErrorMessage = "O nome do pai pode ter no máximo 50 caracteres")]
            public string NomePai { get; set; }
            [Required(ErrorMessage = "O nome da mãe deve ser preenchido")]
            [StringLength(50, ErrorMessage = "O nome da mae pode ter no máximo 50 caracteres")]
            public string NomeMae { get; set; }
            public bool NaoTemPai { get; set; }
            [RegularExpression("[0-9]+", ErrorMessage = "O cpf aceita apenas valores numéricos. ")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "O cpf deve ter 11 dígitos")]
            public string Cpf { get; set; }
            [Required(ErrorMessage = "O gênero do cliente é obrigatório")]
            public int Genero { get; set; }
            [Required(ErrorMessage = "O cep do cliente é obrigatório")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "cep deve ter 8 caracteres")]
            [RegularExpression("[0-9]+", ErrorMessage = "O cep aceita apenas valores numéricos. ")]
            public string Cep { get; set; }
            [Required(ErrorMessage = "O logradouro do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "o logradouro pode ter até 50 caracteres")]

            public string Logradouro { get; set; }
            [Required(ErrorMessage = "O complemento do cliente é obrigatório")]
            [StringLength(100, ErrorMessage = "o logradouro pode ter até 100 caracteres")]

            public string Complemento { get; set; }
            [Required(ErrorMessage = "O Bairro do cliente é obrigatório")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "A cidade do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "a cidade pode ter até 50 caracteres")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "O estado do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "O estado pode ter até 50 caracteres")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "O telefone do cliente é obrigatório")]
            [RegularExpression("[0-9]+", ErrorMessage = "O telefone aceita apenas valores numéricos. ")]
            public string Telefone { get; set; }
            public string Profissao { get; set; }
            [Required(ErrorMessage = "a renda é obrigatória")]
            [RegularExpression("[0-9]+", ErrorMessage = "a renda aceita apenas valores numéricos. ")]
            [Range(0, double.MaxValue, ErrorMessage ="A renda deve ser um valor positivo")]
            public Double RendaFamiliar { get; set; }
           public void ValidaClasse()
            {
               
                    ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                    List<ValidationResult> results = new List<ValidationResult>();
                    bool isValid = Validator.TryValidateObject(this, context, results, true);

                    if (isValid == false)
                    {
                        StringBuilder sbrErrors = new StringBuilder();
                        foreach (var validationResult in results)
                        {
                            sbrErrors.AppendLine(validationResult.ErrorMessage);
                        }
                        throw new ValidationException(sbrErrors.ToString());
                    }
                
            }
            public void ValidaComplemento()
            {
                if(this.NomePai == this.NomeMae)
                {
                    throw new Exception("Nome do pai e da mae nao podem ser iguais!");
                }
                if(this.NaoTemPai == false)
                {
                    if (this.NomePai == " ")
                    {
                        throw new Exception("Ñome do pai nao pode esta vazio quando a propriedade pai desconhecido nao estiver marcada");
                    }
                }
                bool ValidaCpf = Cls_Uteis.Valida(this.Cpf);
                if(ValidaCpf == false)
                {
                    throw new Exception("CPF inválido");
                }
            }
            #region "CRUD do Fichario"
            public void IncluirFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(Conexao);
                if (F.status)
                {
                    F.Incluir(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public Unit BuscarFichario(string id, string conexao)
            {
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    string clienteJson = F.Buscar(id);                    
                    return Cliente.DesSerializedClassUnit(clienteJson);
                   
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public void AlterarFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Alterar(this.Id, clienteJson);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }
                    
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public void ApagarFichario( string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    F.Apagar(this.Id);
                    if (!(F.status))
                    {
                        throw new Exception(F.mensagem);
                    }

                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }
            public List<string> ListaFichario(string conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario F = new Fichario(conexao);
                if (F.status)
                {
                    List<string> todosJson = F.BuscarTodos();
                    return todosJson;
                }
                else
                {
                    throw new Exception(F.mensagem);
                }
            }

            #endregion
        }
        public class List
        {
            public List<List> ListUnit { get; set; }
                
        }
        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }
    }
}
