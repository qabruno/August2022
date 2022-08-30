using August2022.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

// open chrome browser
IWebDriver driver = new ChromeDriver();

// Login page object initialization and definition
LoginPage loginPageObj = new LoginPage();
loginPageObj.LoginSteps(driver);

// Home page object initialization and definition
HomePage homePageObj = new HomePage();
homePageObj.GoToTMPage(driver);

// TM page object initialization and definition
TMPage tmPageObj = new TMPage();
tmPageObj.CreateTM(driver);

// Edit TM
tmPageObj.EditTM(driver);

// Delete TM
tmPageObj.DeleteTM(driver);






