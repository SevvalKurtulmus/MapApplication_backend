# Map Application

This project is a map-based application using C# with ASP.NET Core and OpenLayers to manage geographical points, lines, and polygons. The application interacts with a PostgreSQL database for storing and retrieving geometry data in WKT (Well-Known Text) format, allowing users to perform operations such as adding, updating, deleting, and querying spatial data.

## Features

- Display Turkey map on load.
- Add, update, and delete geometric shapes (points, linestrings, polygons) on the map.
- Backend operations connected to PostgreSQL using Entity Framework.
- Frontend developed using HTML, CSS, and JavaScript with OpenLayers for map rendering.
- Implements UnitOfWork and Repository patterns for clean database interactions.
- Query system for retrieving stored geometries.

## Project Structure

- **ApplicationDbContext.cs**: Manages database operations and connections.
- **Point.cs**: Defines the entity representing geometries (Point, LineString, Polygon) using WKT format.
- **Response.cs**: Custom response handling for API interactions.
- **Program.cs**: Main application entry point.
- **Frontend**: OpenLayers for rendering the map and handling user interactions.
- **Backend**: ASP.NET Core with PostgreSQL for database operations.
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
# Harita Uygulaması

Bu proje, coğrafi noktaları, çizgileri ve poligonları yönetmek için C# ile ASP.NET Core ve OpenLayers kullanılarak oluşturulmuş bir harita tabanlı uygulamadır. Uygulama, PostgreSQL veritabanı ile etkileşime geçerek geometrik verileri WKT (Well-Known Text) formatında depolar ve sorgular. Kullanıcıların geometrik veriler üzerinde ekleme, güncelleme, silme ve sorgulama işlemleri gerçekleştirmesine olanak tanır.

## Özellikler

- Uygulama açıldığında Türkiye haritasını gösterir.
- Harita üzerinde geometrik şekillerin (noktalar, çizgiler, poligonlar) eklenmesi, güncellenmesi ve silinmesi.
- PostgreSQL veritabanı ile bağlantılı backend işlemleri.
- OpenLayers kullanılarak HTML, CSS ve JavaScript ile frontend geliştirmeleri.
- Temiz veritabanı etkileşimleri için UnitOfWork ve Repository desenleri uygulanmıştır.
- Geometrik verilerin sorgulanması için sorgu sistemi.

## Proje Yapısı

- **ApplicationDbContext.cs**: Veritabanı işlemlerini ve bağlantılarını yönetir.
- **Point.cs**: WKT formatında geometrik varlıkları (Point, LineString, Polygon) temsil eder.
- **Response.cs**: API etkileşimleri için özel yanıt yönetimi.
- **Program.cs**: Ana uygulama giriş noktası.
- **Frontend**: Kullanıcı etkileşimlerini işlemek ve haritayı görüntülemek için OpenLayers kullanılır.
- **Backend**: Veritabanı işlemleri için PostgreSQL ile ASP.NET Core kullanılır.
