using System;
using System.Data;
using System.Data.SqlClient;

class LoginBanco
{   SqlDataAdapter da;
    SqlDataReader dr;
    string strSql;
	string path = @"Server=localhost\SQLEXPRESS;Database=GestãoDeClientes;Trusted_Connection=True;";
	SqlConnection conexao;
    SqlCommand comando;
    public void Inserir(string strSQL)
    {   
        try
        {        
            conexao = new SqlConnection(path);
            comando = new SqlCommand(strSQL,conexao);
            conexao.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
        finally
        {
            conexao.Close();
            conexao = null;
            comando = null;
        }
    }
    public void Consultar(string strSql,DataGridView dgvDados)
    {
        try
        {
			conexao = new SqlConnection(path);
			DataSet ds = new DataSet();
			da = new SqlDataAdapter(strSql, conexao);
			conexao.Open();
			da.Fill(ds);
            dgvDados.DataSource = ds.Tables[0];           
		}
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
        finally
        {
            conexao.Close();
        }
	}
    public void Deletar(string strSql)
    {
        try
        {
			conexao = new SqlConnection(path);
			comando = new SqlCommand(strSql, conexao);
			conexao.Open();
			comando.ExecuteNonQuery();
            MessageBox.Show("Excluído com sucesso!");
		}
        catch (Exception e)
        {
            MessageBox.Show(e.Message);
        }
	    finally
        { 
            conexao.Close(); 
        }
	}
    public void Editar(string strSql)
    {
		try
		{
			conexao = new SqlConnection(path);
			comando = new SqlCommand(strSql, conexao);
			conexao.Open();
			comando.ExecuteNonQuery();
			MessageBox.Show("Cadastro atualizado com sucesso!");
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);

		}
		finally
		{
			conexao.Close();
			conexao = null;
			comando = null;
		}
	}
    public int RetornaID(string strSql)
    {
        int id;
		conexao = new SqlConnection(path);
		comando = new SqlCommand(strSql, conexao);
		conexao.Open();
        dr= comando.ExecuteReader();
        while(dr.Read())
        {
            id = Convert.ToInt32(dr["id"]);
            return id;
		}
        return-1;
	}
    public bool VerificaCPF(string cpf)
    {
        string strSql;

        strSql = $"SELECT COUNT(1) FROM Clientes WHERE cpf = '{cpf}'";
        conexao= new SqlConnection(path);
        comando = new SqlCommand(strSql, conexao);
        conexao.Open();

        var result = comando.ExecuteScalar();
        if (result != null)
        {
            return (int)result > 0;
        }
        else
        {
            return false;
        }
    }
}
