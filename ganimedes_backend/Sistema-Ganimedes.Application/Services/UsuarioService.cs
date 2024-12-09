﻿using Sistema_Ganimedes.Application.Interfaces;
using Sistema_Ganimedes.Domain.Entities;
using Sistema_Ganimedes.Domain.Enums;
using Sistema_Ganimedes.Infrastructure.Interfaces;


namespace Sistema_Ganimedes.Application.Services
{
    public class UsuarioService : IUsuarioService
    {

        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool RegistraAluno(Aluno aluno)
        {
            try
            {
                var rowsAffected = _usuarioRepository.CadastrarAluno(aluno);

                return rowsAffected > 0;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool RegistraUsuario(Usuario usuario)
        {
            try
            {
                var rowsAffected = _usuarioRepository.CadastrarUsuario(usuario);

                return rowsAffected > 0;

            }catch(Exception)
            {
                throw;
            }
        }

        public bool ChecaSeUsuarioExiste(string nUsp)
        {
            Usuario? usuario = _usuarioRepository.GetUsuario(nUsp);

            if (usuario is not null)
            {
                return true;
            }

            return false;

        }

        public bool ChecaSeUsuarioEDoTipoFornecido(string nUsp, TipoUsuario tipoUsuario)
        {
            Usuario? usuario = _usuarioRepository.GetUsuario(nUsp);

            if (usuario.tipoUsuario != tipoUsuario)
                return false;

            return true;

        }
    }
}