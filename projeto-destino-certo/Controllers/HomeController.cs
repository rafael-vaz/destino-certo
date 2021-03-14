using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using projeto_destino_certo.Models;
using Microsoft.AspNetCore.Http;

namespace projeto_destino_certo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        
        /****************************************CONTROLLER INDEX *******************************************/
        
        public IActionResult Index()
        {
            return View();
        }
        
         /**************************************CONTROLLERS USUÁRIOS*******************************************/
        
        /*CADASTRO DE USUÁRIOS*/
         public IActionResult Cadastro()
        {   
            
            if(HttpContext.Session.GetString("conta") == "colaborador")
            return RedirectToAction("Login");
            
            return View();
        }

        [HttpPost]  
         public IActionResult Cadastro(Usuario user)
        {   
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert(user);
            ViewBag.Cadastro = "Usuário cadastrado com sucesso!";
            return View();
        }

        /*LISTAGEM DE USUÁRIOS*/      
        public IActionResult Listar_Usuarios()
        {   
            if(HttpContext.Session.GetInt32("id_usuarios") == null)
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("conta") == "colaborador")
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("conta") == "usuario")
            return RedirectToAction("Login");
            
            UsuarioRepository ur = new UsuarioRepository();
            List<Usuario> listagem = ur.Listar_Usuarios();
            return View(listagem);
        }

        /*ALTERAÇÃO DE USUÁRIOS*/    
        [HttpGet]
         public IActionResult Alterar_Usuario(int id)
        {   
            UsuarioRepository ur = new UsuarioRepository();
            
            Usuario user = ur.RetornoUsuario(id);
        
            return View(user);
        }

        [HttpPost]
        public IActionResult Alterar_Usuario(Usuario usuario)
        {  

            UsuarioRepository ur = new UsuarioRepository();
            
            ur.Alterar(usuario);
             
            return RedirectToAction("Listar_Usuarios"); 
            
        }

        /*EXCLUSÃO DE USUÁRIOS*/ 
        [HttpGet]
        public IActionResult Excluir_Usuario(int id){

            UsuarioRepository ur = new UsuarioRepository();
            ur.Excluir(id);
            return RedirectToAction("Listar_Usuarios");
        }


        /***********************************CONTROLLERS PACOTES*****************************************/

        /*PACOTES*/
        public IActionResult Pacotes()
        {  
            
            if(HttpContext.Session.GetInt32("id_usuarios") == null)
            return RedirectToAction("Login");
            
            UsuarioRepository ur = new UsuarioRepository();
            List<Pacotes> pacotes = ur.Listar_Pacotes();
            return View(pacotes);
        }
        
        /*REGISTRO DE PACOTES*/
        public IActionResult Registro_Pacotes()
        {   
            if(HttpContext.Session.GetInt32("id_usuarios") == null)
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("conta") == "usuario")
            return RedirectToAction("Login");
            
            return View();
        }

        [HttpPost]  
         public IActionResult Registro_Pacotes(Pacotes pacote)
        {   
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert_Pacotes(pacote);
            ViewBag.Cadastro = "Pacote registrado com sucesso!";
            return View();
        }
        
        /*LISTAGEM DE PACOTES*/
         public IActionResult Listar_Pacotes(){
          
          if(HttpContext.Session.GetInt32("id_usuarios") == null)
            return RedirectToAction("Login");

            if(HttpContext.Session.GetString("conta") == "usuario")
            return RedirectToAction("Login");
          
          UsuarioRepository ur = new UsuarioRepository();
          
          List<Pacotes> listagem = ur.Listar_Pacotes();
          
          return View(listagem);

        }

        /*ALTERAÇÃO DE PACOTES*/
         [HttpGet]
        public IActionResult Alterar_Pacote(int id){
            
            UsuarioRepository ur = new UsuarioRepository();
            
            Pacotes p = ur.RetornoPacote(id);
        
            return View(p);
        }

         [HttpPost]
        public IActionResult Alterar_Pacote(Pacotes pacote){
         
         UsuarioRepository ur = new UsuarioRepository();
            
            ur.Alterar_P(pacote);
             
            return RedirectToAction("Listar_Pacotes");
        }

        /*EXCLUSÃO DE PACOTES*/
        [HttpGet]
        public IActionResult Excluir_Pacotes(int id){

            UsuarioRepository ur = new UsuarioRepository();

            ur.Excluir_P(id);
            
            return RedirectToAction("Pacotes");
        }
        
        [HttpGet]
        public IActionResult Excluir_Pacote(int id){

            UsuarioRepository ur = new UsuarioRepository();

            ur.Excluir_P(id);
            
            return RedirectToAction("Listar_Pacotes");
        }

        /**********************************CONTROLLERS ATENDIMENTO***********************************/

        /*ATENDIMENTO*/
         public IActionResult Atendimento()
        {   
             if(HttpContext.Session.GetInt32("id_usuarios") == null)
            return RedirectToAction("Login");
            
            return View();
        }
        
        [HttpPost]
        public IActionResult Atendimento(Atendimento a){
            
            UsuarioRepository ur = new UsuarioRepository();
            ur.Insert_Atendimento(a);
            
            ViewBag.Atendimento = "A sua dúvida foi enviada com sucesso!";
            return View();
        }

        /********************************LOGIN********************************************/   
         public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
          public IActionResult Login(Usuario user)
        {   
            UsuarioRepository ur = new UsuarioRepository();
            Usuario usuario = ur.Login(user); 
            
            if(usuario != null){
            
            HttpContext.Session.SetInt32("id_usuarios", usuario.id);
            HttpContext.Session.SetString("nome", usuario.nome);
            HttpContext.Session.SetString("conta", usuario.conta);

            ViewBag.Sucesso = "Login realizado com sucesso!";
            
            } else{

                ViewBag.Sucesso = "Falha no login!";
            }
            return View();
        }

        /***************************************Logout*********************************************/

        public IActionResult Logout(){

            HttpContext.Session.Clear();

            return View("Index");
        }

    }
}