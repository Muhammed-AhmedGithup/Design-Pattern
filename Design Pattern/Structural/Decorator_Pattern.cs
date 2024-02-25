using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern.Structural
{
    internal class Decorator_Pattern
    {
        public interface WebPage
        {
            public void display();
        }
        public class BasicWebPage : WebPage
        {
            public string html;
            public string styleSheet;
            public string script;

            public void display()
            {
                /* Renders the HTML to the stylesheet, and run any embedded
                scripts */
            }
        }
        public abstract class WebPageDecorator :WebPage
        {
            protected WebPage page;
            public WebPageDecorator(WebPage webpage)
            {
                this.page = webpage;
            }
            public void display()
            {
                this.page.display();
            }
        }

        public class AuthorizedWebPage : WebPageDecorator
        {
            public AuthorizedWebPage(WebPage decoratedPage):base(decoratedPage) { }
            
            public void authorizedUser()
            {
                Console.WriteLine("User is Authorized");
            }
            public void display()
            {
                base.display();
                this.authorizedUser();
            }   
        }


        public class AuthenticatedWebPage : WebPageDecorator
        {
            public AuthenticatedWebPage(WebPage decoratedPage):base(decoratedPage)
            {
                
            }
            public void authenticateUser()
            {
                Console.WriteLine("Authenticating user");
            }
            public void display()
            {
                base.display();
                this.authenticateUser();
            }
    }


}



}

