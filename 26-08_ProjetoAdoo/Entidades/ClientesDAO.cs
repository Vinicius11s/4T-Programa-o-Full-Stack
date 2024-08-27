using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ClientesDAO
    {
        const String conexao = @"data source=LAB11-09;initial catalog=AulaADO;integrated security=true";

        public void inserir(Clientes obj) //pegar dados dos textbox pelo obj, abrir conec com o banco e iserir nele
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open(); //abrir conexao

            //comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into clientes (nome, datanascimento)" +
                              "values (@nome, @datanascimento)"; //nao manda id pq auto encrementa

            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = obj.nome ;

            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime).Value = obj.datanascimento;
            
            cmd.ExecuteNonQuery();//executar

            con.Close(); //fechar conexao
        }

        public void alterar(Clientes obj)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open(); //abrir conexao

            //comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "update clientes set nome = @nome ,)" +
                               " datanascimento = @datanascimento where id = @id"; 
            cmd.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = obj.nome;

            cmd.Parameters.Add("@datanascimento", System.Data.SqlDbType.DateTime).Value = obj.datanascimento;

            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = obj.id;

            cmd.ExecuteNonQuery();//executar

            con.Close(); //fechar conexao
        }

        public void excluir(Clientes obj)
        {
            SqlConnection con = new SqlConnection(conexao);
            con.Open(); //abrir conexao

            //comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "delete from clientes where id = @id)";

            cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = obj.id;

            cmd.ExecuteNonQuery();//executar

            con.Close(); //fechar conexao
        }


        public Clientes consultar(int id)
        {
            Clientes obj = null;

            SqlConnection con = new SqlConnection(conexao);
            con.Open(); //abrir conexao

            //comando
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from clientes " +
                              "where id = @nome)";

            cmd.Parameters.Add("@id", Syst)

            SqlDataReader = cmd.ExecuteReader();
            if (dr.Read())
            {
                //encontrou dados

                obj = new Clientes();
                obj.id = int.Parse(dr["id"].To.String());
                obj.nome = dr["nome"].ToString();
                obj.datanascimento = DateTime.Parse(dr["datanascimento"].To.String());




            }

            dr.Close();
            con.Close();
            return obj;
        }
    }
}
