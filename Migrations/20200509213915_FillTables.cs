﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Tobacco_Shop.Migrations
{
    public partial class FillTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) VALUES('National','Tobacco produced within the country by our farmers')");
            migrationBuilder.Sql("INSERT INTO Category(CategoryName, Description) VALUES('Imported','Tobacco imported from the best farmers in the world')");
            
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='National'), 'This old classic, Escudo Navy Deluxe, is a popular Perique/Va. curly cut tobacco in large coin size.', 'Escudo, our only entry under the A & C Petersen brand, was not originally blended by the Petersens, nor is it now, but A & C Petersen is the name most associated with the tobacco', 1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-001-0001.jpg', 'https://c647068.ssl.cf2.rackcdn.com/products/003-001-0001.jpg', 0, 'Escudo Navy Deluxe', 12.50)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='National'), 'Artisan`s Blend by Ashton is a full-bodied English mixture is carefully crafted for the experienced pipe smoker.',' Virginia and Turkish tobaccos harmonize with Latakia and a touch of Perique to create a taste that is resoundingly rich, spicy, and satisfying.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-004-0012.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-004-0012.jpg', 0 ,'Ashton: Artisans Blend', 32.20)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='National'), 'A medium-to-full-bodied smoke',' A medium-to-full-bodied smoke, Brebbias Balkan combines Kentucky, Latakia, Orientals, and Perique for a rich, well-rounded after dinner blend.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-008-0012.1511.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-008-0012.1511.jpg', 1 ,'Brebbia: Balkan', 42.73)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='National'), 'A simple as can be, Captain Black dark is a blend of straight, pure, 100% black Cavendish aromatic, providing plenty of flavor and sweetness','Captain Black dark is a blend of straight, pure, 100% black Cavendish aromatic, providing plenty of flavor and sweetness, though with a fuller body as well, thanks to the use of Green River Burley as one of the source leafs involved in the creation of its Cavendish components.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-537-0013.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-537-0013.jpg', 0 ,'Captain Black: Dark', 36.30)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='Imported'), 'The Borkum Riff blends are a line of aromatic Cavendish concoctions that enjoy an immensely widespread popularity the world over',' Curiously enough, the Black Cavendish blend actually contains less Cavendish than the Original (approx 50% versus 60%, respectively), but there you have it',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-536-0008.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-536-0008.jpg', 1 ,'Borkum Riff: Original', 42.50)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='Imported'), 'An elegant & captivating pipe tobacco comprised of select choice leaf, E Hoffmans Distinguished Gentleman is gently fragrant with an intoxicating aroma.',' An elegant & captivating pipe tobacco comprised of select choice leaf, E Hoffmans Distinguished Gentleman is gently fragrant with an intoxicating aroma.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-399-0003.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-399-0003.jpg', 0 ,'E. Hoffman Company', 12.30)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='Imported'), 'Like the more mellow-bodied Capstan Yellow, Capstan Blue was originally created by W.D. & H.O. Wills of Bristol well over a century ago.',' Its remained a favorite to countless pipe smokers across generations (J.R.R. Tolkien having been on of its most noted aficionados), a testament to the quality of this fine Virginia flake.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-581-0002.2788.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-581-0002.2788.jpg', 1 ,'Capstan: Flake Blue', 62.20)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='Imported'), 'Subtle notes of vanilla and a combination of golden Virginias gives Mac Barens 7 Seas Gold a mellow and smooth taste and a pleasing aroma.','Subtle notes of vanilla and a combination of golden Virginias gives Mac Barens 7 Seas Gold a mellow and smooth taste and a pleasing aroma.',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-039-0064.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-039-0064.jpg', 0 ,'Mac Baren: 7 Seas Gold', 22.70)");
            migrationBuilder.Sql("INSERT INTO Tobaccos(CategoryId, ShortDescription, LongDescription, Available, ImageThumbnailUrl, ImageURL, IsTobaccoBest, Name, Price) VALUES((SELECT CategoryId from Category WHERE CategoryName='Imported'), 'Originally concocted back in the 19th century by American Tobacco, Half and Half remains one of the most widely popular blends in the US','Originally concocted back in the 19th century by American Tobacco, Half and Half remains one of the most widely popular blends in the US',1, 'https://c647068.ssl.cf2.rackcdn.com/products/003-535-0002.2627.jpg','https://c647068.ssl.cf2.rackcdn.com/products/003-535-0002.2627.jpg', 1 ,'Half and Half', 45.50)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Category");
            migrationBuilder.Sql("DELETE FROM Tobaccos");
        }
    }
}
