﻿using Datos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPFinalNivel3
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            UsuarioDatos datos = new UsuarioDatos();
            Usuario usuario = new Usuario();
            try
            {
                usuario.Email = txtCorreo.Text;
                usuario.Contraseña = txtContraseña.Text;
                if (datos.login(usuario))
                {
                    Session.Add("usuario", usuario);
                    Response.Redirect("Perfil.aspx", false);
                } else
                {
                    Session.Add("error", "Correo Electrónico o contraseña incorrectos.");
                    Response.Redirect("Error.aspx", false);
                }
            }
            catch (Exception ex)
            {

                Session.Add("error", ex);
                Response.Redirect("Error.aspx", false);
            }
        }
    }
}