
        Console.WriteLine("Tatil planlama uygulamamıza hoş geldiniz!\n");
        //Gidilebilecek lokasyonlardaki paket fiyatlarını ve ulaşım seçenekleri fiyatlarını tanımladık.
        int bodrumFiyat = 4000;
        int marmarisFiyat = 3000;
        int cesmeFiyat = 5000;
        int karaYoluFiyat = 1500;
        int havaYoluFiyat = 4000;

        bool devam = true;
        //Kullanıcı birden fazla tatil planı yapmak isterse diye koyduğumuz döngü. E durumunda başa dönüyor.
        while (devam)
        {
            Console.WriteLine("Tatil Lokasyonları ve Paket Fiyatları:");
            Console.WriteLine("- Bodrum (Paket başlangıç fiyatı: 4000 TL)");
            Console.WriteLine("- Marmaris (Paket başlangıç fiyatı: 3000 TL)");
            Console.WriteLine("- Çeşme (Paket başlangıç fiyatı: 5000 TL)\n");
            string lokasyon; //lokasyon, fiyat değişkenlerini tanımladık.
            int fiyat;
            

            while (true) //kullanıcıdan lokasyon bilgisi alacak döngü
            {
                Console.WriteLine("Lütfen tatil yapmak istediğiniz lokasyonu giriniz: Bodrum, Marmaris, Çeşme");
                lokasyon = Console.ReadLine().Trim().ToLower(); //büyük küçük harf farkı için tolower kullanıldı.

                if (lokasyon == "bodrum") //bodrum seçilirse bilgilendirme mesajı veriliyor.
                {
                    fiyat = bodrumFiyat;
                    Console.WriteLine("Bodrum'un eşsiz plajlarında yüzebilir, tarihi ve doğal güzelliklerini keşfedebilirsiniz!");
                    break;
                }
                else if (lokasyon == "marmaris") //marmaris seçilirse bilgilendirme mesajı veriliyor.
        {
                    fiyat = marmarisFiyat;
                    Console.WriteLine("Marmaris'te gündüzleri mükemmel plajlarda güneşlenirken akşamları ise hareketli gece hayatına katılabilirsiniz!");
                    break;
                }
                else if (lokasyon == "çeşme") //çeşme seçilirse bilgilendirme mesajı veriliyor.
        {
                    fiyat = cesmeFiyat;
                    Console.WriteLine("Çeşme'de rüzgar sörfü yapabilir, etraftaki tarihi ve doğal güzellikleri keşfetme şansı yakalayabilirsiniz!");
                    break;
                }
                else //seçenekler dışında lokasyon girilişi yapılırsa yazılacak hata mesajı 
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sadece Bodrum, Marmaris ya da Çeşme seçeneklerinden birini giriniz.\n");
                }
            }


            int kisiSayisi; //kişi sayısı için değişken tanımladık.
                            //Kullanıcıdan kişi sayısı alınır. Sayı değilse ya da 0'dan küçükse tekrar istenir.
            Console.WriteLine("\nKaç kişilik bir tatil planlıyorsunuz?"); 
            while (!int.TryParse(Console.ReadLine(), out kisiSayisi) || kisiSayisi <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir sayı giriniz:");
            }

            Console.WriteLine("\nUlaşım Seçenekleri:");
            Console.WriteLine("1 - Kara yolu (Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL)");
            Console.WriteLine("2 - Hava yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n");

            int ulasimSecim; //ulaşım seçimi ve ücreti değişkenleri
            int ulasimFiyati;
            while (true)
            {
                Console.Write("Ulaşım tercihinizi giriniz (1 - Kara Yolu, 2 - Hava Yolu): ");
                if (int.TryParse(Console.ReadLine(), out ulasimSecim) && (ulasimSecim == 1 || ulasimSecim == 2)) //kullanıcının girdiği değerin 1 ya da 2 olup olmadığını okur
                {
                    if (ulasimSecim == 1) //karayolu seçimi için
                    {
                        ulasimFiyati = karaYoluFiyat;
                    }
                    else //havayolu seçimi için
                    {
                        ulasimFiyati = havaYoluFiyat;
                    }
                    break;
                }
                else //1 ya da 2den farklı değer yazıldıysa
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sadece 1 ya da 2 seçeneklerinden birini giriniz.\n");
                }
            }

            int toplamTutar = fiyat + (kisiSayisi * ulasimFiyati); //toplam tatil fiyatını hesaplama 
            Console.WriteLine($"\nToplam Tutar: Paket ({fiyat} TL x {kisiSayisi}) + Ulaşım ({ulasimFiyati} TL x {kisiSayisi}) = {toplamTutar} TL\n");

            Console.Write("Başka bir tatil planlamak ister misiniz? (E/H): "); //kullanıcıya devam etmek isteyip istemediğini soruyoruz.
            string cevap = Console.ReadLine().Trim().ToUpper();
            if (cevap != "E") //cevap e değilse uygulama sonlanır.
            {
                devam = false;
                Console.WriteLine("\nİyi günler dileriz!");
            }
        }













