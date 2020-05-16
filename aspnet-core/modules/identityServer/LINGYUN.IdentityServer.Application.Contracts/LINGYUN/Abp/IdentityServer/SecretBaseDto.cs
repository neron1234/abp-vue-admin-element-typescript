﻿using System;
using Volo.Abp.Application.Dtos;

namespace LINGYUN.Abp.IdentityServer
{
    public abstract class SecretBaseDto : EntityDto
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public DateTime? Expiration { get; set; }
    }
}
