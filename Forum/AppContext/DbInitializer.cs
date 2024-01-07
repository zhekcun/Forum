using Forum.Models;

namespace Forum.AppContext
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationContext applicationContext)
        {
            if (applicationContext.Themes.Any())
                return;

            List<Theme> themes =
            [
                new Theme {Name = "Games"},
                new Theme {Name = "Movies"},
                new Theme {Name = "Books"}
            ];
            applicationContext.Themes.AddRange(themes);
            applicationContext.SaveChanges();
        }
    }
}
