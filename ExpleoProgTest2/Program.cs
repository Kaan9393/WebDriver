using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace ExpleoProgTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.se/search?q=expleogroup&ei=HURfYJXvONmRwPAP7rm3oA0&oq=expleogroup&gs_lcp=Cgdnd3Mtd2l6EAMyCggAEMcBEK8BEAoyBAgAEAoyBAgAEAoyBAgAEAoyBAgAEAoyBggAEAoQHjIGCAAQChAeMgYIABAKEB4yBggAEAoQHjIGCAAQChAeOg0IABDHARCvARCwAxBDOgcIABCwAxBDOgkIABCwAxAKEENQpRRYrRhg0RloAXACeACAAUOIAc4CkgEBNpgBAKABAaoBB2d3cy13aXrIAQrAAQE&sclient=gws-wiz&ved=0ahUKEwjV8Yap2tDvAhXZCBAIHe7cDdQQ4dUDCA0&uact=5");


            //var links = driver.FindElements(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div[1]/a/div"));

            var links = driver.FindElements(By.TagName("a"));

            foreach (var item in links)
            {
                if (item.Text != string.Empty)
                {
                    Console.WriteLine(item.Text); 
                }
            }

            //första länken
            //*[@id="rso"]/div[1]/div/div/div[1]/a/div

            //andra länken
            //*[@id="rso"]/div[1]/div/div/div[1]/a/div

            
        }
    }
}
