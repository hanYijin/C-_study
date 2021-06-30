using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace projectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButtonSim.Checked = true;
           
        }
        private string getResults()
        {
            string keyword = textBox_keyword.Text;//검색어
            string display = trackBarDisplayCounts.Value.ToString();
            
            string sort = "sim";
            if (radioButtonCount.Checked == true)
                sort = "count";
            string d_isbn = "100";
            string query = string.Format("?query={0}&display={1}sort={2}d_isbn={3}", keyword, display, sort,d_isbn);
            WebRequest request = WebRequest.Create("https://openapi.naver.com/v1/search/book.json" + query); //요청 URL에 쿼리 붙여 보내기
            request.Headers.Add("X-Naver-Client-Id", "IOsfdCl7CosevlzNg8G9"); //자신의 Application ID 입력
            request.Headers.Add("X-Naver-Client-Secret", "vlS257JWD3"); //자신의 Application Secret 입력
            string requestResult = "";
            using (var response = request.GetResponse())
            {
                using (Stream dataStream = response.GetResponseStream())
                {
                    using (var reader = new StreamReader(dataStream))
                    {
                        requestResult = reader.ReadToEnd(); //결과 읽어내기
                    }
                }
            }
            return requestResult;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            List<Book> books = new List<Book>();
            try
            {
                string results = getResults(); //요청한 결과 반환
                                               //HTML 태그 제거 및 변경
                //Console.WriteLine(results);
                results = results.Replace("<b>", "");
                results = results.Replace("</b>", "");
                results = results.Replace("&lt;", "<");
                results = results.Replace("&gt;", ">");
                Console.WriteLine(results);
                var parseJson = JObject.Parse(results);
                var countsOfDisplay = Convert.ToInt32(parseJson["display"]);
                var countsOfResults = Convert.ToInt32(parseJson["total"]);

                //listViewResults.Items.Clear();

                for (int i = 0; i < countsOfDisplay; i++)
                {
                    //ListViewItem item = new ListViewItem((i + 1).ToString());

                    string title = parseJson["items"][i]["title"].ToString();
                    title = title.Replace("&quot;", "\""); //HTML 태그 변경

                    string author = parseJson["items"][i]["author"].ToString();
                    author = author.Replace("&quot;", "\""); //HTML 태그 변경
                    string publisher = parseJson["items"][i]["publisher"].ToString();
                    publisher = publisher.Replace("&quot;", "\""); //HTML 태그 변경
                    string description = parseJson["items"][i]["description"].ToString();
                    description = description.Replace("&quot;", "\""); //HTML 태그 변경
                    string link = parseJson["items"][i]["link"].ToString();
                    string isbn = parseJson["items"][i]["isbn"].ToString();
                    string image = parseJson["items"][i]["image"].ToString();
                    books.Add(new Book(title,author,publisher,description,link,isbn,image));                   
                    Console.WriteLine(author+" "+ title+" " +publisher+" "+link);
                    pictureBox1.ImageLocation = parseJson["items"][0]["image"].ToString();
                    pictureBox2.ImageLocation = parseJson["items"][1]["image"].ToString();
                    pictureBox3.ImageLocation = parseJson["items"][2]["image"].ToString();

                    //뉴스 제목, 본문, 링크를 리스트 뷰에 추가
                    /* item.SubItems.Add(title);
                     item.SubItems.Add(author);
                     item.SubItems.Add(publisher);
                     item.SubItems.Add(description);
                     item.SubItems.Add(link);*/

                    //listViewResults.Items.Add(item);
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = books;
                /*DataGridViewRow row = dataGridView1.SelectedRows[0];
                DataRow r = (row.DataBoundItem as DataRowView).Row;
                string selectid = r["image"].ToString();
                pictureBox1.ImageLocation = selectid;*/
                //Console.WriteLine(selectid);
                //dataGridView2.DataSource = books;

            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                Console.WriteLine(exc.Message);
            }
        }

        private void trackBarDisplayCounts_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBarDisplayCounts.Value.ToString();
        }
        private void getResultTag()
        {
            string startDate = System.DateTime.Now.ToString("yyyy-MM-dd");
            string endDate = System.DateTime.Now.ToString("yyyy-MM-dd");
            //string timeUnit = "date";
            //var keywordGroups = JObject.Parse("[{ \"groupName\":\"도서추천\",\"keywords\":\"베스트셀러\"}]");
            //string title = "도서추천";
            //string[] keyword = new string[] { "베스트셀러", "인기" };
            //string body = "{\"startDate\":st,\"endDate\":\"2017-04-30\",\"timeUnit\":\"month\",\"keywordGroups\":[{\"groupName\":\"한글\",\"keywords\":[\"한글\",\"korean\"]},{\"groupName\":\"영어\",\"keywords\":[\"영어\",\"english\"]}],\"device\":\"pc\",\"ages\":[\"1\",\"2\"],\"gender\":\"f\"}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://openapi.naver.com/v1/datalab/search");
            request.Headers.Add("X-Naver-Client-Id", "IOsfdCl7CosevlzNg8G9");
            request.Headers.Add("X-Naver-Client-Secret", "vlS257JWD3");
            request.ContentType = "application/json";
            request.Method = "POST";
            string query= "{\"startDate\":\"2021-06-30\",\"endDate\":\"2021-06-30\",\"timeUnit\":\"date\",\"keywordGroups\":[{\"groupName\":\"도서\",\"keywords\":[\"도서\",\"책\"]}]}";

            //string query= "{\"startDate\":"+startDate+"\"endDate\":"+endDate+"\"timeUnit\":\"date\",\"keywordGroups\":[{\"groupName\":\"도서추천\",\"keywords\":[\"베스트셀러\",\"인기\"]}]}";
            //string query = string.Format("?startDate={0}&endDate={1}timeUnit={2}keywordGroups={3}",startDate,endDate,timeUnit, keywordGroups);
            byte[] byteDataParams = Encoding.UTF8.GetBytes(query);
            Stream st = request.GetRequestStream();
            st.Write(byteDataParams, 0, byteDataParams.Length);
            st.Close();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream, Encoding.UTF8);
            string text = reader.ReadToEnd();
            stream.Close();
            response.Close();
            reader.Close();
            Console.WriteLine(text);
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //getResultTag(); //요청한 결과 반환
                
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                Console.WriteLine(exc.Message);
            }
        }
        private ChromeDriverService _driverService = null;
        private ChromeOptions _options = null;
        private ChromeDriver _driver = null;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _driver = new ChromeDriver(_driverService, _options);

                _driver.Navigate().GoToUrl("https://m.nate.com/");

                _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);

                var div = _driver.FindElementByXPath("//*[@id='closed']/div/div[1]");
                var ol = div.FindElement(By.TagName("ol"));
                var lis = ol.FindElements(By.TagName("li"));
                
                foreach (var li in lis)
                {
                    var ass = li.FindElements(By.TagName("a"));
                    foreach (var sp in ass)
                    {
                        Console.WriteLine("div: " + sp.Text);
                        //Trace.WriteLine("div: " + t.Text);
                    }

                    var spans = li.FindElements(By.TagName("span"));

                    foreach (var span in spans)
                    {
                        Console.WriteLine("a: " + span.Text);
                        //Trace.WriteLine("td: " + td.Text);
                    }
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

        }
    }
}
