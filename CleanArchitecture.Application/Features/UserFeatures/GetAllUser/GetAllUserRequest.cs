﻿using CleanArchitecture.Application.Features.UserFeatures.CreateUser;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Features.UserFeatures.GetAllUser
{
    public  class GetAllUserRequest
    {
        public string Email { get; set; }
        public string Name { get; set; }
    }

}
