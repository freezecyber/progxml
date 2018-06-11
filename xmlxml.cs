using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Xml;
using System.IO;
using System.Threading;
using System.Diagnostics;

using System.Net;
using searchGoogle;

namespace ai_test.form
{
    public partial class xmlxml : Form
    {
        string sc1;

        string sc2;
        string[] fle;
        int gb = 0;
        WebClient wc = new WebClient();
        private navigateurFenetre fenetreinternet = new navigateurFenetre();
        string lix;
        string pima;
        string science;
        SpeechSynthesizer s = new SpeechSynthesizer();
        public xmlxml()
        {
            InitializeComponent();
        }

        public void lemonde()
        {
            try
            {
                XmlDocument exmldata012221 = new XmlDocument();
                exmldata012221.Load(comboBox2.Text);

                XmlNodeList enodes012221 = exmldata012221.GetElementsByTagName("rss");

                foreach (XmlElement exmlel012221 in enodes012221)
                {
                    XmlNodeList echa012221 = exmlel012221.GetElementsByTagName("channel");

                    foreach (XmlElement eahc012221 in echa012221)
                    {
                        XmlNodeList etem0122221 = eahc012221.GetElementsByTagName("image");

                        foreach (XmlElement emet0122221 in etem0122221)
                        {
                            plx = emet0122221.GetElementsByTagName("url")[0].InnerText;

                            XmlNodeList etem012221 = eahc012221.GetElementsByTagName("item");

                            foreach (XmlElement emet012221 in etem012221)
                            {

                                science = emet012221.GetElementsByTagName(comboBox1.Text)[0].InnerText;
                          sc1=  science.Trim(Path.GetInvalidFileNameChars());
                             sc2= sc1.Trim(Path.GetInvalidPathChars());
                               

                            }
                        }

                    }

                }
            }



            catch (Exception)
            {
               
            }
        }
        public void say(string h)
        {
            s.SelectVoice("Microsoft Hortense Desktop");
            s.SpeakAsync(h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lemonde();
            say(science);
        
            var imageurl = new Uri(plx.ToString());
 

            pictureBox1.Load(imageurl.ToString());




        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            lemonde();
            richTextBox1.AppendText (science+Environment.NewLine);
            comboBox1.SelectedItem = "description";

            lemonde();
            richTextBox1.AppendText(science + Environment.NewLine);

            var imageurl = new Uri(plx.ToString());
         
            pictureBox1.Load(imageurl.ToString());




        }

        private void filedownloadcomplete(object sender, AsyncCompletedEventArgs e)
        {
            lemonde();
            MessageBox.Show("c:\\bin\\xml.jpg");
        }
        private void pictxml()
        {
            try
            {
                XmlDocument exmldata012221 = new XmlDocument();
                exmldata012221.Load(comboBox2.Text);

                XmlNodeList enodes012221 = exmldata012221.GetElementsByTagName("rss");

                foreach (XmlElement exmlel012221 in enodes012221)
                {
                    XmlNodeList echa012221 = exmlel012221.GetElementsByTagName("channel");

                    foreach (XmlElement eahc012221 in echa012221)
                    {
                        XmlNodeList etem012221 = eahc012221.GetElementsByTagName("image");

                        foreach (XmlElement emet012221 in etem012221)
                        {

                            pima = emet012221.GetElementsByTagName("url")[0].InnerText;
                        

                        }
                    }

                }

            }



            catch (Exception)
            {
               
            }
        }
        private void liensxml()
        {
            try
            {
                XmlDocument exmldata012221 = new XmlDocument();
                exmldata012221.Load(comboBox2.Text);

                XmlNodeList enodes012221 = exmldata012221.GetElementsByTagName("rss");

                foreach (XmlElement exmlel012221 in enodes012221)
                {
                    XmlNodeList echa012221 = exmlel012221.GetElementsByTagName("channel");

                    foreach (XmlElement eahc012221 in echa012221)
                    {
                        XmlNodeList etem012221 = eahc012221.GetElementsByTagName("item");

                        foreach (XmlElement emet012221 in etem012221)
                        {

                            lix = emet012221.GetElementsByTagName("link")[0].InnerText;


                        }
                    }

                }

            }



            catch (Exception)
            {
               
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            pictxml();
            Process.Start(pima);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            liensxml();

            if (fenetreinternet.wb_seeRes.IsBusy)
                fenetreinternet.wb_seeRes.Dispose();
            {
                string nom2 = label1.Text;
                fenetreinternet.nomFenetre(nom2);

                fenetreinternet.wb_seeRes.Navigate(label1.Text);
                fenetreinternet.ShowDialog();
            }

            Process.Start(lix);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void xmlxml_FormClosed(object sender, FormClosedEventArgs e)
        {
            Process fd = Process.GetCurrentProcess();
            fd.Kill();
        }

        public string plx { get; set; }

        private void button7_Click(object sender, EventArgs e)
        {
            s.SpeakAsyncCancelAll();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {try
            {
                
            if (gb ==comboBox2.SelectedIndex)
            {
                    gb++;

                  
                    comboBox2.SelectedIndex++;

                comboBox1.SelectedItem = "title";
                lemonde();
                  if (!sc2.Contains("<")) { say(sc2); } button2.PerformClick();
                if(checkBox1.Checked)
                {
                    comboBox1.SelectedItem = "description";
                    lemonde();
                      if (!sc2.Contains("<")) { say(sc2); } button2.PerformClick();
                }

            }
                else
                {
                    comboBox2.SelectedIndex = 1;
                    gb = 1;
                }

            }
            catch { }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                timer1.Interval = int.Parse(textBox1.Text);
               

            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void xmlxml_Load(object sender, EventArgs e)
        {
            say("program     x m l");
            fle = File.ReadAllLines("xml.txt");
            foreach(string fj in fle)
            {
                comboBox2.Items.Add(fj);
            }
            checkBox1.Checked = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Process.Start("xml.txt");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText(Environment.NewLine + comboBox2.SelectedItem.ToString() + Environment.NewLine);
        }
    }
}
