using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;



namespace Plataforma_de_banca_digital.Application.Pass
{
    public class PasswordService
    {
        public static string HashPass(string password)
        {

           return BCrypt.Net.BCrypt.HashPassword(password);
  

        }

        public static bool Verificar(string password, string hashedPassword) {

            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
