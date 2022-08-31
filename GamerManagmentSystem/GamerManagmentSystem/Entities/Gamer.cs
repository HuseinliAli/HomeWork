﻿using GamerManagmentSystem.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerManagmentSystem.Entities
{
    public class Gamer : IEntity
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string NationalityID { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
