using System;
using System.Collections.Generic;
using MySqlConnector;
using Microsoft.AspNetCore.Http;
namespace projeto_destino_certo.Models
{
    public class UsuarioRepository
    {   
        /*ENDEREÇO DE CONEXÃO*/
        private const  string enderecoConexao = "Database=destinocerto; Datasource=localhost; Username=root;";

    
    /**************************************USUÁRIOS**************************************************/
    
    /*CADASTRAR USUÁRIOS*/
    public void Insert(Usuario user){
                  
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlInsert = "INSERT INTO usuarios (nome, login, data_nascimento, senha, conta) VALUES (@nome, @login, @data_nascimento, @senha, @conta)";

    MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

    comando.Parameters.AddWithValue("@nome", user.nome);
    comando.Parameters.AddWithValue("@login", user.login);
    comando.Parameters.AddWithValue("@data_nascimento", user.data_nascimento);
    comando.Parameters.AddWithValue("@senha", user.senha);
    comando.Parameters.AddWithValue("@conta", user.conta);

    comando.ExecuteNonQuery();

    conexao.Close();
    
    }

    /*LISTAR USUÁRIOS*/
    public List<Usuario> Listar_Usuarios(){

        MySqlConnection conexao = new MySqlConnection(enderecoConexao);

        conexao.Open();

        string sqlList = "SELECT * FROM usuarios ORDER BY nome";

        MySqlCommand comando = new MySqlCommand(sqlList, conexao);

        MySqlDataReader dados = comando.ExecuteReader();

        List<Usuario> lista = new List<Usuario>();
        
        while(dados.Read()){
        
        Usuario usuario = new Usuario();

        usuario.id = dados.GetInt32("id_usuarios");

        if(!dados.IsDBNull(dados.GetOrdinal("nome")))
        usuario.nome = dados.GetString("nome");

        if(!dados.IsDBNull(dados.GetOrdinal("data_nascimento")))
        usuario.data_nascimento = dados.GetString("data_nascimento");

        if(!dados.IsDBNull(dados.GetOrdinal("senha")))
        usuario.senha = dados.GetString("senha");

        if(!dados.IsDBNull(dados.GetOrdinal("login")))
        usuario.login = dados.GetString("login");

        if(!dados.IsDBNull(dados.GetOrdinal("conta")))
        usuario.conta = dados.GetString("conta");

        lista.Add(usuario);

        }
        
        conexao.Close();
        return lista;
    }

    /*ALTERAR USUÁRIOS*/ 
    public void Alterar(Usuario user){

    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlUpdate = "UPDATE usuarios set nome = @nome, data_nascimento = @data_nascimento, login = @login, senha = @senha WHERE id_usuarios = @id";        
    
    MySqlCommand comando = new MySqlCommand(sqlUpdate, conexao);

    comando.Parameters.AddWithValue("@id", user.id);
    comando.Parameters.AddWithValue("@nome", user.nome);
    comando.Parameters.AddWithValue("@data_nascimento", user.data_nascimento);
    comando.Parameters.AddWithValue("@login", user.login);
    comando.Parameters.AddWithValue("@senha", user.senha);
    
    comando.ExecuteNonQuery();
    
    conexao.Close();       
    }

    /*EXCLUIR USUÁRIOS*/
     public void Excluir(int id){
    
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);
    
    conexao.Open();

    string sqlDelete = "DELETE FROM usuarios WHERE id_usuarios = @id";

    MySqlCommand comando = new MySqlCommand(sqlDelete, conexao);

    comando.Parameters.AddWithValue("@id", id);

    comando.ExecuteNonQuery();

    conexao.Close();  
    }

