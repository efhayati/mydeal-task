﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.Domain.Users;

public class User : BaseEntity
{
    public string Email { get; set; }

    public string Password { get; set; }

}

