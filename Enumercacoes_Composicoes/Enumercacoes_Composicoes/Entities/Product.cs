﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enumercacoes_Composicoes.Entities
{
    class Product
    {
        public string Name { get; set; }
        public Product()
        {
        }

        public Product(string name)
        {
            Name = name;
        }
    }
}
