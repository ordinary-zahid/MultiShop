using AutoMapper;
using Core.Entities;
using Microsoft.Extensions.Configuration;

namespace API.Helpers
{
   public class ProductUrlResolver : IValueResolver<Product, Product, string>
    {
        
        private readonly IConfiguration _config;
        public ProductUrlResolver(IConfiguration config)
        {
            _config = config;
        }

        public string Resolve(Product source, Product destination, string destMember, ResolutionContext context)
        {
           if(!string.IsNullOrEmpty(source.ImageUrl)){

               return _config["ApiUrl"] + source.ImageUrl; 
           }
           return null;
        }

    }
}