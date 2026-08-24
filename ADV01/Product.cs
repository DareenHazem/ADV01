using System;
using System.Collections.Generic;
using System.Text;

namespace ADV01
{
    internal class Product
    {
        public int Id {  get; set; }
        public Product()
        {
            Id= default;
        }

        public override string ToString()
        {
            return $"------ The new constaint id: {Id}";
        }
    }
}
