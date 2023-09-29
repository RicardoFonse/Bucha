namespace SenaiAlimentos.Models;

public class Login{  
   public int Id { get; set; }
   public string? Nome { get; set; }

   public string? Email { get; set; }

   public string? Senha { get; set; }

    public Login(string? nome, string? email, string? senha){
         Nome = nome;
         Email = email;
         Senha = senha;
    }
    public Login(){
      
    }
}