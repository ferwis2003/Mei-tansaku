﻿using AutoMapper;
using Core.Application.Dtos;
using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.Mapper
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<PreviewCategoryDTO, Category>()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedDate, opt => opt.Ignore())
                .ForMember(x => x.Products, opt => opt.Ignore())
                .ForMember(x => x.Attribute_Categories, opt => opt.Ignore())
                .ReverseMap();
            CreateMap<PreviewProductItemDTO, Product>()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedDate, opt => opt.Ignore())
                .ForMember(x => x.State, opt => opt.Ignore())
                .ForMember(x => x.Private, opt => opt.Ignore())
                .ForMember(x => x.Stock, opt => opt.Ignore())
                .ForMember(x => x.StateID, opt => opt.Ignore())
                .ForMember(x => x.Address, opt => opt.Ignore())
                .ForMember(x => x.Availability, opt => opt.Ignore())
                .ForMember(x => x.Category, opt => opt.Ignore())
                .ForMember(x => x.CategoryID, opt => opt.Ignore())
                .ForMember(x => x.Chats, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore())
                .ForMember(x => x.Private, opt => opt.Ignore())
                .ForMember(x => x.Product_Lists, opt => opt.Ignore())
                .ForMember(x => x.Purchaseds, opt => opt.Ignore())
                .ForMember(x => x.Weight, opt => opt.Ignore())
                .ForMember(x => x.SellerID, opt => opt.Ignore())
                .ForMember(x => x.Tickets, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProductsByCategoryDTO,Category>()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedDate, opt => opt.Ignore())
                .ForMember(x => x.Attribute_Categories, opt => opt.Ignore())
                .ReverseMap();


            CreateMap<ProductResponseDTO, Product>()
                .ForMember(x => x.CreatedBy, opt => opt.Ignore())
                .ForMember(x => x.CreatedDate, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedBy, opt => opt.Ignore())
                .ForMember(x => x.LastUpdatedDate, opt => opt.Ignore())
                .ForMember(x => x.Chats, opt => opt.Ignore())
                .ForMember(x => x.Product_Applications, opt => opt.Ignore())
                .ForMember(x => x.Product_Lists, opt => opt.Ignore())
                .ForMember(x => x.SellerID, opt => opt.Ignore())
                .ForMember(x => x.StateID, opt => opt.Ignore())
                .ForMember(x => x.State, opt => opt.Ignore())
                .ForMember(x => x.Purchaseds, opt => opt.Ignore())
                .ForMember(x => x.CategoryID, opt => opt.Ignore())
                .ForMember(x => x.Category, opt => opt.Ignore())
                .ForMember(x => x.Private, opt => opt.Ignore())
                .ForMember(x => x.Tickets, opt => opt.Ignore())
                .ForMember(x => x.Comments, opt => opt.Ignore())
                .ForMember(x => x.Product_Ratings, opt => opt.Ignore())
                .ForMember(x => x.Product_Images, opt => opt.Ignore())
                .ReverseMap();





        }

    }
}
