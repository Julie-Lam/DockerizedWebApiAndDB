using DockerizedWebApiAndDB.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DockerizedWebApiAndDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : Controller
    {
        // GET: ContactController
        [HttpGet]
        public List<Contact> Get()
        {

            //var contacts = new List<Contact>()
            //{
            //    new Contact() {Name = "James Bond", PhoneNumber = "007"}, 
            //    new Contact() {Name = "John Smith", PhoneNumber = "123"}
            //};

            var contacts = new List<Contact>();

            using (var connection = new SqlConnection(@"Data Source=localhost;Initial Catalog=SocialNetwork;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False"))
            {
                connection.Open();


                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = @"SELECT * FROM Contact";

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var contact = new Contact();
                        contact.Name = reader.GetString("Name");
                        contact.PhoneNumber = reader.GetString("PhoneNumber"); 

                        contacts.Add(contact);
                    }
                }
            }

            return contacts;

        }





        //// POST: ContactController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


    }
}
