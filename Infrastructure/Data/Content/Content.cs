using Infrastructure.Models.ViewModels.Components;
using Infrastructure.Models.ViewModels.Sections;

namespace Infrastructure.Data.Content;

public static class Content
{
    public static FeaturesSection FeaturesSection = new()
    {
        Title = "What Do You Get with Our Tool?",
        Description = "Make sure all your tasks are organized so you can set the priorities and focus on important.",
        FeatureBoxes =
            [
                new()
                {
                    Title = "Comments on Tasks",
                    Description = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
                    Image = new()
                    {
                        Url = "/images/icons/chat.svg",
                        AltText = "chat"
                    }
                },
                new()
                {
                    Title = "Tasks Analytics",
                    Description = "Non imperdiet facilisis nulla tellus Morbi scelerisque eget adipiscing vulputate.",
                    Image = new()
                    {
                        Url = "/images/icons/presentation.svg",
                        AltText = "presentation"
                    }
                },
                new()
                {
                    Title = "Multiple Assignees",
                    Description = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
                    Image = new()
                    {
                        Url = "/images/icons/add-group.svg",
                        AltText = "add-group"
                    }
                },
                new()
                {
                    Title = "Notifications",
                    Description = "Diam, suspendisse velit cras ac. Lobortis diam volutpat, eget pellentesque viverra.",
                    Image = new()
                    {
                        Url = "/images/icons/bell.svg",
                        AltText = "bell"
                    }
                },
                new()
                {
                    Title = "Sections & Subtasks",
                    Description = "Mi feugiat hac id in. Sit elit placerat lacus nibh lorem ridiculus lectus.",
                    Image = new()
                    {
                        Url = "/images/icons/tests.svg",
                        AltText = "tests"
                    }
                },
                new()
                {
                    Title = "Data Security",
                    Description = "Aliquam malesuada neque eget elit nulla vestibulum nunc cras.",
                    Image = new()
                    {
                        Url = "/images/icons/shield.svg",
                        AltText = "shield"
                    }
                }
            ]
    };

    public static ShowcaseSection ShowcaseSection = new()
    {
        Title = "Task Management Assistant You Gonna Love",
        Description = "We offer you a new generation of task management system. Plan, manage & track all your tasks in one flexible tool.",
        Image = new()
        {
            Url = "/images/taskmaster-twisted.svg",
            AltText = "taskmaster-twisted"
        },
        GetStartedButton = new ()
        {
            Text = "Get started for free"
        },
        LargestBrandsSection = new()
        {
            Title = "Largest companies use our tool to work efficiently",
            BrandImages =
            [
                new()
                {
                    Url = "/images/brands/brand_1.svg",
                    AltText = "brand"
                },
                new()
                {
                    Url = "/images/brands/brand_2.svg",
                    AltText = "brand"
                },
                new()
                {
                    Url = "/images/brands/brand_3.svg",
                    AltText = "brand"
                },
                new()
                {
                    Url = "/images/brands/brand_4.svg",
                    AltText = "brand"
                },
            ]
        }
        
    };

    public static TaskmasterSection TaskmasterSection = new()
    {
        Title = "Manage Your Work",
        Image = new()
        {
            Url = "/images/taskmaster.svg",
            AltText = "taskmaster"
        },
        LearnMoreButton = new()
        {
            Text = "Learn more"
        },
        SellingArguments = 
        [
            new()
            {
                Title = "Powerful project management",
                Image = new()
                {
                    Url = "/images/icons/bx-check-circle.svg",
                    AltText = "circle"
                }
            },
            new()
            {
                Title = "Transparent work management",
                Image = new()
                {
                    Url = "/images/icons/bx-check-circle.svg",
                    AltText = "circle"
                }
            },
            new()
            {
                Title = "Manage work & focus on the most important tasks",
                Image = new()
                {
                    Url = "/images/icons/bx-check-circle.svg",
                    AltText = "circle"
                }
            },
            new()
            {
                Title = "Track your progress with interactive charts",
                Image = new()
                {
                    Url = "/images/icons/bx-check-circle.svg",
                    AltText = "circle"
                }
            },
            new()
            {
                Title = "Easiest way to track time spent on tasks",
                Image = new()
                {
                    Url = "/images/icons/bx-check-circle.svg",
                    AltText = "circle"
                }
            },
        ]
    };

    public static WorktoolsSection WorktoolsSection = new()
    {
        Title = "Integrate Top Work Tools",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin volutpat mollis egestas. Nam luctus facilisis ultrices. Pellentesque volutpat ligula est. Mattis fermentum, at nec lacus.",
        ToolBoxes =
        [
            new()
            {
                Description = "Lorem magnis pretium sed curabitur nunc facilisi nunc cursus sagittis.",
                Image = new()
                {
                    Url = "/images/icons/google.svg",
                    AltText = "google"
                }
            },
            new()
            {
                Description = "In eget a mauris quis. Tortor dui tempus quis integer est sit natoque placerat dolor.",
                Image = new()
                {
                    Url = "/images/icons/zoom.svg",
                    AltText = "zoom"
                }
            },
            new()
            {
                Description = "Id mollis consectetur congue egestas egestas suspendisse blandit justo.",
                Image = new()
                {
                    Url = "/images/icons/Slack.svg",
                    AltText = "slack"
                }
            },
            new()
            {
                Description = "Rutrum interdum tortor, sed at nulla. A cursus bibendum elit purus cras praesent.",
                Image = new()
                {
                    Url = "/images/icons/mail.svg",
                    AltText = "mail"
                }
            },
            new()
            {
                Description = "Congue pellentesque amet, viverra curabitur quam diam scelerisque fermentum urna.",
                Image = new()
                {
                    Url = "/images/icons/trello.svg",
                    AltText = "trello"
                }
            },
            new()
            {
                Description = "A elementum, imperdiet enim, pretium etiam facilisi in aenean quam mauris.",
                Image = new()
                {
                    Url = "/images/icons/MailChimp.svg",
                    AltText = "mail-chimp"
                }
            },
            new()
            {
                Description = "Ut in turpis consequat odio diam lectus elementum. Est faucibus blandit platea.",
                Image = new()
                {
                    Url = "/images/icons/Dropbox.svg",
                    AltText = "dropbox"
                }
            },
            new()
            {
                Description = "Faucibus cursus maecenas lorem cursus nibh. Sociis sit risus id. Sit facilisis dolor arcu.",
                Image = new()
                {
                    Url = "/images/icons/Evernote.svg",
                    AltText = "evernote"
                }
            }
        ]
    };

    public static SubscriberSection SubscriberSection = new()
    {
        Title = "Don't Want to Miss Anything?",
        Image = new()
        {
            Url = "/images/icons/arrows.svg",
            AltText = "arrows"
        },
        SubscriptionForm = new()
        {
            Title = "Sign up for Newsletters",
            SubmitButton = new()
            {
                Text = "Subscribe *",
                Type = "submit"
            }
        }
     
    };
}
