﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos;
namespace TPFinalNivel3
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				ArticuloDatos datos = new ArticuloDatos();
				repRepiter.DataSource = datos.Listar();
				repRepiter.DataBind();
			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}