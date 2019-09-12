# NET Core

## Przydatne komendy CLI
- ``` dotnet new {template} ``` - utworzenie nowego projektu na podstawie wybranego szablonu
- ``` dotnet new {template} -o {output} ``` - utworzenie nowego projektu w podanym katalogu
- ``` dotnet restore ``` - pobranie bibliotek nuget na podstawie pliku projektu
- ``` dotnet build ``` - kompilacja projektu
- ``` dotnet run ``` - uruchomienie projektu
- ``` dotnet run {app.dll}``` - uruchomienie aplikacji
- ``` dotnet test ``` - uruchomienie testów jednostkowych
- ``` dotnet run watch``` - uruchomienie projektu w trybie śledzenia zmian
- ``` dotnet test ``` - uruchomienie testów jednostkowych w trybie śledzenia zmian
- ``` dotnet add {project.csproj} reference {library.csproj} ``` - dodanie odwołania do biblioteki
- ``` dotnet remove {project.csproj} reference {library.csproj} ``` - usunięcie odwołania do biblioteki
- ``` dotnet new sln ``` - utworzenie nowego rozwiązania
- ``` dotnet sln {solution.sln} add {project.csproj}``` - dodanie projektu do rozwiązania
- ``` dotnet sln {solution.sln} remove {project.csproj}``` - usunięcie projektu z rozwiązania
- ``` dotnet publish -c Release -r {platform}``` - publikacja aplikacji
- ``` dotnet publish -c Release -r win10-x64``` - publikacja aplikacji dla Windows
- ``` dotnet publish -c Release -r linux-x64``` - publikacja aplikacji dla Linux
- ``` dotnet publish -c Release -r osx-x64``` - publikacja aplikacji dla MacOS


# EF Core

## Przydatne komendy CLI
- ``` dotnet ef ``` - weryfikacja instalacji
- ``` dotnet ef migrations add {migration} ``` - utworzenie migracji
- ``` dotnet ef migrations remove ``` - usunięcie ostatniej migracji
- ``` dotnet ef migrations list ``` - wyświetlenie listy wszystkich migracji
- ``` dotnet ef migrations script ``` - wygenerowanie skryptu do aktualizacji bazy danych do najnowszej wersji
- ``` dotnet ef database update ``` - aktualizacja bazy danych do najnowszej wersji
- ``` dotnet ef database update -verbose ``` - aktualizacja bazy danych do najnowszej wersji + wyświetlanie logu
- ``` dotnet ef database update {migration} ``` - aktualizacja bazy danych do podanej migracji
- ``` dotnet ef database drop ``` - usunięcie bazy danych
- ``` dotnet ef dbcontext info ``` - wyświetlenie informacji o DbContext (provider, nazwa bazy danych, źródło)
- ``` dotnet ef dbcontext list ``` - wyświetlenie listy DbContextów
- ``` dotnet ef dbcontext scaffold {connectionstring} Microsoft.EntityFrameworkCore.SqlServer -o Models ``` - wygenerowanie modelu na podstawie bazy danych

## Przydatne polecenia PMC
- ``` Add-Migration {migration} ``` - utworzenie migracji o podanej nazwie
- ``` Remove-Migration ``` - usunięcie ostatniej migracji
- ``` Script-Migration ``` - wygenerowanie skryptu aktualizacji bazy danych do najnowszej wersji
- ``` Script-Migration ``` - wygenerowanie skryptu aktualizacji bazy danych do najnowszej wersji
- ``` Script-Migration {migration} ``` - wygenerowanie skryptu aktualizacji bazy danych od podanej migracji
- ``` Script-Migration 0 {migration} ``` - wygenerowanie skryptu aktualizacji bazy danych od początku do podanej migracji
- ``` Script-Migration {migration} 0 ``` - wygenerowanie skryptu wstecznego aktualizacji bazy danych od podanej migracji do początku
- ``` Update-Database ``` - aktualizacja bazy danych do najnowszej wersji
- ``` Update-Database -verbose ``` - aktualizacja bazy danych do najnowszej wersji + wyświetlanie logu
- ``` Update-Database {migration} ``` - aktualizacja bazy danych do podanej 
- ``` Scaffold-DbContext {connectionstring} Microsoft. Models ``` - wygenerowanie modelu na podstawie bazy danych


## Instalacja EF Core

~~~ bash
dotnet add package Microsoft.EntityFrameworkCore
~~~

## Instalacja dostawcy bazy danych SQL Server
~~~ bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
~~~

### Dostawcy baz danych

| Database | NuGet Package  |
|---|---|
| SQL Server | Microsoft.EntityFrameworkCore.SqlServer |
| SQLite | Microsoft.EntityFrameworkCore.SQLite |
| MySQL | MySql.Data.EntityFrameworkCore |
| PostgreSQL | Npgsql.EntityFrameworkCore.PostgreSQL |
| SQL Compact | EntityFrameworkCore.SqlServerCompact40 |
| In-memory | 	Microsoft.EntityFrameworkCore.InMemory |


