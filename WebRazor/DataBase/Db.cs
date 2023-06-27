using WebRazor.Model;

namespace WebRazor.DataBase
{
    public static class Db
    {
        public static List<User> users =
        new List<User>()
          {
              new User()
              {
                  Id = 1,
                  Name = "tayeb",
                  Family = "moradi",
                  PhoneNumber = "09304328557",
             
              },
              new User()
              {
                  Id = 2,
                  Name = "mohamad",
                  Family = "moradi",
                  PhoneNumber = "09373129685",
              
              },
              new User()
              {
                  Id = 3,
                  Name = "Farshad",
                  Family = "Rahnama",
                  PhoneNumber = "09173619952",
                
              }
          };
    }
}
