﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSystemChallange.Application.Dto.Carrier
{
    public class UpdateCarrierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int PlusDesiCost { get; set; }
    }
}
