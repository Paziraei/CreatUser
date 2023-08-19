using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Selenum;

[TestFixture]
[Parallelizable]
public class Login
{
	[Test]
	
	static void Main()
    {
		IWebDriver webDriver = new ChromeDriver();
		webDriver.Navigate().GoToUrl("https://qcapi4.pishgamanasia.ir/manage/Login");
		IWebElement webElement = null;

		webElement = webDriver.FindElement(By.Name("UserName"));
		webElement.SendKeys("2282357787");

		webElement = webDriver.FindElement(By.Name("Password"));
		webElement.SendKeys("2282357787");

		webElement = webDriver.FindElement(By.ClassName("otpNextClass-userPassClass"));
		webElement.Click();

		webElement = webDriver.FindElement(By.XPath("//body/div[2]/div[1]/nav[1]/div[2]/nav[1]/ul[1]/li[3]/a[1]"));
		webElement.Click();

		//مدیریت اعضا
		webElement = webDriver.FindElement(By.XPath("//nav[1]/ul[1]/li[3]/a[1]"));
		webElement.Click();

		//کاربران
		webElement = webDriver.FindElement(By.XPath("//div[2]/nav[1]/ul[1]/li[3]/ul[1]/li[1]/a[1]"));
		webElement.Click();

		webElement = webDriver.FindElement(By.ClassName("btn-outline-success"));
		webElement.Click();

		webElement = webDriver.FindElement(By.Name("FName"));
		webElement.SendKeys("نام تست");

		webElement = webDriver.FindElement(By.Name("LName"));
		webElement.SendKeys("نام خانوادگی تست");

		webElement = webDriver.FindElement(By.Name("NationalNo"));
		webElement.SendKeys("تست کدملی");

		// سازمان تابع
		webElement = webDriver.FindElement(By.XPath("//div[1]/main[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/i[1]"));
		webElement.Click();

		//webElement = webDriver.FindElement(By.XPath("//div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/ul[1]/li[2]/a[1]/span[1]"));
		//webElement.Click();
		
		////کسب و کار
		//webElement = webDriver.FindElement(By.XPath("//main[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/ul[1]/li[3]/i[1]"));
		//webElement.Click();

		////فرودگاه امام خمینی(ره)؟
		//webElement = webDriver.FindElement(By.XPath("//body/div[2]/div[1]/main[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/ul[1]/li[3]/ul[1]/li[1]/i[1]"));
		//webElement.Click();

		////پیمانکار
		//webElement = webDriver.FindElement(By.XPath("//body/div[2]/div[1]/main[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/ul[1]/li[3]/ul[1]/li[1]/ul[1]/li[2]/i[1]"));
		//webElement.Click();

		////رانندگان
		//webElement =
		//	webDriver.FindElement(By.XPath("//body/div[2]/div[1]/main[1]/div[2]/div[1]/div[2]/div[3]/div[1]/div[1]/div[1]/form[1]/div[1]/div[10]/div[1]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[1]/ul[1]/li[3]/ul[1]/li[1]/ul[1]/li[2]/ul[1]/li[1]/a[1]/span[1]"));
		//webElement.Click();

	

	}


}
