# 2. Hafta Ödev 1

> Extension Geliştirin

- Datetime tipine bir extension geliştirin.
- Verilen Datetime ın o anki tarihe ne kadar yakın olduğunu text olarak dönsün.
- Örn: 
 `var date = Datetime.Now();
  Console.Writeline(date.Ago());
  --- 2 gün 3 saat 4 dakika önce
 `
 
> Attribute ve Reflection Kullanımı

- Amaç veritabanı tablosu olacak şekilde bir mapping işlemi yapılacak. Db tablosuna karşılık bir class gelecek ve oluşturulan bu class dan attributeler yardımı ile veritabanı tablosunu oluşturucak script çıkarılacaktır. Burada sql verinin doğruluğu önemli değildir.`tablo adı:Öğrenci --- kolonları id tipi int zorunlu` gibi bir çıktı yeterli olacaktır.
- iki tane attribute geliştirin. Biri Table diğeri Column
- Table, class üzerine tanımlanabilsin ve parametre olarak ad (string değer) alabilsin. Türkçe, özel karakterler içermesin
- Column, property ler üzerine tanımlansın, parametre olarak ad, tip ve zorunluluk değeri alsın.
- Oluşturulan class dan scripti çıkarak kodu yazın

> SOLID kavramı

- Dependency inversion prensibini, interface segregation ile birlikte kullanın ve .net in kendi dependency injection frameworkü ile basit bir örnek yapın.
- Kodun çalışabilirliği değil daha çok kullanımı, tasarımı önemlidir.

 
 
 
