using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Relampago
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnIngresar_Click(object sender, EventArgs e)
        {

            // Response.Redirect("inicioUsuario.aspx");

           
        }

        protected void BtnIngresar_Click1(object sender, EventArgs e)
        {
           
        }

        protected void BtnIngresar_Click2(object sender, EventArgs e)
        {
            try
            {
                if (tbuser.Text.Equals("") || tbpass.Text.Equals(""))
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                        "MsgAlert", "alert('Ingrese los datos solicitados');window.location ='index.aspx';", true);
                }
                else
                {
                    int user = Int32.Parse(tbuser.Text);
                    string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                    SqlConnection sqlConectar = new SqlConnection(conectar);
                    SqlCommand cmd = new SqlCommand("SP_ValidarUsuario", sqlConectar)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Connection.Open();
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = user;
                    cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 20).Value = tbpass.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Session["asset"] = user;
                        Response.Redirect("inicioUsuario.aspx");
                    }
                    else
                    {
                        ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                            "MsgAlert", "alert('Usuario no valido');window.location ='index.aspx';", true);
                    }
                }
            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                    "MsgAlert", "alert('No hay conexión');window.location ='index.aspx';", true);
            }
        }
    }
}