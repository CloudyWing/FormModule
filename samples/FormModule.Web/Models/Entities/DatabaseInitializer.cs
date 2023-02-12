namespace CloudyWing.FormModule.Web.Models.Entities {
    public static class DatabaseInitializer {
        public static void Initialize(ApplicationDbContext context) {
            context.Database.EnsureCreated();

            if (context.Users.Any()) {
                return;
            }

            User[] users = new User[]
            {
                new User{ Id ="Manage", Name = "管理者" },
                new User{ Id ="Visitor", Name = "訪客" },
                new User{ Id ="Tester", Name = "測試者" }
            };

            foreach (User user in users) {
                context.Users.Add(user);
            }
            context.SaveChanges();
        }
    }
}
