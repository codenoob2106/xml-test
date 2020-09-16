using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace xml_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            for (int i = 0; i < anzahl; i++)
            {
                mensch[i] = new Mensch();
            }
        }

        public static int anzahl = 32;
        public static int aktuell = 0;
        private readonly Mensch[] mensch = new Mensch[anzahl];

        

        private void CmdEingabe_Click(object sender, EventArgs e)
        {
            if (aktuell < anzahl)
            {
                string n = Convert.ToString(TxtEingabe.Text);
                mensch[aktuell] = new Mensch(n);

                LblAusgabe.Text += "" + mensch[aktuell].Name() + "\n";
                aktuell++;
            }
            else
            {
                LblAusgabe.Text += "Das Array ist voll!" + "\n";
                TxtEingabe.Enabled = false;
                CmdEingabe.Enabled = false;
            }

            TxtEingabe.Text = string.Empty;
            TxtEingabe.Focus();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            foreach (Mensch m in mensch)
            {
                LblAusgabe.Text += "" + m.Name() + " --- " + m.Punkte() + "\n";
                LstAusgabe.Items.Add(m.Name() + " --- " + m.Punkte() + "\n");
            }
        }

        private void CmdClear_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = string.Empty;
            LstAusgabe.Items.Clear();
        }

        private void CmdXmlSchreiben_Click(object sender, EventArgs e)
        {
            if (!File.Exists(@"C:\Temp\obj_to_xml.xml"))
            {
                File.Create((@"C:\Temp\obj_to_xml.xml"));
                LblAusgabe.Text = "Die Datei wurde erstellt!";
                XmlSchreiben();
            }
            else
            {
                LblAusgabe.Text = "Die Datei gab es schon!";
                XmlSchreiben();
            }
        }

        private void CmdXmlLesen_Click(object sender, EventArgs e)
        {
            XmlLesen();
        }

        public void XmlSchreiben()
        {
            XmlTextWriter xmlwriter = new XmlTextWriter("C:\\Temp\\obj_to_xml.xml", new UnicodeEncoding());

            xmlwriter.WriteStartDocument();
            foreach (Mensch m in mensch)
            {
                xmlwriter.WriteStartElement("mensch");

                xmlwriter.WriteStartElement("mensch");
                xmlwriter.WriteAttributeString("name", m.Name());
                xmlwriter.WriteAttributeString("punkte", m.Punkte());

                xmlwriter.WriteEndElement();
            }
            xmlwriter.WriteEndElement();
            xmlwriter.Close();
        }

        public void XmlLesen()
        {
            if (File.Exists("C:\\Temp\\obj_to_xml.xml"))
            {
                Mensch[] mensch = new Mensch[anzahl];

                string na = "";
                int pu = 0;
                int i;

                XmlReader readXml = new XmlTextReader("C:\\Temp\\obj_to_xml.xml");

                i = 0;
                while (readXml.Read())
                    if (readXml.NodeType == XmlNodeType.Element)
                        if (readXml.AttributeCount > 0)
                        {
                            while (readXml.MoveToNextAttribute())
                                switch (readXml.Name)
                                {
                                    case "name":
                                        na = readXml.Value;
                                        break;
                                    case "punkte":
                                        pu = Convert.ToInt32(readXml.Value);
                                        break;
                                }
                            mensch[i] = new Mensch(na, pu);
                            i++;
                        }

                foreach (Mensch m in mensch)
                {
                    LblAusgabe.Text += "" + m.Name() + " --- " + m.Punkte() + "\n";
                }
            }
            else
            {
                LblAusgabe.Text = "Die Datei existiert nicht!";
            }
        }

        public void CmdTeilnehmer_Click(object sender, EventArgs e)
        {
            LblAuswahlListe.Text = "";
            LblAuswahlListe.Text += "" + LstAusgabe.SelectedItem + "\n";
            LblAuswahlListe.Text += "Index: " + LstAusgabe.SelectedIndex;
        }

        private void CmdPunkteNeu_Click(object sender, EventArgs e)
        {
            int pktneu = Convert.ToInt32(TxtPunkteNeu.Text);
            mensch[LstAusgabe.SelectedIndex].NeuePunkte(pktneu);
            TxtPunkteNeu.Text = string.Empty;
        }
    }
}
