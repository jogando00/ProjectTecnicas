using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectTecnicas.Models;
using System.Data.SqlClient;


namespace ProjectTecnicas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private SqlConnection _connection;

        public HomeController(ILogger<HomeController> logger, IDatabaseSettings settings)
        {
            _logger = logger;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = settings.ConnectionString;

            _connection = new SqlConnection(builder.ConnectionString);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Route("/[controller]/Estudiante/{id?}")]
        public IActionResult Student(string id)
        {
            //Open connection
            _connection.Open();

            string sql = $"select top(1) * from users where un_id =  '{id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            User student = new User();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    student.id = reader.GetValue(0).ToString();
                    student.un_id = reader.GetValue(1).ToString();
                    student.name = reader.GetValue(2).ToString();
                    student.password = reader.GetValue(3).ToString();
                    student.status = reader.GetValue(4).ToString();
                    student.type = reader.GetValue(5).ToString();
                }
            }

            ViewBag.student = student;

            //Define command
            sql = $"select t1.*, t2.name as class_name, t2.credit from user_class t1 join classes t2 on t1.class_id = t2.id where user_id = '{student.id}' and t1.status = 1 and t2.status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            List<UserClasses> user_l = new List<UserClasses>();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserClasses user = new UserClasses();
                    user.id = reader.GetValue(0).ToString();
                    user.user_id = reader.GetValue(1).ToString();
                    user.class_id = reader.GetValue(2).ToString();
                    user.grade = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.class_name = reader.GetValue(5).ToString();
                    user.credit = reader.GetValue(6).ToString();
                    user_l.Add(user);
                }
            }

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            ViewBag.classes = user_l;

            return View();
        }

        [Route("/[controller]/Profesor/{id?}")]
        public IActionResult Teacher(string id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"select top(1) * from users where un_id =  '{id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            User teacher = new User();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    teacher.id = reader.GetValue(0).ToString();
                    teacher.un_id = reader.GetValue(1).ToString();
                    teacher.name = reader.GetValue(2).ToString();
                    teacher.password = reader.GetValue(3).ToString();
                    teacher.status = reader.GetValue(4).ToString();
                    teacher.type = reader.GetValue(5).ToString();
                }
            }

            ViewBag.teacher = teacher;


            sql = $"select * from classes where status = 1 and professor = '{teacher.name}'";
            sqlQuery = new SqlCommand(sql, _connection);

            List<Class> t_classes = new List<Class>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    Class class_o = new Class();
                    class_o.id = reader.GetValue(0).ToString();
                    class_o.name = reader.GetValue(1).ToString();
                    class_o.professor = reader.GetValue(2).ToString();
                    class_o.status = reader.GetValue(3).ToString();
                    class_o.credit = reader.GetValue(4).ToString();

                    t_classes.Add(class_o);
                }
            }

            ViewBag.t_classes = t_classes;

            return View();
        }

        [Route("/searchStudentsGrade")]
        public ActionResult<List<User>> searchStudentsGrade(string id)
        {
            _connection.Open();

            //Define command
            string sql = $"select * from user_class t1 join users t2 on t2.id = t1.user_id where t2.status = 1 and t1.class_id = '{id}' and t1.status = 1";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            List<User> user_l = new List<User>();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.id = reader.GetValue(5).ToString();
                    user.un_id = reader.GetValue(6).ToString();
                    user.name = reader.GetValue(7).ToString();
                    user.password = reader.GetValue(8).ToString();
                    user.status = reader.GetValue(9).ToString();
                    user.type = reader.GetValue(10).ToString();
                    user.grade = reader.GetValue(3).ToString();
                    user_l.Add(user);
                }
            }

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return user_l;
        }

        [Route("/gradeStudent")]
        public void gradeStudent(string user_id, string class_id, string grade)
        {
            _connection.Open();

            //Define command
            string sql = $"update user_class set grade = '{grade}' where user_id = '{user_id}' and class_id = '{class_id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            sqlQuery.ExecuteNonQuery();

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

        }

        [Route("/[controller]/Administrador/{id?}")]
        public IActionResult Admin()
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"select * from users";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            List<User> user_l = new List<User>();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.id = reader.GetValue(0).ToString();
                    user.un_id = reader.GetValue(1).ToString();
                    user.name = reader.GetValue(2).ToString();
                    user.password = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.type = reader.GetValue(5).ToString();
                    user_l.Add(user);
                }
            }

            ViewBag.users = user_l;

            sql = $"select * from users where status = 1 and type = 'Profesor'";
            sqlQuery = new SqlCommand(sql, _connection);

            List<User> professor_l = new List<User>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.id = reader.GetValue(0).ToString();
                    user.un_id = reader.GetValue(1).ToString();
                    user.name = reader.GetValue(2).ToString();
                    user.password = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.type = reader.GetValue(5).ToString();
                    professor_l.Add(user);
                }
            }

            ViewBag.professors = professor_l;

            sql = $"select * from classes where status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            List<Class> classes_l = new List<Class>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    Class class_o = new Class();
                    class_o.id = reader.GetValue(0).ToString();
                    class_o.name = reader.GetValue(1).ToString();
                    class_o.professor = reader.GetValue(2).ToString();
                    class_o.status = reader.GetValue(3).ToString();
                    class_o.credit = reader.GetValue(4).ToString();
                    classes_l.Add(class_o);
                }
            }

            ViewBag.classes = classes_l;

            return View();
        }

        [Route("/Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/checkLogin")]
        public ActionResult<string> checkLogin(string user_id, string password)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"select top(1) * from users where un_id = '{user_id}' and password = '{password}' and status = 1";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            User user = new User();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read()) { 
                    user.id = reader.GetValue(0).ToString();
                    user.un_id = reader.GetValue(1).ToString();
                    user.name = reader.GetValue(2).ToString();
                    user.password = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.type = reader.GetValue(5).ToString();
                }
            }

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            //Return data
            if (user.id == null)
            {     
                return "not found";
            }
            else
            {
                return user.type;
            }
        }

        [HttpPost]
        [Route("/registerUser")]
        public void registerUser(User user)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"insert into users(un_id, name, password, status, type) values('{user.un_id}', '{user.name}', '{user.password}', 0 ,'{user.type}')";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Execute
            sqlQuery.ExecuteNonQuery();

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();
        }

        [HttpPost]
        [Route("/deleteClass")]
        public ActionResult<List<Class>> deleteClass(string id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"update classes set status = 0 where id = '{id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Execute
            sqlQuery.ExecuteNonQuery();

            sql = $"select * from classes where status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            List<Class> classes_l = new List<Class>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    Class class_o = new Class();
                    class_o.id = reader.GetValue(0).ToString();
                    class_o.name = reader.GetValue(2).ToString();
                    class_o.professor = reader.GetValue(3).ToString();
                    classes_l.Add(class_o);
                }
            }
            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return classes_l;
        }

        [HttpPost]
        [Route("/addClass")]
        public ActionResult<List<Class>> addClass(Class class_o)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"insert into classes(name, professor, status, credit) values('{class_o.name}', '{class_o.professor}', '1', '{class_o.credit}')";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Execute
            sqlQuery.ExecuteNonQuery();

            sql = $"select * from classes where status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            List<Class> classes_l = new List<Class>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    Class class_oi = new Class();
                    class_oi.id = reader.GetValue(0).ToString();
                    class_oi.name = reader.GetValue(1).ToString();
                    class_oi.professor = reader.GetValue(2).ToString();
                    class_oi.status = reader.GetValue(3).ToString();
                    classes_l.Add(class_o);
                }
            }
            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return classes_l;
        }

        [HttpPost]
        [Route("/updateUser")]
        public ActionResult<List<User>> updateUser(string id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"update users set status = status-1 where id = '{id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            sqlQuery.ExecuteNonQuery();

             sql = $"select * from users";
             sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            List<User> user_l = new List<User>();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    User user = new User();
                    user.id = reader.GetValue(0).ToString();
                    user.un_id = reader.GetValue(1).ToString();
                    user.name = reader.GetValue(2).ToString();
                    user.password = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.type = reader.GetValue(5).ToString();
                    user_l.Add(user);
                }
            }

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return user_l;
        }

        [HttpPost]
        [Route("/getUserClasses")]
        public ActionResult<List<UserClasses>> getUserClasses(string id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"select t1.*, t2.name as class_name from user_class t1 join classes t2 on t1.class_id = t2.id where user_id = '{id}' and t1.status = 1 and t2.status = 1";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Declare List
            List<UserClasses> user_l = new List<UserClasses>();

            //Get data into list
            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserClasses user = new UserClasses();
                    user.id = reader.GetValue(0).ToString();
                    user.user_id = reader.GetValue(1).ToString();
                    user.class_id = reader.GetValue(2).ToString();
                    user.grade = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.class_name = reader.GetValue(5).ToString();
                    user_l.Add(user);
                }
            }

            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return user_l;
        }

        [HttpPost]
        [Route("/addClassUser")]
        public ActionResult<List<UserClasses>> addClassUser(string class_id, string user_id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"insert into user_class(user_id, class_id, status) values('{user_id}', '{class_id}', '1')";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Execute
            sqlQuery.ExecuteNonQuery();

            sql = $"select t1.*, t2.name as class_name from user_class t1 join classes t2 on t1.class_id = t2.id where user_id = '{user_id}' and t1.status = 1 and t2.status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            List<UserClasses> classes_l = new List<UserClasses>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserClasses user = new UserClasses();
                    user.id = reader.GetValue(0).ToString();
                    user.user_id = reader.GetValue(1).ToString();
                    user.class_id = reader.GetValue(2).ToString();
                    user.grade = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.class_name = reader.GetValue(5).ToString();
                    classes_l.Add(user);
                }
            }
            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return classes_l;
        }

        [HttpPost]
        [Route("/deleteClassUser")]
        public ActionResult<List<UserClasses>> deleteClassUser(string class_id, string user_id)
        {
            //Open connection
            _connection.Open();

            //Define command
            string sql = $"update user_class set status = 0 where user_id = '{user_id}' and class_id = '{class_id}'";
            SqlCommand sqlQuery = new SqlCommand(sql, _connection);

            //Execute
            sqlQuery.ExecuteNonQuery();

            sql = $"select t1.*, t2.name as class_name from user_class t1 join classes t2 on t1.class_id = t2.id where user_id = '{user_id}' and t1.status = 1 and t2.status = 1";
            sqlQuery = new SqlCommand(sql, _connection);

            List<UserClasses> classes_l = new List<UserClasses>();

            using (var reader = sqlQuery.ExecuteReader())
            {
                while (reader.Read())
                {
                    UserClasses user = new UserClasses();
                    user.id = reader.GetValue(0).ToString();
                    user.user_id = reader.GetValue(1).ToString();
                    user.class_id = reader.GetValue(2).ToString();
                    user.grade = reader.GetValue(3).ToString();
                    user.status = reader.GetValue(4).ToString();
                    user.class_name = reader.GetValue(5).ToString();
                    classes_l.Add(user);
                }
            }
            //Close connection
            sqlQuery.Dispose();
            _connection.Close();

            return classes_l;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
