using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Com_Website.Data.Models
{
    public class DbInitializer
    {
        public static void Seed(IServiceProvider applicationBuilder)
        {
            AppDbContext context =
               applicationBuilder.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Products.Any())
            {
                context.AddRange
                (
                    new Product
                    {
                        Name = "D&G Shirt",
                        Price = 799.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://www.designerchildrenswear.com/images/dolce-gabbana-t-shirt-white-p80641-159897_image.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.designerchildrenswear.com/images/dolce-gabbana-t-shirt-white-p80641-159897_image.jpg"
                    },
                    new Product
                    {
                        Name = "Distressed Shirt",
                        Price = 499.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://ae01.alicdn.com/kf/HTB1xV7uPpXXXXbPXXXXq6xXFXXXE/Women-Girl-Casual-Hip-pop-Hole-Ripped-Distressed-T-shirt-Tees-Street-Tops.jpg_640x640.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://ae01.alicdn.com/kf/HTB1xV7uPpXXXXbPXXXXq6xXFXXXE/Women-Girl-Casual-Hip-pop-Hole-Ripped-Distressed-T-shirt-Tees-Street-Tops.jpg_640x640.jpg"
                    },
                    new Product
                    {
                        Name = "Striped Shorts",
                        Price = 229.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSC6sL4cbhfotvF9vayw-P2ufLRQpwRH-veUkyysxkIXpIMtejp",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSC6sL4cbhfotvF9vayw-P2ufLRQpwRH-veUkyysxkIXpIMtejp"
                    },
                    new Product
                    {
                        Name = "Elagant Crop Top",
                        Price = 669.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://assets.bigcartel.com/product_images/247531580/WHITE-UD_mockup_Front_Flat_Black.png?auto=format&fit=max&w=1200",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://assets.bigcartel.com/product_images/247531580/WHITE-UD_mockup_Front_Flat_Black.png?auto=format&fit=max&w=1200"
                    },
                    new Product
                    {
                        Name = "ME! Sweater",
                        Price = 699.95M,
                        ShortDescription = " ",
                        Category = Categories["Tops"],
                        LongDescription = "",
                        ImageUrl = "https://i.pinimg.com/236x/78/9d/b7/789db7d6e02c2829e1a70e6502a191eb.jpg",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://i.pinimg.com/236x/78/9d/b7/789db7d6e02c2829e1a70e6502a191eb.jpg"
                    },
                    new Product
                    {
                        Name = "Rare Hoodie",
                        Price = 649.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://cdn.shopify.com/s/files/1/0101/5755/5790/products/TieHoodie_0021eb58-e54c-4dec-b712-c1a66c19612c_1024x.png?v=1578685954",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://cdn.shopify.com/s/files/1/0101/5755/5790/products/TieHoodie_0021eb58-e54c-4dec-b712-c1a66c19612c_1024x.png?v=1578685954"
                    },
                    new Product
                    {
                        Name = "Galaxy Skirt",
                        Price = 459.99M,
                        ShortDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://i5.walmartimages.com/asr/5d09d862-084c-4e3c-b0ab-57353fdedc01_1.66649d3687f5062a3b29c1a1240fe5e1.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://i5.walmartimages.com/asr/5d09d862-084c-4e3c-b0ab-57353fdedc01_1.66649d3687f5062a3b29c1a1240fe5e1.jpeg?odnHeight=450&odnWidth=450&odnBg=ffffff"
                    },
                    new Product
                    {
                        Name = "Distressed Jeans",
                        Price = 259.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://www.geri.co.za/wp-content/uploads/PT05-Distressed-Jeans-with-Contrast-Stitching-Front.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.geri.co.za/wp-content/uploads/PT05-Distressed-Jeans-with-Contrast-Stitching-Front.jpg"
                    },
                    new Product
                    {
                        Name = "Button Up Skirt",
                        Price = 529.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://images-na.ssl-images-amazon.com/images/I/514AD6vVseL._UX385_.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://images-na.ssl-images-amazon.com/images/I/514AD6vVseL._UX385_.jpg"
                    },
                    new Product
                    {
                        Name = "Tie Die Hoodie",
                        Price = 699.89M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://images.rewardstyle.com/img?v=1&width=256&height=256&crop&p=97f24ff7879c123c0515ea638014c2cc",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://images.rewardstyle.com/img?v=1&width=256&height=256&crop&p=97f24ff7879c123c0515ea638014c2cc"
                    },
                    new Product
                    {
                        Name = "Pink Shorts",
                        Price = 289.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://zeus.ph/__resources/webdata/images/product_gallery/11349_3156.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://zeus.ph/__resources/webdata/images/product_gallery/11349_3156.jpg"
                    },
                    new Product
                    {
                        Name = "Pink Hoodie",
                        Price = 589.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://www.childrensalonoutlet.com/media/catalog/product/cache/0/small_image/256x256/9df78eab33525d08d6e5fb8d27136e95/m/s/msgm-girls-cropped-sweatshirt-244184-cb3479a027982d34cc6dc429dea39704d5a0bfd1.jpg",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://www.childrensalonoutlet.com/media/catalog/product/cache/0/small_image/256x256/9df78eab33525d08d6e5fb8d27136e95/m/s/msgm-girls-cropped-sweatshirt-244184-cb3479a027982d34cc6dc429dea39704d5a0bfd1.jpg"
                    },
                    new Product
                    {
                        Name = "Rugby Shorts",
                        Price = 259.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://awerbuchs.co.za/image/cache/catalog/Awerbuchs%20images/shorts/Javlin/salty%20kids%20shorts%20NB-1000x1000.JPG",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://awerbuchs.co.za/image/cache/catalog/Awerbuchs%20images/shorts/Javlin/salty%20kids%20shorts%20NB-1000x1000.JPG"
                    },
                    new Product
                    {
                        Name = "Palm Tree Shorts",
                        Price = 569.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://www.decisive-beachwear.com/wp-content/uploads/2017/12/Swim-Shorts-Palms.png",
                        InStock = true,
                        IsPreferredProduct = true,
                        ImageThumbnailUrl = "https://www.decisive-beachwear.com/wp-content/uploads/2017/12/Swim-Shorts-Palms.png"
                    },
                    new Product
                    {
                        Name = "Blue Shorts",
                        Price = 549.95M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Bottoms"],
                        ImageUrl = "https://eu.patagonia.com/dis/dw/image/v2/ABBM_PRD/on/demandware.static/-/Sites-patagonia-master/default/dwb3cd995f/images/hi-res/24633_BALB.jpg?sw=750&sh=750&sm=fit&sfrm=png",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://eu.patagonia.com/dis/dw/image/v2/ABBM_PRD/on/demandware.static/-/Sites-patagonia-master/default/dwb3cd995f/images/hi-res/24633_BALB.jpg?sw=750&sh=750&sm=fit&sfrm=png"
                    },
                    new Product
                    {
                        Name = "Floral Shirt",
                        Price = 489.99M,
                        ShortDescription = "",
                        LongDescription = "",
                        Category = Categories["Tops"],
                        ImageUrl = "https://i1.adis.ws/i/truworths/prod7141708_1",
                        InStock = true,
                        IsPreferredProduct = false,
                        ImageThumbnailUrl = "https://i1.adis.ws/i/truworths/prod7141708_1"
                    }
                ); ;
            }

            context.SaveChanges();
        }
        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Tops", Description="" },
                        new Category { CategoryName = "Bottoms", Description="" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
