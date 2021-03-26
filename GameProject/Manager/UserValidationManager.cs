using GameProject.Entity;
using GameProject.Service;
using System;
using System.Collections.Generic;
using System.Text;
using TcKimlikNoDogrulama;

namespace GameProject.Manager
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Player player)
        {
            //KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            //return client.TCKimlikNoDogrulaAsync(player.IdentityNumber, player.FirstName.ToUpper(), player.LastName.ToUpper(), player.BirthYear).Result.Body.TCKimlikNoDogrulaResult;

            if (player.BirthYear == 1991 && player.FirstName == "EMRAH" && player.LastName == "RAMAZAN" && player.IdentityNumber == 11111111111)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
