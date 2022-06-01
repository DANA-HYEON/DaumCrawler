using log4net;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DanaCrawler
{
    public partial class Form1 : Form
    {

        protected ChromeDriverService driverService = null;
        protected ChromeOptions options = null;
        protected ChromeDriver driver = null;

        const string URL = "https://www.daum.net/";

        List<String> Lsrc = null;  //IMG URL (Loading 할 Image URL을 넣어 둘 배열)

        const string directoryName = "DaumImageCrawling";

        public Form1()
        {
            InitializeComponent();

            //log 테이블 표시
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.GridLines = true;
        }

        private void PrintLog(string log)
        {
            LogUtil.LogInfo(log);

            //화면에 log띄우기
            ListViewItem listItem = new ListViewItem();
            int number = listView.Items.Count + 1;
            listItem.Text = number.ToString();
            listItem.SubItems.Add(log);
            listView.Items.Add(listItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                PrintLog("로그인 시작");

                //id,pw 가져오기
                string id = textID.Text;
                string pw = textPW.Text;

                // 화면 안보기
                driverService = ChromeDriverService.CreateDefaultService();
                //Hide command window
                driverService.HideCommandPromptWindow = true;

                options = new ChromeOptions();
                //gpu 사용하지 않음
                options.AddArgument("disable-gpu");

                driver = new ChromeDriver(driverService, options);
                driver.Navigate().GoToUrl(URL);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
             
                //쿠키 삭제?
                driver.Manage().Cookies.DeleteAllCookies();

                PrintLog("사이트 접속");

                var login = driver.FindElement(By.XPath("//*[@id='inner_login']/a[1]"));
                login.Click();

                var loginId = driver.FindElement(By.XPath("//*[@id='id_email_2']"));
                loginId.SendKeys(id);

                var loginPw = driver.FindElement(By.XPath("//*[@id='id_password_3']"));
                loginPw.SendKeys(pw);

                PrintLog("아이디, 비밀번호 입력");

                var loginBtn = driver.FindElement(By.CssSelector("button[class='btn_g btn_confirm submit']"));
                loginBtn.Click();

                PrintLog("로그인 접속");

            }
            catch(Exception exp)
            {
                PrintLog(exp.Message);
            }
            finally
            {
                driver.Dispose();
            }
          
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textID_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            List<DaumData> imagesInfo = new List<DaumData>();

            try
            {
                // 화면 안보기
                driverService = ChromeDriverService.CreateDefaultService();
                //Hide command window
                driverService.HideCommandPromptWindow = true;

                options = new ChromeOptions();
                //gpu 사용하지 않음
                options.AddArgument("disable-gpu");
                driver = new ChromeDriver(driverService, options);

                string searchKeyword = textImg.Text;

                PrintLog("이미지 검색 시작");
                string strURL = "https://search.daum.net/search?w=img&nil_search=btn&DA=NTB&enc=utf8&q=" + searchKeyword;
                driver.Navigate().GoToUrl(strURL);
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                driver.ExecuteScript("window.scrollBy(0, 10000)");  // 창을 띄우고 스크롤 진행

                Lsrc = new List<string>();

                PrintLog("이미지 가져오기");
                foreach (IWebElement item in driver.FindElements(By.ClassName(("thumb_img"))))
                {
                    if (item.GetAttribute("src") != null)
                    {
                        Lsrc.Add(item.GetAttribute("src"));
                        string imgInfo =  item.GetAttribute("alt");
                        DaumData daumData = new DaumData();
                        daumData.name = imgInfo;
                        daumData.imgSrc = item.GetAttribute("src");

                        imagesInfo.Add(daumData);
                    }

                }

                listCount.Text = "/ " + Lsrc.Count.ToString();


                PrintLog("이미지 보여주기");
                this.Invoke(new Action(delegate ()
                {
                    foreach (var strsrc in Lsrc.Select((value, index) => ( value, index )))
                    {
                        pictureBox.Load(Lsrc[strsrc.index]);
                        Refresh();
                        loadedImg.Text = (strsrc.index + 1).ToString();
                        Thread.Sleep(50);
                    }
                }));

            }
            catch(Exception exp)
            {
                PrintLog(exp.Message);
            }
            finally
            {
                //엑셀로 저장
                PrintLog("엑셀 생성");
                XSSFWorkbook workbook = new XSSFWorkbook();

                //Sheet 생성
                ISheet sheet = workbook.CreateSheet("DaumImageCrawlling");

                string[] header = { "이미지 alt", "이미지 src" };
                IRow hRow = sheet.CreateRow(0);
                for (int i = 0; i < header.Length; i++)
                {
                    ICell hCell = hRow.CreateCell(i);
                    hCell.SetCellValue(header[i]);
                }

                for (int i = 0; i < imagesInfo.Count; i++)
                {
                    // 엑셀에 Row 생성
                    IRow dRow = sheet.CreateRow(i + 1);

                    ICell dCell1 = dRow.CreateCell(0);
                    dCell1.SetCellValue(imagesInfo[i].name);

                    ICell dCell2 = dRow.CreateCell(1);
                    dCell2.SetCellValue(imagesInfo[i].imgSrc);
                }

                DirectoryInfo di = new DirectoryInfo(directoryName);
                if (!di.Exists)
                {
                    di.Create();
                }
                else
                {
                    //디렉토리 내용 비움
                    DeleteDirectory("./" + directoryName);
                    di.Create();
                }



                PrintLog("엑셀 저장");
                // 엑셀 파일 저장
                string excelFilePath = @"./" + directoryName + "/daumImagesCrawl.xlsx";
                using (FileStream fs = new FileStream(excelFilePath, FileMode.Create, FileAccess.Write))
                {
                    workbook.Write(fs);
                }
  

                //완료
                PrintLog("크롤링 완료");

                //for test
                driver.Dispose();
            }
        }

        private void DeleteDirectory(string srcPath)
        {
            DirectoryInfo dir = new DirectoryInfo(srcPath);
            System.IO.FileInfo[] files = dir.GetFiles("*.*", SearchOption.AllDirectories);

            foreach (System.IO.FileInfo file in files)
            {
                file.Attributes = FileAttributes.Normal;
            }

            Directory.Delete(srcPath, true);
        }
    }
}
