Dependency Injection Example

Bu proje, Dependency Injection (DI) prensibini göstermek için basit bir C# Console App örneğidir.
Amaç, Teacher nesnesini ClassRoom sınıfına Constructor Injection ile enjekte ederek bağımlılıkların nasıl yönetileceğini göstermektir.

📂 Proje Yapısı
DependencyInjectionExample/
│
├── Models/
│   ├── ITeacher.cs     # Soyutlama (interface)
│   ├── Teacher.cs      # Somut Teacher sınıfı
│
├── ClassRoom.cs        # Teacher bağımlılığı DI ile alınıyor
├── Program.cs          # Uygulamanın başlangıç noktası
└── README.md           # Proje açıklaması

✨ Kullanılan Teknolojiler

.NET 6.0 / .NET 7.0

C# (Console Application)

🧩 Sınıflar ve Görevleri

ITeacher → Öğretmenin bilgisini döndüren bir arayüz.

Teacher → ITeacher implementasyonu. Öğretmenin adını ve soyadını tutar.

ClassRoom → Constructor aracılığıyla ITeacher bağımlılığını alır ve öğretmen bilgisini gösterir.

🚀 Çalıştırma

Projeyi derlemek ve çalıştırmak için:

Visual Studio

Projeyi aç.

Ctrl + F5 ile çalıştır.

CLI
dotnet run

📌 Örnek Çıktı
Teacher: Berk Dağdelen

🔍 Öğrenme Notları

Dependency Injection, bir sınıfın ihtiyaç duyduğu nesneleri kendi içinde oluşturmaması, dışarıdan verilmesi demektir.

Bu sayede:

Kod daha esnek olur.

Test etmek kolaylaşır (mock/fake kullanılabilir).

Bağımlılıklar yönetilebilir hale gelir.