## DbContext
Klasa **DbContext** jest główną częścią Entity Framework. Instacja DbContext reprezentuje sesję z bazą danych.

### Funkcje DbContext
 1. Zarządzanie połączeniem z bazą danych
 2. Konfiguracja modelu i relacji
 3. Odpytywanie bazy danych
 4. Zapisywanie danych do bazy danych
 5. Śledzenie zmian
 6. Cache'owanie
 7. Zarządzanie transakcjami

### Właściwości DbContext
| Metoda | Użycie |
|---|---|
| ChangeTracker | Dostarcza informacje i operacje do śledzenie obiektów  |
| Database | Dostarcza informacje i operacje bazy danych |
| Model | Zwraca metadane o encjach, ich relacjach i w jaki sposób mapowane są do bazy danych |



## Konwencje


### Klucz podstawowy

Nazwa właściwości kończy się na Id.


### Konwencja relacji Jeden-do-wielu

#### Konwencja 1 - navigation property
Encja zawiera navigation property.

``` csharp
public class Order
{
    public int Id { get; set; }   
    public string OrderNumber { get; set; }  

    public Customer Customer { get; set; } // Navigation property
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

```
Zamówienie zawiera referencje do navigation property typu klient. EF utworzy shadow property CustomerId w modelu koncepcyjnym, które będzie mapowane do kolumny CustomerId w tabeli Orders.

#### Konwencja 2 - kolekcja
Encja zawiera kolekcję.

``` csharp
public class Order
{
    public int Id { get; set; }       
    public string OrderNumber { get; set; } 
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Order> Orders { get; set; } // Kolekcja
}

```

W bazie danych będzie taki sam rezultat jak w przypadku konwencji 1.

#### Konwencja 3 - navigation property i kolekcja

Relacja zawiera navigation property po obu stronach. W rezultacie otrzymujemy połączenie konwencji 1 i 2.


``` csharp
public class Order
{
    public int Id { get; set; }       
    public string OrderNumber { get; set; } 

    public Customer Customer { get; set; } // Navigation property
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Order> Orders { get; set; } // Kolekcja
}

```

#### Konwencja 4 - navigation property i klucz obcy
Konwencja z uzyciem wlasciwosci foreign key


``` csharp
public class Order
{
    public int Id { get; set; }       
    public string OrderNumber { get; set; } 

    public int CustomerId { get; set; }  // Foreign key property
    public Customer Customer { get; set; } // Navigation property
}

public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public List<Order> Orders { get; set; }
}

```

## Dziedziczenie

Relacyjne bazy danych nie posiadają mechanizmu dziedziczenia, dlatego musi być to w jakiś sposób mapowane.

Models.cs
~~~ csharp
public abstract class Item : BaseEntity
{
    public string Name { get; set; }
    public decimal UnitPrice { get; set; }
}

public class Product : Item
{
    public string SerialNumber { get; set; }
    public string Color { get; set; }
}

public class Service : Item
{
    public TimeSpan Duration { get; set; }
}
~~~

### TPH (Table Per Hierarchy)

#### Dwie lub więcej encji umieszczonych jest w modelu:
ShopContext.cs

~~~ csharp
public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Service> Services { get; set; }
}
~~~

#### W przypadku gdy nie chcemy publikować wszystkich encji

~~~ csharp
public class ShopContext : DbContext
{
    public DbSet<Item> Items { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
         modelBuilder.Entity<Product>().HasBaseType<Item>();
         modelBuilder.Entity<Service>().HasBaseType<Item>();
    }
}      
~~~

## Typy złozone (Complex Type)

Models.cs

~~~ csharp 

public class Address
 {
     public string City { get; set; }
     public string Street { get; set; }
     public string Country { get; set; }
     public string PostCode { get; set; }
 }
    
public class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Address InvoiceAddress { get; set; }
    public Address ShippingAddress { get; set; }
}

~~~

### Umieszczenie w tej samej tabeli

ShopContext.cs

~~~ csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{

        modelBuilder.Entity<Customer>()
            .OwnsOne(s => s.InvoiceAddress);

        modelBuilder.Entity<Customer>()
            .OwnsOne(s => s.ShippingAddress);
}

~~~


### Przeniesienie do osobnej tabeli

~~~ csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
        modelBuilder.Entity<Customer>()
            .OwnsOne(s => s.InvoiceAddress)
            .ToTable("InvoiceAddress");
            
        modelBuilder.Entity<Customer>()
            .OwnsOne(s => s.ShippingAddress)
            .ToTable("ShippingAddress");
}

~~~

## Wypełnianie danych

~~~ csharp
public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
             builder.HasData(
                new Product { Id = 1, Name = "Product 1", Color = "Red", UnitPrice = 1.99m },
                new Product { Id = 2, Name = "Product 2", Color = "Blue", UnitPrice = 1.99m },
                new Product { Id = 3, Name = "Product 3", Color = "Green", UnitPrice = 1.99m }
            );
        }
    }
~~~
