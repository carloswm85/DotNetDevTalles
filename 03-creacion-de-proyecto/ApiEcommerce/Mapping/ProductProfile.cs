using System;
using ApiEcommerce.Models;
using ApiEcommerce.Models.Dtos;
using AutoMapper;

namespace ApiEcommerce.Mapping;

public class ProductProfile : Profile
{
	public ProductProfile()
	{
		CreateMap<Product, ProductDto>()
			.ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
			.ReverseMap();

		CreateMap<CreateProductDto, Product>().ReverseMap();
		CreateMap<UpdateProductDto, Product>().ReverseMap();
	}
}