    /*RETORNO DE USUÁRIO*/
     public Usuario RetornoUsuario(int id){
    
    int id_user = id;
    
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlConsulta = "SELECT * FROM usuarios WHERE id_usuarios = @id";

    MySqlCommand comando = new MySqlCommand(sqlConsulta, conexao);

    comando.Parameters.AddWithValue("@id", id_user);
    
    MySqlDataReader dados = comando.ExecuteReader();

    dados.Read();

    Usuario usuario  = new Usuario();

    usuario.id = dados.GetInt32("id_usuarios");
    
    if(!dados.IsDBNull(dados.GetOrdinal("nome")))
    usuario.nome = dados.GetString("nome");

    if(!dados.IsDBNull(dados.GetOrdinal("data_nascimento")))
    usuario.data_nascimento = dados.GetString("data_nascimento");

    if(!dados.IsDBNull(dados.GetOrdinal("login")))
    usuario.login = dados.GetString("login");

    if(!dados.IsDBNull(dados.GetOrdinal("senha")))
    usuario.senha = dados.GetString("senha");

    conexao.Close();
    return usuario;
    
    }


    /**************************************PACOTES***********************************************/
     
    /*CADASTRO DE PACOTES*/
    public void Insert_Pacotes(Pacotes pacote){
                  
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlInsert = "INSERT INTO pacotes (nome, origem, destino, saida, retorno, preco, id_usuarios) VALUES (@nome, @origem, @destino, @saida, @retorno, @preco, @usuario)";

    MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

    comando.Parameters.AddWithValue("@nome", pacote.nome);
    comando.Parameters.AddWithValue("@origem", pacote.origem);
    comando.Parameters.AddWithValue("@destino", pacote.destino);
    comando.Parameters.AddWithValue("@saida", pacote.saida);
    comando.Parameters.AddWithValue("@retorno", pacote.retorno);
    comando.Parameters.AddWithValue("@preco", pacote.preco);
    comando.Parameters.AddWithValue("@usuario", pacote.usuario);

    comando.ExecuteNonQuery();

    conexao.Close();
    
    }

    /*LISTAGEM DE PACOTES*/
    public List<Pacotes> Listar_Pacotes(){

        MySqlConnection conexao = new MySqlConnection(enderecoConexao);

        conexao.Open();

        string sqlList = "SELECT * FROM pacotes ORDER BY nome";

        MySqlCommand comando = new MySqlCommand(sqlList, conexao);

        MySqlDataReader dados = comando.ExecuteReader();

        List<Pacotes> lista = new List<Pacotes>();
        
        while(dados.Read()){
        
        Pacotes pacote = new Pacotes();

        pacote.id = dados.GetInt32("id_pacotes");

        if(!dados.IsDBNull(dados.GetOrdinal("nome")))
        pacote.nome = dados.GetString("nome");

        if(!dados.IsDBNull(dados.GetOrdinal("origem")))
        pacote.origem = dados.GetString("origem");

        if(!dados.IsDBNull(dados.GetOrdinal("destino")))
        pacote.destino = dados.GetString("destino");

        if(!dados.IsDBNull(dados.GetOrdinal("saida")))
        pacote.saida = dados.GetString("saida");

        if(!dados.IsDBNull(dados.GetOrdinal("retorno")))
        pacote.retorno = dados.GetString("retorno");

        if(!dados.IsDBNull(dados.GetOrdinal("preco")))
        pacote.preco = dados.GetDouble("preco");

        if(!dados.IsDBNull(dados.GetOrdinal("id_usuarios")))
        pacote.usuario = dados.GetInt32("id_usuarios");

        lista.Add(pacote);

        }
        
        conexao.Close();
        return lista;
    }

    /*ALTERAÇÃO DE PACOTES*/
     public void Alterar_P(Pacotes p){

    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlUpdate = "UPDATE pacotes set nome = @nome, origem = @origem, destino = @destino, saida = @saida, retorno = @retorno, preco = @preco WHERE id_pacotes = @id";        
    
    MySqlCommand comando = new MySqlCommand(sqlUpdate, conexao);

    comando.Parameters.AddWithValue("@id", p.id);
    comando.Parameters.AddWithValue("@nome", p.nome);
    comando.Parameters.AddWithValue("@origem", p.origem);
    comando.Parameters.AddWithValue("@destino", p.destino);
    comando.Parameters.AddWithValue("@saida", p.saida);
    comando.Parameters.AddWithValue("@retorno", p.retorno);
    comando.Parameters.AddWithValue("@preco", p.preco);
    
    comando.ExecuteNonQuery();
    
    conexao.Close();       
    }

