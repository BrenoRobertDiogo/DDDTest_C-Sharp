﻿using CleanArchMvc.Domain.Entities;
using MediatR;

namespace CleanArchMvc.WebUI.Products.Commands
{
    public class ProductRemoveCommand : IRequest<Product>
    {
        public int Id { get; set; }
        public ProductRemoveCommand(int id)
        {
            Id = id;
        }
    }
}
