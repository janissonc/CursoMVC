using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTeste
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<DbSet<Context>> _mockContext;
        private readonly Categoria _categoria;

        public CategoriaControllerTest() { }
    }
}
