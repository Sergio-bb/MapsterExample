using Mapster;
using Newtonsoft.Json;

namespace TestMapster
{
    [AdaptTo("UserDto"), GenerateMapper]
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string WebSite { get; set; }
        public List<User> GetUsers()
        {
            StreamReader r = new StreamReader("users.json");
            string jsonString = r.ReadToEnd();
            var  m = JsonConvert.DeserializeObject<List<User>>(jsonString);
            return m;
        }
    }
}
