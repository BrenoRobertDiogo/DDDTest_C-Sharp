using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Validation;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create product with negative Id")]
        public void CreateProduct_WithNegativeId_DomainException()
        {
            Action action = () => new Product(-1, "Produto", "Descrição", 19, 5, "imagem");
            action.Should()
                .Throw<DomainExceptionValidation>();
        }
        [Fact(DisplayName = "Create product with image length higher than maximum")]
        public void CreateProduct_withInvalidLength()
        {
            Action action = () => new Product(1, "Produto", "Descrição", 19, 5, "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            action.Should().Throw<DomainExceptionValidation>();
        }
    }
}
