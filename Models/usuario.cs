namespace exemplo.Models
{
    public class Usuario
    {
        public string Nome { get; set; }

        public string Email { get; set; }

        protected string Senha { get; set; }
        
        public virtual void Logar(){
            
        }
    }
}