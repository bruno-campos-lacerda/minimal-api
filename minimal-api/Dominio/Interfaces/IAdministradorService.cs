using MinimalApi.Dominio.Entidades;
using MinimalApi.DTOs;

namespace MinimalApi.Dominio.interfaces;

public interface IAdministradorService
{
    Administrador? Login(LoginDTO loginDTO);
}