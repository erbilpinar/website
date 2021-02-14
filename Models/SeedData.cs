using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MMS.Data;
using System;
using System.Linq;

namespace MMS.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SoftwareContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<SoftwareContext>>()))
            {
                // Look for any movies.
                if (context.Software.Any())
                {
                    return;   // DB has been seeded
                }

                context.Software.AddRange(
                    new Software
                    {
                        Name = "Glue Up",
                        FreeTrial = "No",
                        StartingPrice = "Unknown",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Android",
                        Training = "In person, Online, Webinars, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Description = "Glue Up is an all-in-one CRM platform that helps you build and grow your community through events, memberships & other digital tools."
                    },

                    new Software
                    {
                        Name = "Martial Arts on Rails ",
                        FreeTrial = "Yes",
                        StartingPrice = "60$/month",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Documentation",
                        Support = "Online, Bussines Hours",
                        Description = "Gym and martial arts management software that frees up your time and helps you grow. Simplified billing, enrollment, student management, and marketing features that help you grow your gym or martial arts school"
                    },

                    new Software
                    {
                        Name = "Hivebrite",
                        FreeTrial = "Yes",
                        StartingPrice = "Unknown",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Android",
                        Training = "In Person, Online, Webinars, Documentation, ",
                        Support = "Online, Bussiness Hours",
                        Description = "Building blocks for creating great communities! A powerful online community platform, Hivebrite provides top organizations with all the tools they need to build, manage, and engage their community."
                    },

                    new Software
                    {
                        Name = "GymMaster",
                        FreeTrial = "Yes",
                        StartingPrice = "69$/month",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ",
                        Deployment = "Installed-Mac, Installed-Windows, Web-Based, Cloud, SaaS, Iphone-Ipad, Android",
                        Training = "Online, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Description = "GymMaster is easy-to-use gym and health club membership management software! GymMaster is gym software designed to make it easy to maintain detailed records of your members and their memberships, book classes and trainers, process and track sales, and communicate en mass with the right members at the right time."
                    },
                    
                    new Software
                    {
                        Name = "Raklet",
                        FreeTrial = "Yes",
                        StartingPrice = "19$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Andorid",
                        Training = "In Person, Online, Webinars, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Abowire",
                        FreeTrial = "Yes",
                        StartingPrice = "199$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",                       
                        Training = "Online, Webinars",
                        Support = "Online, 24/7",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },
                    
                    new Software
                    {
                        Name = "ToucanTech",
                        FreeTrial = "Yes",
                        StartingPrice = "Unknown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Andorid",
                        Training = "In Person, Online, Webinars, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "MemberFactory",
                        FreeTrial = "Yes",
                        StartingPrice = "10$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS,",
                        Training = "Online, Webinars, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "TidyHQ",
                        FreeTrial = "Yes",
                        StartingPrice = "Unknown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "None Provided",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "MemberPress",
                        FreeTrial = "Yes",
                        StartingPrice = "Unkown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "ClubRunner",
                        FreeTrial = "Yes",
                        StartingPrice = "18$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Webinars, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "ACS",
                        FreeTrial = "No",
                        StartingPrice = "238$/month",
                        Description = "",
                        Deployment = "Installed-Windows, Web-Based, Cloud, SaaS, Iphone-Ipad, Andorid",
                        Training = "In Person, Online, Webinars, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Vaave",
                        FreeTrial = "No",
                        StartingPrice = "Unknown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Andorid",
                        Training = "In Person, Online, Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Sitelok",
                        FreeTrial = "No",
                        StartingPrice = "39.95 one time",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Documentation",
                        Support = "Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Restrict Content Pro",
                        FreeTrial = "No",
                        StartingPrice = "Unknown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "None Provided",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "MemberSpace",
                        FreeTrial = "Yes",
                        StartingPrice = "25$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Gymcatch",
                        FreeTrial = "Yes",
                        StartingPrice = "10$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS, Iphone-Ipad, Andorid",
                        Training = "Onlinei Documentation",
                        Support = "Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "MoneyMinder",
                        FreeTrial = "No",
                        StartingPrice = "159$/year",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Documentation",
                        Support = "Online",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Reservio",
                        FreeTrial = "No",
                        StartingPrice = "10$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Documentation",
                        Support = "Online",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "SubHub",
                        FreeTrial = "Yes",
                        StartingPrice = "47$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Webinars, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "Chorus Connection",
                        FreeTrial = "No",
                        StartingPrice = "24$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online",
                        Support = "Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                     new Software
                    {
                        Name = "myClubhouse",
                        FreeTrial = "Yes",
                        StartingPrice = "28$/month",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Webinars, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },

                    new Software
                    {
                        Name = "zingfit",
                        FreeTrial = "Yes",
                        StartingPrice = "Unkown",
                        Description = "",
                        Deployment = "Web-Based, Cloud, SaaS",
                        Training = "Online, Webinars, Documentation",
                        Support = "Online, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    },
                     
                    new Software
                    {
                        Name = "MemberTies",
                        FreeTrial = "No",
                        StartingPrice = "99$/year",
                        Description = "",
                        Deployment = "Installed-Windows",
                        Training = "Documentation",
                        Support = "Online, 24/7, Bussines Hours",
                        Link = "https://www.google.com.tr/?gfe_rd=cr&ei=7b2BVam1LKio8weqhYCIAQ"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}