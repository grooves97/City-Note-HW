namespace SlockNote.DataContext
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using SlockNote.Models;

    public class DataModels : DbContext
    {
        // Контекст настроен для использования строки подключения "DataModels" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "SlockNote.DataContext.DataModels" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DataModels" 
        // в файле конфигурации приложения.
        public DataModels()
            : base("name=DataModels")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<PhoneNumber> Numbers { get; set; }
    }
}