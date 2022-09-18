using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Relampago
{
    public partial class registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnRegistrar_Click(object sender, EventArgs e)
        {
           

        }

        protected void BtnRegistrar_Click1(object sender, EventArgs e)
        {
            try
            {
                if (tbuser.Text.Equals("") || tbname.Text.Equals("") || tblastname.Text.Equals("") || tbEmail.Text.Equals("") || tbpass.Text.Equals(""))
                {
                    ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                        "MsgAlert", "alert('Ingrese toda la información solicitada');window.location ='registro.aspx';", true);
                }
                else
                {
                    int user = Int32.Parse(tbuser.Text);
                    string conectar = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                    SqlConnection sqlConectar = new SqlConnection(conectar);
                    SqlCommand cmd = new SqlCommand("SP_IngresarUsario", sqlConectar)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Connection.Open();
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = user;
                    cmd.Parameters.Add("@NOMBRE", SqlDbType.VarChar, 50).Value = tbname.Text;
                    cmd.Parameters.Add("@APELLIDOS", SqlDbType.VarChar, 100).Value = tblastname.Text;
                    cmd.Parameters.Add("@PASS", SqlDbType.VarChar, 100).Value = tbpass.Text;
                    cmd.Parameters.Add("@EMAIL", SqlDbType.VarChar, 50).Value = tbEmail.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                        "MsgAlert", "alert('Usuario registrado con exito');window.location ='index.aspx';", true);
                }

            }
            catch
            {
                ScriptManager.RegisterClientScriptBlock(this, typeof(string),
                    "MsgAlert", "alert('Este usuario ya esta registrado');window.location ='registro.aspx';", true);
            }
        }
    }
}