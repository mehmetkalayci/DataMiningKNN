using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataMiningHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Training ve Test dosya yollarını tutacağımız değişkenler
        string trainingFilePath, testFilePath;

        // Training ve Test verilerini tutacağımız değişkenler
        List<DataItem> trainingSet, testSet = new List<DataItem>();

        // KNN algoritması k değeri
        int kVal = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            // KNN algoritması için k değerini ata
            kVal = int.Parse(numKval.Value.ToString());
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            // Open file dialog ile eğitim verisi seçim işlemi
            OpenFileDialog openTrainingDataset = new OpenFileDialog()
            {
                Title = "Eğitim veri seti seçin",
                Filter = "Data Files *.data|*.data|Hepsi *.*|*.*",
                FileName = "",
                ShowHelp = true,
                InitialDirectory = Application.StartupPath
            };
            DialogResult dialogResultOfOpenTrainingDataset = openTrainingDataset.ShowDialog();

            if (dialogResultOfOpenTrainingDataset == DialogResult.OK)
            {
                trainingFilePath = openTrainingDataset.FileName;
                txtTrainingFilePath.Text = trainingFilePath;

                // Seçilen training dataseti dosyadan okuyup liste attık
                trainingSet = File.ReadAllLines(trainingFilePath).ToList()
                    .Select(item => new DataItem(item.Split(',').Take(item.Split(',').Length - 1).Select(str => double.Parse(str)).ToArray(), double.Parse(item.Split(',').Last())))
                    .ToList();

                // Seçilen eğitim verilerini datagridte göster
                dgTraining.DataSource = trainingSet.Select(item => new
                {
                    Att1 = item.Attributes[0],
                    Att2 = item.Attributes[1],
                    Att3 = item.Attributes[2],
                    Att4 = item.Attributes[3],
                    Att5 = item.Attributes[4],
                    Att6 = item.Attributes[5],
                    Att7 = item.Attributes[6],
                    Att8 = item.Attributes[7],
                    Att9 = item.Attributes[8],
                    Att10 = item.Attributes[9],
                    item.Class,
                }).ToList();


                
            }
        }

        private void btnSelectTestFile_Click(object sender, EventArgs e)
        {
            // Open file dialog ile eğitim verisi seçim işlemi
            OpenFileDialog openTestDataset = new OpenFileDialog()
            {
                Title = "Eğitim veri seti seçin",
                Filter = "Data Files *.data|*.data|Hepsi *.*|*.*",
                FileName = "",
                ShowHelp = true,
                InitialDirectory = Application.StartupPath
            };
            DialogResult dialogResultOfOpenTestDataset = openTestDataset.ShowDialog();

            if (dialogResultOfOpenTestDataset == DialogResult.OK)
            {
                testFilePath = openTestDataset.FileName;
                txtTestFilePath.Text = testFilePath;

                // Seçilen test dataseti dosyadan okuyup liste attık
                testSet = File.ReadAllLines(testFilePath).ToList()
                    .Select(item => new DataItem(item.Split(',').Take(item.Split(',').Length - 1).Select(str => double.Parse(str)).ToArray(), double.Parse(item.Split(',').Last())))
                    .ToList();

                // Seçilen test verilerini datagridte göster
                dgTest.DataSource = testSet.Select(item => new
                {
                    Att1 = item.Attributes[0],
                    Att2 = item.Attributes[1],
                    Att3 = item.Attributes[2],
                    Att4 = item.Attributes[3],
                    Att5 = item.Attributes[4],
                    Att6 = item.Attributes[5],
                    Att7 = item.Attributes[6],
                    Att8 = item.Attributes[7],
                    Att9 = item.Attributes[8],
                    Att10 = item.Attributes[9],
                    item.Class,
                    item.PredictedClass // Varsayılan -1 atadık
                }).ToList();
            }
        }


        private void btnApply_Click(object sender, EventArgs e)
        {
            // İstatistikleri oluşturmak için gereken değişkenler
            int correct = 0, incorrect = 0, total = testSet.Count;

            // Test verisinin tamamnını tarayıp class tahmini yapacağız
            foreach (var testItem in testSet)
            {
                // KNN, seçilen test verisine ait tüm nokların uzaklıklarını tutacağız
                List<double> distances = new List<double>();

                // Eğitim verileri içindeki tüm noktaların, test verisine ait uzaklıklarını hesapla ve distance listesine ekle
                foreach (var trainingItem in trainingSet)
                {
                    distances.Add(EuclideanDistance(testItem.Attributes, trainingItem.Attributes));
                }

                // GetPredictedClass fonksiyonu sayesinde belirtilen k değeri adedince en yakın classı seç ve test verisinin tahmin edilen classına ata
                testItem.PredictedClass = GetPredictedClass(distances, kVal);

                // tahmin edilen ve gerçek classı karşılaştırarak doğru ve yanlış tespit sayısını bul
                if (testItem.Class == testItem.PredictedClass)
                    correct++;
                else
                    incorrect++;
            }

            // Test verisine eklenen predictedClass verisini datagridte göster
            dgTest.DataSource = testSet.Select(item => new
            {
                Att1 = item.Attributes[0],
                Att2 = item.Attributes[1],
                Att3 = item.Attributes[2],
                Att4 = item.Attributes[3],
                Att5 = item.Attributes[4],
                Att6 = item.Attributes[5],
                Att7 = item.Attributes[6],
                Att8 = item.Attributes[7],
                Att9 = item.Attributes[8],
                Att10 = item.Attributes[9],
                item.Class,
                item.PredictedClass
            }).ToList();

            // Doğru ve yanlış tahmin sayısı istatistiklerini textbox'a yaz
            txtLog.Text = "";
            txtLog.Text += "Performance Metrics\n";
            txtLog.Text += string.Format("Total={0}, Correct={1}, InCorrect={2}\n", total, correct, incorrect);
            txtLog.Text += "Accuracy = (Correct/Total)*100 = " + (correct * 100.00) / total + "%";
        }

        private void numKval_ValueChanged(object sender, EventArgs e)
        {
            // NumericUpDown kontrolünün değeri değişince k değerini güncelle
            kVal = int.Parse(numKval.Value.ToString());
        }


        /// <summary>
        /// Verilen mesafelerden k uzaklıktaki en yakınları getirir
        /// </summary>
        /// <param name="distances">Mesafe dizisi</param>
        /// <param name="k">K uzaklık değeri</param>
        /// <returns>K uzaklıktaki en yakın classı getirir</returns>
        public double GetPredictedClass(List<double> distances, int k = 1)
        {
            double result = -1;

            List<double> predictedClasses = new List<double>();

            for (int i = 0; i < k; i++)
            {
                predictedClasses.Add(trainingSet[distances.IndexOf(distances.Min())].Class);
                distances.RemoveAt(distances.IndexOf(distances.Min()));
            }


            var grouped = predictedClasses.GroupBy(i => i).Select(i => new { Class = i.Key, Count = i.Count() });

            return result = grouped.OrderByDescending(item => item.Count).FirstOrDefault().Class;
        }

        /// İki mesafe arasındaki öklid uzaklığını hesaplar
        /// </summary>
        /// <param name="X">Test verisi ya da eğitim verisi</param>
        /// <param name="Y">Test verisi ya da eğitim verisi</param>
        /// <returns>X noktaları ve Y Noktaları arasındaki öklid mesafe ölçüsünü verir</returns>
        public static double EuclideanDistance(double[] X, double[] Y)
        {
            int count = 0;

            double distance = 0.0;

            double sum = 0.0;


            if (X.GetUpperBound(0) != Y.GetUpperBound(0))
            {
                throw new System.ArgumentException("the number of elements in X must match the number of elements in Y");
            }
            else
            {
                count = X.Length;
            }

            for (int i = 0; i < count; i++)
            {
                sum = sum + Math.Pow(Math.Abs(X[i] - Y[i]), 2);
            }

            distance = Math.Sqrt(sum);

            return distance;
        }



    }
}