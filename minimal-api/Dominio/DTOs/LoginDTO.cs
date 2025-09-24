namespace MinimalApi.DTOs;
public class LoginDTO
{
    private string email;
    public string Email => email;
    private string senha;
    public string Senha => senha;

    public LoginDTO(string email, string senha)
    {
        this.email = email;
        this.senha = senha;
    }
}