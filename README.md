# XMLCurrencyData

Projede MSSQL veritabanı kullanıldı. Veritabanının otomatik olarak oluşması için Code-First yaklaşımı kullanıldı.

Projeyi çalıştırmadan önce ilk olarak ConsoleApp, Models ve Repository katmanlarında app.config dosyası,
MVCApp projesinde ise web.config dosyasında bulunan connectionString bilgilerini projenin çalıştırılacağı bilgisayarda bulunan 
MSSQL bağlantı bilgileri ile güncellenmesi gerekiyor.

Proje çalıştırıldığında başlangıç projesi olarak ConsoleApp projesi çalıştırılıyor ve TCMB XML adresi üzerinden kur verileri çekiliyor.
Kur verileri 5 dakikalık aralıklar ile çekilerek oluşturulan veritabanına kaydediliyor.

Projede MVCAspp projesi Set as StartUp Project yapılarak başlangıç projesi seçildikten sonra proje tekrar çalıştırıldığında karşımıza
veritabanına kaydedilen kur bilgileri geliyor. Kur bilgisi yanında bulunan düzenle butonu ile kur bilgisi düzenlenebiliyor.

