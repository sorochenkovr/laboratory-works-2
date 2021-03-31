using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lr16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ShowData(openFileDialog1.FileName);
            }
        }

        DataStorage data;
        private void ShowData(String datapath)
        {
            try
            {
                data = DataStorage.DataCreator(datapath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something's wrong");
            }
            dataGridView1.DataSource = data.GetRawData();
            dataGridView1.ReadOnly = true;
            dataGridView2.DataSource = data.GetSummaryData();
            dataGridView2.ReadOnly = true;
        }
        class RawDataItem
        {
            public String Name { get; set; }
            public String Group { get; set; }
            public float Price1 { get; set; }
            public float Price2 { get; set; }
            public float Total { get { return Price2; } }
            public float Max { get; set; }
        }
        class SummaryDataItem
        {
            public String GroupName { get; set; }
            public float GroupSum { get; set; }
            public float GroupMax { get; set; }
        }
        class Utils
        {
            private static Dictionary<String, String> dict;
            static Utils()
            {
                if (dict == null)
                {
                    dict = new Dictionary<string, string>();
                    dict.Add("Продукты", "Продукты питания");
                    dict.Add("Химия", "Бытовая химия");
                    dict.Add("Канцелярия", "Канцелярские принадлежности");
                    dict.Add("Напитки", "Прохладительные напитки");
                }
            }
            public static String GetGroupByName(String stroka)
            {
                if (dict.ContainsKey(stroka))
                    return dict[stroka];
                else
                    return "???";
            }
        }
        interface DataInterface
        {
            List<RawDataItem> GetRawData();
            List<SummaryDataItem> GetSummaryData();
        }
        class DataStorage : DataInterface
        {
            public bool IsReady
            {
                get
                {
                    if (rawdata == null) return false;
                    else return true;
                }
            }
            private List<RawDataItem> rawdata;
            private List<SummaryDataItem> sumdata;
            private char dev = '%';
            private DataStorage() { }
            private void BuildSummary()
            {
                Dictionary<String, float> tmp = new Dictionary<String, float>();
                foreach (var item in rawdata)
                {
                    if (tmp.ContainsKey(item.Group))
                        tmp[item.Group] += item.Total;
                    else
                        tmp[item.Group] = item.Total;
                }
                sumdata = new List<SummaryDataItem>();
                foreach (var item in tmp)
                {
                    sumdata.Add(new SummaryDataItem()
                    {
                        GroupName = Utils.GetGroupByName(item.Key),
                        GroupSum = item.Value,
                    });
                }
            }
            private void GetMax()
            {
                Dictionary<String, float> tmp1 = new Dictionary<String, float>();
                foreach (var item1 in rawdata)
                {
                    if (tmp1.ContainsKey(item1.Group))
                        item1.Max = Math.Max(item1.Price2, item1.Price2);
                }
                sumdata = new List<SummaryDataItem>();
                foreach (var item1 in tmp1)
                {
                    sumdata.Add(new SummaryDataItem()
                    {
                        GroupMax = item1.Value,
                    });
                }
            }
            private bool InitData(String datapath)
            {
                rawdata = new List<RawDataItem>();
                try
                {
                    StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] items = line.Split(dev);
                        var item = new RawDataItem()
                        {
                            Name = items[0].Trim(),
                            Group = items[1].Trim(),
                            Price1 = Convert.ToSingle(items[2].Trim()),
                            Price2 = Convert.ToSingle(items[3].Trim())
                        };
                        rawdata.Add(item);
                    }
                    sr.Close();
                    BuildSummary();
                }
                catch (IOException ex)
                {
                    return false;
                }
                return true;
            }
            public static DataStorage DataCreator(String path)
            {
                DataStorage d = new DataStorage();
                if (d.InitData(path))
                    return d;
                else
                    return null;
            }

            public List<RawDataItem> GetRawData()
            {
                if (this.IsReady)
                    return rawdata;
                else
                    return null;
            }

            public List<SummaryDataItem> GetSummaryData()
            {
                if (this.IsReady)
                    return sumdata;
                else
                    return null;
            }
        }
    }
}