    /*EXCLUSÃO DE PACOTES*/
     public void Excluir_P(int id){

        MySqlConnection conexao = new MySqlConnection(enderecoConexao);

        conexao.Open();

        string sqlDelete = "DELETE FROM pacotes WHERE id_pacotes = @id";

        MySqlCommand comando = new MySqlCommand(sqlDelete, conexao);

        comando.Parameters.AddWithValue("@id", id);

        comando.ExecuteNonQuery();

        conexao.Close();
    }
    
    /*RETORNO DE PACOTES*/
    public Pacotes RetornoPacote(int id){
    
    int id_pacote = id;
    
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlConsulta = "SELECT * FROM pacotes WHERE id_pacotes = @id";

    MySqlCommand comando = new MySqlCommand(sqlConsulta, conexao);

    comando.Parameters.AddWithValue("@id", id_pacote);
    
    MySqlDataReader dados = comando.ExecuteReader();

    dados.Read();

    Pacotes pacote = new Pacotes();

    pacote.id = dados.GetInt32("id_pacotes");
    
    if(!dados.IsDBNull(dados.GetOrdinal("nome")))
    pacote.nome = dados.GetString("nome");

    if(!dados.IsDBNull(dados.GetOrdinal("origem")))
    pacote.origem = dados.GetString("origem");

    if(!dados.IsDBNull(dados.GetOrdinal("destino")))
    pacote.destino = dados.GetString("destino");

    if(!dados.IsDBNull(dados.GetOrdinal("saida")))
    pacote.saida = dados.GetString("saida");

    if(!dados.IsDBNull(dados.GetOrdinal("retorno")))
    pacote.retorno = dados.GetString("retorno");
    
    if(!dados.IsDBNull(dados.GetOrdinal("preco")))
    pacote.preco = dados.GetDouble("preco");

    conexao.Close();
    return pacote; 
    }

    /**********************************************ATENDIMENTO*********************************************/
    
    /*REGISTRO DE ATENDIMENTO*/
    public void Insert_Atendimento(Atendimento a){
                  
    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlInsert = "INSERT INTO atendimento (nome, email, duvida) VALUES (@nome, @email, @duvida)";

    MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);

    comando.Parameters.AddWithValue("@nome", a.nome);
    comando.Parameters.AddWithValue("@email", a.email);
    comando.Parameters.AddWithValue("@duvida", a.duvida);

    comando.ExecuteNonQuery();

    conexao.Close();
    
    }


    /********************************************LOGIN************************************************************/

    public Usuario Login(Usuario user){

    MySqlConnection conexao = new MySqlConnection(enderecoConexao);

    conexao.Open();

    string sqlLogin = "SELECT * FROM usuarios WHERE login = @login AND senha = @senha";

    MySqlCommand comando = new MySqlCommand(sqlLogin, conexao);

    comando.Parameters.AddWithValue("@login", user.login);
    comando.Parameters.AddWithValue("@senha", user.senha);

    MySqlDataReader dados = comando.ExecuteReader();

    Usuario us = null;

    if(dados.Read()){
        
        us = new Usuario();
        us.id = dados.GetInt32("id_usuarios");
        
        if(!dados.IsDBNull(dados.GetOrdinal("login")))
        us.login = dados.GetString("login");

        if(!dados.IsDBNull(dados.GetOrdinal("senha")))
        us.senha = dados.GetString("senha");

        if(!dados.IsDBNull(dados.GetOrdinal("conta")))
        us.conta = dados.GetString("conta");

         if(!dados.IsDBNull(dados.GetOrdinal("nome")))
        us.nome = dados.GetString("nome");
    }

    conexao.Close();
    return us;

    }



    
 }
}