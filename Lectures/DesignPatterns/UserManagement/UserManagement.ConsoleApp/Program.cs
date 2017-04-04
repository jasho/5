﻿using Castle.MicroKernel.Registration;
using Castle.Windsor;
using UserManagement.ConsoleApp.Emails;
using UserManagement.ConsoleApp.Interceptor;
using UserManagement.ConsoleApp.Visitor;

namespace UserManagement.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //var program = new UserManagementApp(new DisplayUserVisitor(), new NewsletterFactory(), new SendMailUserVisitor(new LoggedEmailService(new MailerService())));
            //program.Start();
            
            var container = CreateContainer();
            var app = container.Resolve<UserManagementApp>();
            app.Start();
        }
        
        private static WindsorContainer CreateContainer()
        {
            var container = new WindsorContainer();
            container.Register(Component.For<NewsletterFactory>().LifestyleTransient());
            container.Register(Component.For<UserManagementApp>().LifestyleTransient());
            container.Register(Component.For<DisplayUserVisitor>().LifestyleTransient());
            container.Register(Component.For<SendMailUserVisitor>().LifestyleTransient());
            container.Register(Component.For<IMailerService>().ImplementedBy<MailerService>());//.LifestyleTransient().Interceptors<LoggingInterceptor>());
            container.Register(Component.For<LoggingInterceptor>().LifestyleTransient());
            return container;
        }

    }
}