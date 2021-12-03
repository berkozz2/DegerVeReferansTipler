

using OOP1;

Product product1 = new Product();

product1.Id = 1;
product1.CategoryId = 2;
product1.ProductName = "Masa";
product1.UnitPrice = 500;
product1.UnitsInStock = 3;
product1.ProductDescription = "Çamdan Masa";

Product product2 = new Product { Id = 2, CategoryId = 3, 
    ProductName = "Laptop", UnitPrice = 2000, UnitsInStock = 10 };

//PascalCase kelimelerin ilk harfi büyük yazılır.
//c# case sensitive'dir. büyük küçük harf duyarlıdır.
ProductManager productManager = new ProductManager();

productManager.Add(product1);

//Deneme yapıldı. Kod okuma açısından
int sayi = 100;
productManager.BiseyYap(sayi);
Console.WriteLine(sayi); //sonucu 100 olarak aldık. 




