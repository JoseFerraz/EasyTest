namespace EasyTest.Data.Migrations
{
    using DataContexts;
    using Domain;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<DevelopersTalentsDataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DevelopersTalentsDataContext context)
        {
            context.DeveloperTalent.AddOrUpdate(
                x => x.Email,
                new DeveloperTalent()
                {
                    Name = "abcdefg hijklmnop qrs tuv wx y and z abcdefg hijklmnop qrs tuv wx y and z",
                    Email = "abcdefghijklmnopqrstuvwxyandz@abcdefghijklmnopqrstuvwxyandz.com",
                    Skype = "abcdefghijklmnopqrstuvwxyandz@abcdefghijklmnopqrstuvwxyandz.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/abcdefghijklmnopqrstuvwxyandz",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/abcdefghijklmnopqrstuvwxyandz/testproject",
                    PortfolioLink = "http://www.abcdefghijklmnopqrstuvwxyandz.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "abcdefg hijklmnop qrs tuv wx y and z abcdefg hijklmnop qrs tuv wx y and z",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "a",
                    Email = "a@a.com",
                    Skype = "a@a.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/a",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/a/testproject",
                    PortfolioLink = "http://www.a.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "a",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "b",
                    Email = "b@b.com",
                    Skype = "b@b.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/b",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/b/testproject",
                    PortfolioLink = "http://www.b.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "b",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "c",
                    Email = "c@c.com",
                    Skype = "c@c.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/c",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/c/testproject",
                    PortfolioLink = "http://www.c.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "c",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "d",
                    Email = "d@d.com",
                    Skype = "d@d.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/d",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/d/testproject",
                    PortfolioLink = "http://www.d.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "d",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "e",
                    Email = "e@e.com",
                    Skype = "e@e.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/e",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/e/testproject",
                    PortfolioLink = "http://www.e.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "e",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "f",
                    Email = "f@f.com",
                    Skype = "f@f.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/f",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/f/testproject",
                    PortfolioLink = "http://www.f.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "f",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "g",
                    Email = "g@g.com",
                    Skype = "g@g.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/g",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/g/testproject",
                    PortfolioLink = "http://www.g.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "g",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "h",
                    Email = "h@h.com",
                    Skype = "h@h.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/h",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/h/testproject",
                    PortfolioLink = "http://www.h.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "h",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "i",
                    Email = "i@i.com",
                    Skype = "i@i.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/i",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/i/testproject",
                    PortfolioLink = "http://www.i.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "i",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "j",
                    Email = "j@j.com",
                    Skype = "j@j.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/j",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/j/testproject",
                    PortfolioLink = "http://www.j.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "j",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "k",
                    Email = "k@k.com",
                    Skype = "k@k.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/k",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/k/testproject",
                    PortfolioLink = "http://www.k.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "k",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "l",
                    Email = "l@l.com",
                    Skype = "l@l.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/l",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/l/testproject",
                    PortfolioLink = "http://www.l.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "l",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "m",
                    Email = "m@m.com",
                    Skype = "m@m.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/m",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/m/testproject",
                    PortfolioLink = "http://www.m.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "m",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "n",
                    Email = "n@n.com",
                    Skype = "n@n.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/n",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/n/testproject",
                    PortfolioLink = "http://www.n.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "n",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "o",
                    Email = "o@o.com",
                    Skype = "o@o.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/o",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/o/testproject",
                    PortfolioLink = "http://www.o.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "o",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "p",
                    Email = "p@p.com",
                    Skype = "p@p.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/p",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/p/testproject",
                    PortfolioLink = "http://www.p.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "p",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "q",
                    Email = "q@q.com",
                    Skype = "q@q.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/q",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/q/testproject",
                    PortfolioLink = "http://www.q.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "q",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "r",
                    Email = "r@r.com",
                    Skype = "r@r.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/r",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/r/testproject",
                    PortfolioLink = "http://www.r.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "r",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "s",
                    Email = "s@s.com",
                    Skype = "s@s.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/s",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/s/testproject",
                    PortfolioLink = "http://www.s.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "s",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "t",
                    Email = "t@t.com",
                    Skype = "t@t.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/t",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/t/testproject",
                    PortfolioLink = "http://www.t.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "t",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "u",
                    Email = "u@u.com",
                    Skype = "u@u.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/u",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/u/testproject",
                    PortfolioLink = "http://www.u.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "u",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "v",
                    Email = "v@v.com",
                    Skype = "v@v.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/v",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/v/testproject",
                    PortfolioLink = "http://www.v.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "v",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "w",
                    Email = "w@w.com",
                    Skype = "w@w.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/w",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/w/testproject",
                    PortfolioLink = "http://www.w.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "w",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "x",
                    Email = "x@x.com",
                    Skype = "x@x.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/x",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/x/testproject",
                    PortfolioLink = "http://www.x.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "x",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "y",
                    Email = "y@y.com",
                    Skype = "y@y.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/y",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/y/testproject",
                    PortfolioLink = "http://www.y.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "y",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "z",
                    Email = "z@z.com",
                    Skype = "z@z.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/z",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/z/testproject",
                    PortfolioLink = "http://www.z.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "z",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                },
                new DeveloperTalent()
                {
                    Name = "Testing",
                    Email = "testing@testing.com",
                    Skype = "testing@testing.com",
                    WhatsApp = "(99) 99999-9999",
                    LinkedIn = "https://www.linkedin.com/testing",
                    State = "São Paulo",
                    City = "São Paulo",
                    Knowledge = new Knowledge()
                    {
                        Technologies = new Technologies()
                        {
                            Ionic = 3,
                            Android = 3,
                            IOS = 2,
                            Html = 4,
                            Css = 4,
                            Bootstrap = 1,
                            JQuery = 2,
                            AngularJS = 2,
                            Java = 0,
                            AspNetMvc = 0,
                            C = 5,
                            CPlusPlus = 3,
                            Cake = null,
                            Django = 0,
                            Magento = null,
                            Php = 0,
                            Vue = 4,
                            WordPress = 1,
                            Python = 0,
                            Ruby = 3,
                            SqlServer = 2,
                            MySql = 2,
                            Salesforce = 4,
                            Photoshop = null,
                            Illustrator = 1,
                            Seo = 2,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Rerum, atque maiores autem reiciendis. Maxime, quae, sapiente, deleniti adipisci iste totam ea quod praesentium sit odio saepe architecto dignissimos obcaecati enim."
                        },
                        Languages = new Languages()
                        {
                            English = true,
                            Portuguese = false,
                            Spanish = false,
                            More = true,
                            Other = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Animi, inventore, qui, accusamus, officia repellat repellendus commodi pariatur laboriosam saepe velit quidem odit voluptas libero fugiat delectus nihil dolorum ipsum non!"
                        }
                    },
                    TestProjectLink = "https://www.github.com/testing/testproject",
                    PortfolioLink = "http://www.testing.com/portfolio",
                    AdditionalInformation = new AdditionalInformation()
                    {
                        WeeklyAvailability = new WeeklyAvailability()
                        {
                            UpTo4HoursPerDay = true,
                            From4To6HoursPerDay = false,
                            From6To8HoursPerDay = true,
                            MoreThan8HoursPerDay = false,
                            OnlyWeekends = true
                        },
                        PreferredPeriod = new PreferredPeriod()
                        {
                            MorningPeriod = true,
                            AfternoonPeriod = false,
                            NightPeriod = true,
                            DawnPeriod = false,
                            BusinessPeriod = true
                        },
                        HourlySalaryPretension = "$n"
                    },
                    BankInformation = new BankInformation()
                    {
                        Name = "Testing",
                        Cpf = "000.000.000-00",
                        Bank = "X",
                        Agency = "X",
                        ChainAccount = true,
                        SavingsAccount = false,
                        AccountNumber = "X",
                        OtherInformation = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Necessitatibus, delectus voluptatibus quis dolor quod obcaecati distinctio tenetur enim aliquam fugit non asperiores nihil impedit amet dolore rerum eligendi quibusdam nobis!"
                    }
                }
            );

            context.SaveChanges();
        }
    }
}
