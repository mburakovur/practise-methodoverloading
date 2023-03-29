// See https://aka.ms/new-console-template for more information
 string sayi = "999";
            int outSayi;
           bool sonuc= int.TryParse(sayi, out  outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız ");
            }
            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplam);
            Console.WriteLine(toplam);

            //metotlara Aşırı Yükleme
            int ifade = 999;
            
            instance.EkranaYazdır(ifade);
            instance.EkranaYazdır("Oğuzhan", "ULUUĞUR");
            //metot imzası metotadı + parametre sayısı+ parametre tipi

        
        class Metotlar
        {
            public void  Topla(int a, int b,out int toplam)
            {
                toplam = a + b;
            }
            public void EkranaYazdır(string veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(int veri)
            {
                Console.WriteLine(veri);
            }
            public void EkranaYazdır(string veri1,string veri2)
            {
                Console.WriteLine(veri1 + veri2);
            }
        }
