

int sayi1 = 10;
int sayi2 = 30;
sayi1 = sayi2;
sayi2 = 65;
//sayi1 ?? 30
//Değer tipler decimal, int, double, boolean , flood
//Değer tiplerde sadece aktardığın değeri direk alır.

int[] sayilar1 = new int[] { 10, 20, 30 };
int[] sayilar2 = new int[] { 100, 200, 300 };
sayilar1 = sayilar2;
sayilar2[0] = 999;
//sayilar1[0] ? 999
//Referans tipler array, interface, class
//new demek bellekte heapte yeni bir adres oluştur demek
//Bir array new lediği zaman bellekte stack kısmından heap kısmına aktarılıyor.
//Sayılar1'in referans numarası eşittir sayılar2'nin referans numarası oluyor artık
//O yüzden cevap 999'dur.




//Bellekte Stack ve Heap olarak 2 alan var.

//Değer tip olanlar stack alanında gerçekleşiyor.



//Referans tip olanlar ise Heap alanında gerçekleşiyor.