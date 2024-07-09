using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
namespace API_Demo.Views.Client
{
    public class IndexModel : PageModel
    {
        public List<ClientInfo> listClient = new List<ClientInfo>; 
        public void OnGet()
        {
            try
            {
                String connectionString = "Server=localhost;Database=Client;Trusted_Connection=True;MultipleActiveResultSets=true"
            }
        }
        public class ClientInfo()
        {
            public String id;
            public String name;
            public String email;
            public String phone;
            public String address;
        }
    }
}
