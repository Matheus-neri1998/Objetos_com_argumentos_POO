namespace Objetos_com_argumentos_POO.Classes
{
    public class Produto
    {
        // Criamos os atributos da classe
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }


        // Primeiro método construtor
        public Produto(){

        }

        // Segundo método construtor
        public Produto(int code, string name, float price){
            Codigo = code;
            Nome = name;
            Preco = price;
            
        }
        
    }
}