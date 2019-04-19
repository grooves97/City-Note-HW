namespace SlockNote.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SlockNote.Models;

    public class DataContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DataContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SlockNote.DataContext.DataContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataContext" 
        // в файле конфигурации приложения.
        public DataContext()
            : base("name=DataContext")
        {
            Database.SetInitializer<DataContext>(new DataInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PhoneNumber> Numbers { get; set; }
    }
}