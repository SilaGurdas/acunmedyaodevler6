using Newtonsoft.Json;
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

namespace OdevSeri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnJsonOku_Click(object sender, EventArgs e)
        {
            try
            {
                
                string dosyaYolu = @"C:\Users\silam\Desktop\urunler.json";  
            
                string jsonMetni = File.ReadAllText(dosyaYolu);

                // JSON verisini nesne listesine dönüştür
                List<Urun> urunler = JsonConvert.DeserializeObject<List<Urun>>(jsonMetni);

                
                listBox1.Items.Clear();

                foreach (var urun in urunler)
                {
                    listBox1.Items.Add($"Ürün: {urun.UrunAdi} - Fiyat: {urun.Fiyat} TL");
                }

                MessageBox.Show("JSON dosyasından ürünler başarıyla okundu.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }
    }
 }

