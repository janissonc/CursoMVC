using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTeste
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<DbSet<Context>> _mockContext;
        private readonly Categoria _categoria;

        public CategoriaControllerTest() 
        {
            _mockSet = new Mock<DbSet<Categoria>>();
            _mockContext = new Mock<DbSet<Context>>();
            _categoria = new Categoria { id = 1 , description = "teste description"};

            //_mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);
            //_mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);
        }

        [Fact]
        public async Task Get_Categoria() 
        {
            //var services = new CategoriasController(_mockContext.Object);

            //await services.GetCategoria(1);

            _mockSet.Verify(m => m.FindAsync(1),Times.Once());
        }
    }
}
