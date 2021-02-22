using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\CRS\source\repos\AutomatingTest_Skooli\bin\Debug");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            driver.Manage().Window.Maximize();

            //Open the page
            driver.Url = "https://www.teachaway.com";


            //Accept cookies
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/a[1]")).Click();

            //Decline cookies
            // driver.FindElement(By.XPath("/html/body/div[1]/div/div[2]/a[2]")).Click();



            //Log in
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[2]/div/a[1]")).Click();


            // 1.Log in with facebook
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[1]")).Click();
            //Create new account
            // driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div[2]/div/div/span/a")).Click();
            //Name
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[1]/div[1]/div[1]/div/div[1]/input")).SendKeys("besa");
            //Surname
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[1]/div[1]/div[2]/div/div[1]/input")).SendKeys("xhexhi");
            //Mobile or email
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[2]/div/div[1]/input")).SendKeys("012345678");
            //New password
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[4]/div/div[1]/input")).SendKeys("click");
            //Birthday
            //Mouth
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[5]/div[2]/span/span/select[1]/option[1]")).Click();
            //Day
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[5]/div[2]/span/span/select[2]/option[1]")).Click();
            //Year
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[5]/div[2]/span/span/select[3]/option[28]")).Click();
            //Gender
            //Female
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[1]/input")).Click();
            //Man
            // driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[2]/input")).Click();
            //Custom
            // driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[7]/span/span[3]/input")).Click();
            //Sing up
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div[2]/div/div/div[1]/form/div[1]/div[10]/button")).Click();
            //KUJDES!
            //NUK DO TE KEMI KRIJIM ACCOUNT TE RI PASI NUMRI I TELEFONIT I VENDOSUR ESHTE GABIM


            //Log into existing account
            //driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/label/input")).Click();

            //Account name
            //driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/div/form/table/tbody/tr[2]/td[1]/input")).SendKeys("hello.gmail.com");
            //Password
            //driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/div/form/table/tbody/tr[2]/td[2]/input")).SendKeys("pass1");
            //Log in
            //driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/div/form/table/tbody/tr[2]/td[3]/label/input")).Click();
            //Forgot account
            //driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div[2]/div/form/table/tbody/tr[3]/td[2]/div/a")).Click();
            //Find your account
            //Mobile
            // driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/form/div/div[2]/div/table/tbody/tr[2]/td[2]/input")).SendKeys("234567");
            //Search
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/form/div/div[3]/div/div[1]/button")).Click();
            //Cancle
            //driver.FindElement(By.XPath("/html/body/div[1]/div[3]/div[1]/div/div/div/form/div/div[3]/div/div[1]/a")).Click();



            // 2.Log in with Linkedin
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[2]")).Click();
            //Email
            // driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[1]/input")).SendKeys("1234567");
            //Password
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/input")).SendKeys("123456");
            //SHOW
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/span")).Click();
            //Hide
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[2]/span")).Click();
            //Cancle
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/a")).Click();
            //Sign in
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/form/div[3]/button")).Click();
            //Forgot password
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[3]/div/a")).Click();
            //Join now
            //driver.FindElement(By.XPath("/html/body/div/main/div[2]/div[3]/p/a")).Click();



            // 3.Log in with GOOGLE
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[3]")).Click();
            //Email
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[1]/div/form/span/section/div/div/div[1]/div/div[1]/div/div[1]/input")).SendKeys("23456DFG");
            //Next
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[1]/div/div/button/div[2]")).Click();
            //Create account
            //driver.FindElement(By.XPath("/html/body/div[1]/div[1]/div[2]/div/div[2]/div/div/div[2]/div/div[2]/div/div[2]/div/div/div/button/div[2]")).Click();


            //Register
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[2]/div/a[2]")).Click();
            //Register with facebook
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[1]")).Click();
            //Register with linkedin
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[2]")).Click();
            //Register with google
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/div/button[3]")).Click();

            //Name
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[1]/input")).SendKeys("HELLO1");
            //Surname
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[2]/input")).SendKeys("helloq1");
            //Email Adress
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[3]/input")).SendKeys("d1.gj@gmail.com");
            //Password
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[4]/input")).SendKeys("dc11om123456.!");
            //Accept
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[5]/div/input")).Click();
            //Sign up
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/button")).Click();

            //Jobs title
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[1]/div[1]/div[2]/ul/li[1]")).Click();
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[1]/div[2]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[1]/div[2]/div[2]/div[2]")).Click();
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[1]/div[3]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[1]/div[3]/div[2]/div[2]")).Click();
            //Get started
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/form/div[2]/button")).Click();


            //Allow hiring schools to contact you directly?
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[1]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[1]/div[2]/div[2]")).Click();

            //Interested in online teaching?
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[2]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[2]/div[2]/div[2]")).Click();

            //Interested in getting TEFL certified?
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[3]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[3]/div[2]/div[2]")).Click();


            //Interested in teacher certification?
            //Yes
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[2]/div[1]")).Click();
            //No
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[2]/div[2]")).Click();

            //NEXT
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/button")).Click();


            //Tell us more about yourself
            //Where do you live:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[1]/div[2]/ul/li[3]")).Click();
            //Citizenship:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[2]/div[2]/ul/li[2]")).Click();
            //Fluent languages:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[3]/div[2]/ul/li[4]")).Click();
            //Date of birth:
            //Mouth
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[4]/div[2]/div[1]/div/ul/li[6]")).Click();
            //Day
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[4]/div[2]/div[2]/div/ul/li[3]")).Click();
            //Year
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[4]/div[2]/div[3]/div/ul/li[9]")).Click();
            //Gender:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[5]/div[2]/ul/li[1]")).Click();
            //Phone number
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[6]/div[2]/div/div/ul/li[2]")).Click();
            //write number
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[6]/div[2]/input")).SendKeys("85258541258");

            //Add resume
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/form/div[7]/div[2]/div")).Click();
            //Upload from:
            //1 My Device
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[1]")).Click();
            //2 Google Drive
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[2]")).Click();
            //3 Dropbox
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[3]")).Click();
            //4 Box
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[4]")).Click();
            //5 Link (URL)
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[5]")).Click();
            //6 Web Search
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div[1]/div[1]/div[1]/div/div[6]")).Click();

            //Upload
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div[3]/div/span[3]/div/span")).Click();


            //Accept
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[1]/div[2]/div[3]/div/span[3]/div/span")).Click();

            //Add your teaching license or credential
            // Show schools that you're qualified to teach.
            //Add a teaching license
            //Country your license was issued in:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[1]/div[2]/ul/li[1]")).Click();
            //Grade(s) you are licensed to teach:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[2]/div[2]/ul/li[3]")).Click();
            //Subject(s) you are licensed to teach:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[3]/div[2]/ul/li[5]")).Click();
            //Valid from: 
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[1]/div/ul/li[5]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[2]/div/ul/li[6]")).Click();
            //Expiry:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[5]/div[1]/div/ul/li[1]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[5]/div[2]/div/ul/li[6]")).Click();
            //Accept
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[7]/div/input")).Click();
            //Next educaion
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/button")).Click();

            //Now, let’s add your education
            //Highlight your post - secondary education here.
            //I do not have post-secondary education.
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/div[2]/div/div/input")).Click();
            //Add your degree
            //Degree level
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[1]/div[2]/ul/li[1]")).Click();
            //Field of study:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[2]/input")).SendKeys("PROVE");
            //College or university:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[3]/input")).SendKeys("PROVE1");
            //Start date:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[1]/div/ul/li[3]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[4]/div[2]/div/ul/li[23]")).Click();
            //End date: 
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[5]/div[1]/div/ul/li[1]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div[2]/div[5]/div[2]/div/ul/li[10]")).Click();
            //Accept
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/button")).Click();


            //Let your experience shine
            //Add your teaching experience here, so schools know you’re a good fit.
            //I am an aspiring teacher without experience.
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[1]/div/div/input")).Click();
            //Add a position
            //Position Title:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[1]/input")).SendKeys("PROVE1");
            //School or District:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[2]/input")).SendKeys("PROVE1");
            //Country:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[3]/div[2]/ul/li[6]")).Click();
            //Curriculum you taught:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[4]/div[2]/ul/li[1]")).Click();
            //Grade(s) you taught:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[5]/div[2]/button")).Click();
            //Subject(s) you taught:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[6]/div[2]/ul/li[1]")).Click();
            //From:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[7]/div[1]/div/ul/li[1]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[7]/div[2]/div/ul/li[1]")).Click();
            //To:
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[8]/div[1]/div/ul/li[1]")).Click();
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[8]/div[2]/div/ul/li[1]")).Click();
            //Accept
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[2]/div[2]/div[8]/div/input")).Click();
            //Next
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[2]/form/div[3]/button")).Click();




            //Log in
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[2]/div/a[1]")).Click();
            //Name
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[1]/input")).SendKeys("d1.gj@gmail.com");
            //Password
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/div[2]/input")).SendKeys("dc11om123456.!");
            //Log in
            //driver.FindElement(By.XPath("/html/body/div[2]/div[2]/div[1]/div[2]/form/button")).Click();


            //Jobs
            //driver.FindElement(By.XPath("/html/body/nav/div/div[2]/div/div/section/div/div[1]/div/ul/li[1]/a")).Click();
            //All country
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[1]/div[3]/div[1]/div/div/form/div/div/div[1]/div/div[1]/fieldset/span/input")).SendKeys("Albania");
            //Position
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[1]/div[3]/div[1]/div/div/form/div/div/div[1]/div/div[2]/fieldset/div/select/option[3]")).Click();
            //Search job
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[1]/div[3]/div[1]/div/div/form/div/div/div[1]/div/div[4]/div/div/input")).Click();



            //TELF
            //driver.FindElement(By.XPath("/html/body/nav/div/div[2]/div/div/section/div/div[1]/div/ul/li[2]/a")).Click();
            //X
            //driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/div[1]/button")).Click();
            //TELF CERTIFICATION
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[2]/div/div[2]/p[2]/a")).Click();
            //Get started
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div[1]/div[2]/a[1]")).Click();
            //Enroll now
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div[1]/div[2]/a[2]")).Click();



            //COURSE
            //driver.FindElement(By.XPath("/html/body/nav/div/div[2]/div/div/section/div/div[1]/div/ul/li[3]/a")).Click();
            //ALL
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[1]/button")).Click();
            //TEACHING 
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[2]/button")).Click();
            //TEACH IN USA
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[3]/button")).Click();
            //SCHOOL
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[4]/button")).Click();
            //Profesional
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[5]/button")).Click();





            //TEACHER CERTIFICATION
            //driver.FindElement(By.XPath("/html/body/nav/div/div[2]/div/div/section/div/div[1]/div/ul/li[4]/a")).Click();
            //EXPLORE PROGRAM
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[2]/div/div[2]/p[2]/a")).Click();
            //EXPLORE PROGRAM
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div[1]/div[1]/div/a")).Click();
            //DOWNLOAD PROGRAM
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/div/div[1]/div[1]/div/button")).Click();

            //Sing out
            //driver.FindElement(By.XPath("/html/body/nav/div/div[3]/div/section/div/div/ul/li[2]/a")).Click();
            //Dashboard
            //driver.FindElement(By.XPath("/html/body/nav/div/div[3]/div/section/div/div/ul/li[2]/ul/li[2]/a")).Click();
            //Profile
            //driver.FindElement(By.XPath("/html/body/nav/div/div[3]/div/section/div/div/ul/li[2]/ul/li[3]/a")).Click();
            //Setting
            //driver.FindElement(By.XPath("/html/body/nav/div/div[3]/div/section/div/div/ul/li[2]/ul/li[5]/a")).Click();
            //Log out
            //driver.FindElement(By.XPath("/html/body/nav/div/div[3]/div/section/div/div/ul/li[2]/ul/li[7]/a")).Click();

            //JOBS 
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]")).Click();
            //Job board
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[1]/a")).Click();
            //Destinations
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[2]/span")).Click();
            //Featured programs
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[3]/span")).Click();
            //Job openings
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[4]/span")).Click();
            //Teach in US
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[5]/span")).Click();
            //Comunity
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[1]/div/div/div/div/div/ul/li[6]/span")).Click();






            //TELF
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[2]/span")).Click();
            //TELF COURCES
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[2]/div/div/div/div/div/ul/li[1]/a")).Click();
            //TELF CERTIFICATION GUIDE
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[2]/div/div/div/div/div/ul/li[2]/a")).Click();



            //EACHER CERTIFICATION
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[3]/span")).Click();
            //VIEW JOBS
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[1]/div/div/div/div/div/div/div[1]/div/div/div[2]/div/a[1]")).Click();
            //GET TEACHER CERTIFICATION
            //driver.FindElement(By.XPath("/html/body/div[1]/div/div/main/section/div[2]/div/div/div/div[1]/div[1]/div/div/div/div/div/div/div[1]/div/div/div[2]/div/a[2]")).Click();


            //COURCES
            //driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[4]/a")).Click();
            //ALL
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[1]/button")).Click();
            //TEACHER BOARD
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[2]/button")).Click();
            //TEACH IN USA
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[3]/button")).Click();
            //SCHOOL HEALTHY
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[4]/button")).Click();
            //PROFESIONAL 
            // driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[2]/div[1]/div/div/div/div/div/div/ul/li[5]/button")).Click();


            //HIRE TEACHERS
            driver.FindElement(By.XPath("/html/body/div[2]/nav/div/div[1]/div/div/div/div/ul/li[5]/a")).Click();
            //CONTACT SALES
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div[2]/button")).Click();
            //LEARN MORE
            //driver.FindElement(By.XPath("/html/body/div[2]/div/div/main/section/div[2]/div/div/div/div[1]/div[2]/div/div[2]/div[2]/a")).Click();
            //CHATS
            driver.FindElement(By.XPath("/html/body/div/div[1]/span/div/button")).Click();
            //LOOKING FOR A JOB
            driver.FindElement(By.XPath("/html/body/div/div[1]/div/div/div/div[2]/div/div[1]/div/div[2]/div/div/div[2]/div/button[1]")).Click();
            //


        }

    }
}
