using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Service
{
    interface IUserValidationService
    {
        bool Validate(Player player);
    }
}
