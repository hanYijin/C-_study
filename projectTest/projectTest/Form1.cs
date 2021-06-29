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

namespace projectTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string getResults()
        {
            string keyword = textBox_keyword.Text;//검색어
            string display = trackBarDisplayCounts.Value.ToString();
            string sort = "sim";
            if (radioButtonCount.Checked == true)
                sort = "count";

            string query = string.Format("?query={0}&display={1}sort={2}", keyword, display, sort);
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

                listViewResults.Items.Clear();
                for (int i = 0; i < countsOfDisplay; i++)
                {
                    ListViewItem item = new ListViewItem((i + 1).ToString());

                    var title = parseJson["items"][i]["title"].ToString();
                    title = title.Replace("&quot;", "\""); //HTML 태그 변경

                    var author = parseJson["items"][i]["author"].ToString();
                    author = author.Replace("&quot;", "\""); //HTML 태그 변경
                    var publisher = parseJson["items"][i]["publisher"].ToString();
                    publisher = publisher.Replace("&quot;", "\""); //HTML 태그 변경
                    var description = parseJson["items"][i]["description"].ToString();
                    description = description.Replace("&quot;", "\""); //HTML 태그 변경
                    var link = parseJson["items"][i]["link"].ToString();

                    Console.WriteLine(author+" "+ title+" " +publisher);

                    //뉴스 제목, 본문, 링크를 리스트 뷰에 추가
                    item.SubItems.Add(title);
                    item.SubItems.Add(author);
                    item.SubItems.Add(publisher);
                    item.SubItems.Add(description);
                    item.SubItems.Add(link);

                    listViewResults.Items.Add(item);
                }
            }
            catch (Exception exc)
            {
                Debug.WriteLine(exc.Message);
                Console.WriteLine(exc.Message);
            }
        }
    }
}
