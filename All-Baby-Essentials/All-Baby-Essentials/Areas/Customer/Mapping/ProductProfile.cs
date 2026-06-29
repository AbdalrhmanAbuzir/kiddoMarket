using AutoMapper;
using All_Baby_Essentials.Models;
using All_Baby_Essentials.Areas.Customer.ViewModels;

namespace All_Baby_Essentials.Mapping
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDetailsVM>()
                .ForMember(d => d.CategoryName,
                    o => o.MapFrom(s => s.Category.Name));

            CreateMap<ProductImage, ProductImageVM>();

            CreateMap<ProductReview, ProductReviewVM>()
                .ForMember(d => d.UserName,
                    o => o.MapFrom(s => s.User.UserName))
                .ForMember(d => d.UserFullName,
                    o => o.MapFrom(s => s.User.FullName));
        }
    }
}
