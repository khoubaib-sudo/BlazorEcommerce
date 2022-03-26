﻿namespace BlazorEcommerce.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                            new Product
                            {
                            Id = 1,
                            Description = "Harry Potter and the Philosopher's Stone is a fantasy novel written by British author J. K. Rowling. The first novel in the Harry Potter series and Rowling's debut novel, it follows Harry Potter, a young wizard who discovers his magical heritage on his eleventh birthday, when he receives a letter of acceptance to Hogwarts School of Witchcraft and Wizardry. Harry makes close friends and a few enemies during his first year at the school, and with the help of his friends, he faces an attempted comeback by the dark wizard Lord Voldemort, who killed Harry's parents, but failed to kill Harry when he was just 15 months old.",
                            ImageUrl = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcSn4UvDTD1qHnsKOK6gLOerh3e3VSmEt_iGNQrvB9Ipw-SSlRaI",
                            Price = 9.99m,
                            Title = "Harry Potter and the Philosopher's Stone"
                            },
                            new Product
                            {
                                Id = 2,
                                Description = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
                                ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQonVotG4wBf9-cvKmdGf9UIM9ITHMfexp-ZtD_9xAkx9m1fKtR",
                                Price = 9.99m,
                                Title = "Harry Potter and the Chamber of Secrets"
                            },
                            new Product
                            {
                                Id = 3,
                                Description = "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
                                ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcTxCq_bH4zbVJfhElY0cpceiteJwNKdpK9geEtopx3qNfBAWvzh",
                                Price = 9.99m,
                                Title = "Harry Potter and the Prisoner of Azkaban"
                            },
                            new Product
                            {
                                Id = 4,
                                Description = "Harry Potter and the Goblet of Fire is a fantasy novel written by British author J. K. Rowling and the fourth novel in the Harry Potter series. It follows Harry Potter, a wizard in his fourth year at Hogwarts School of Witchcraft and Wizardry, and the mystery surrounding the entry of Harry's name into the Triwizard Tournament, in which he is forced to compete.",
                                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSY70MaVViV3nExBogvi6xaCADJShzN6IuXN1nq5j5lXzmPiQSU",
                                Price = 9.99m,
                                Title = "Harry Potter and the Goblet of Fire J. K. Rowling"
                            },
                            new Product
                            {
                                Id = 5,
                                Description = "Harry Potter and the Order of the Phoenix is a fantasy novel written by British author J. K. Rowling and the fifth novel in the Harry Potter series. It follows Harry Potter's struggles through his fifth year at Hogwarts School of Witchcraft and Wizardry, including the surreptitious return of the antagonist Lord Voldemort, O.W.L. exams, and an obstructive Ministry of Magic. The novel was published on 21 June 2003 by Bloomsbury in the United Kingdom, Scholastic in the United States, and Raincoast in Canada. It sold five million copies in the first 24 hours of publication.[1] It is the longest book of the series.",
                                ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcQhQ2j3ZmfGu-9lIEN6fNi7p-Yg4MYWZj-8jEVA8-_NTdHU6H0y",
                                Price = 9.99m,
                                Title = "Harry Potter and the Order of the Phoenix J. K. Rowling"
                            },
                            new Product
                            {
                                Id = 6,
                                Description = "Harry Potter and the Half-Blood Prince is a fantasy novel written by British author J.K. Rowling and the sixth and penultimate novel in the Harry Potter series. Set during Harry Potter's sixth year at Hogwarts, the novel explores the past of the boy wizard's nemesis, Lord Voldemort, and Harry's preparations for the final battle against Voldemort alongside his headmaster and mentor Albus Dumbledore.",
                                ImageUrl = "https://encrypted-tbn2.gstatic.com/images?q=tbn:ANd9GcR_YgUStO6VlGMrQWEm5dQ0_NdO4GSaQiRgVUtHJUTmg2Tg8wDN",
                                Price = 9.99m,
                                Title = "Harry Potter and the Half-Blood Prince J. K. Rowling"
                            },
                            new Product
                            {
                                Id = 7,
                                Description = "Harry Potter, an eleven-year-old orphan, discovers that he is a wizard and is invited to study at Hogwarts. Even as he escapes a dreary life and enters a world of magic, he finds trouble awaiting him.",
                                ImageUrl = "https://m.media-amazon.com/images/M/MV5BNjQ3NWNlNmQtMTE5ZS00MDdmLTlkZjUtZTBlM2UxMGFiMTU3XkEyXkFqcGdeQXVyNjUwNzk3NDc@._V1_FMjpg_UX1000_.jpg",
                                Price = 9.99m,
                                Title = "Harry Potter and the Philosopher's Stone"
                            },
                            new Product
                            {
                                Id = 8,
                                Description = "A house-elf warns Harry against returning to Hogwarts, but he decides to ignore it. When students and creatures at the school begin to get petrified, Harry finds himself surrounded in mystery.",
                                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTcxODgwMDkxNV5BMl5BanBnXkFtZTYwMDk2MDg3._V1_FMjpg_UX1000_.jpg",
                                Price = 9.99m,
                                Title = "Harry Potter and the Chamber of Secrets"
                            },
                            new Product
                            {
                                Id = 9,
                                Description = "Harry, Ron and Hermoine return to Hogwarts just as they learn about Sirius Black and his plans to kill Harry. However, when Harry runs into him, he learns that the truth is far from reality.",
                                ImageUrl = "https://m.media-amazon.com/images/M/MV5BMTY4NTIwODg0N15BMl5BanBnXkFtZTcwOTc0MjEzMw@@._V1_FMjpg_UX1000_.jpg",
                                Price = 9.99m,
                                Title = "Harry Potter and the Prisoner of Azkaban"
                            },
                            new Product
                            {
                                Id = 10,
                                Description = "Toy Story is a 1995 American computer-animated comedy film produced by Pixar Animation Studios and released by Walt Disney Pictures. The first installment in the Toy Story franchise, it was the first entirely computer-animated feature film, as well as the first feature film from Pixar.",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/1/13/Toy_Story.jpg",
                                Price = 9.99m,
                                Title = "Toy Story"
                            },
                            new Product
                            {
                                Id = 11,
                                Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                                Price = 9.99m,
                                Title = "Half-Life 2"
                            },
                            new Product
                            {
                                Id = 12,
                                Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                                Price = 9.99m,
                                Title = "Diablo II"
                            },
                            new Product
                            {
                                Id = 13,
                                Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                                Price = 9.99m,
                                Title = "Day of the Tentacle"
                            },
                            new Product
                            {
                                Id = 14,
                                Description = "Metal Gear Solid V: The Phantom Pain is a 2015 stealth game developed by Kojima Productions and published by Konami.",
                                ImageUrl = "https://cdn.cdkeys.com/media/catalog/product/m/g/mgs-cover4.jpg",
                                Price = 9.99m,
                                Title = "metal gear solid 5"
                            }
                );
        }
        public DbSet<Product> Products { get; set; }
    }
}
