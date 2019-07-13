using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GeneticAlgorithmTest
{
    public partial class InfiniteMonkeyPage : UserControl
    {
        public InfiniteMonkeyPage()
        {
            InitializeComponent();
        }

        private GeneticAlgorithm<char> ga;
        string targetString = "To be or not to be.";
        string validCharacters = "abcdefghijklmnoprsştuüvwxyzqQABCDEFGHIJKLMNOPRSTUVWXY,.|_<>'^!@#$£%&/()=?;:+-*/\" 1234567890";
        int populationSize = 300;
        int counter = 0;
        float mutationRate = 0.01f;
        private Random random;
        private int Elitism = 5;
        int passedSec = 0;
        Timer passedTime = new Timer();
        Timer timer = new Timer();

        private void InfiniteMonkeyPage_Load(object sender, EventArgs e)
        {           
            timer.Interval = 10;
            passedTime.Interval = 1000;
            timer.Tick += new EventHandler(Update);
            passedTime.Tick += new EventHandler(pUpdate);
        }

        public void Start()
        {
            lblTime.Text = "0";
            passedSec = 0;
            random = new Random(DateTime.Now.Millisecond);
            timer.Start();
            passedTime.Start();
            txtDna.Clear();
            ga = new GeneticAlgorithm<char>(populationSize, targetString.Length, random, GetRandomGene, FitnessFunction, Elitism, mutationRate);
        }

        public void pUpdate (object sender, EventArgs e)
        {
            passedSec++;
            lblTime.Text = passedSec.ToString();
        }

        public void pStop()
        {
            passedTime.Stop();
        }

        public void Update(object sender, EventArgs e)
        {
            ga.NewGeneration();

           

            float temp = mutationRate * 100;
            lblBest.Text = String.Concat(ga.BestDNA);
            lblGeneration.Text = ga.Generation.ToString();
            lblMutRate.Text = "%" + temp.ToString();
            lblPopSize.Text = populationSize.ToString();
            lblFitness.Text = ga.BestFitness.ToString();
            txtDna.Text += "\n" + String.Concat(ga.BestDNA);
            txtDna.SelectionStart = txtDna.Text.Length;
            txtDna.ScrollToCaret();
            counter++;

            if (ga.BestFitness >= 1)
            {
                SystemSounds.Beep.Play();
                Stop();
            }

            if (counter > 5000)
            {
                counter = 0;
                txtDna.Clear();
            }
        }

        public void Stop()
        {
            timer.Stop();
            pStop();
        }       

        private void btnTarget_Click(object sender, EventArgs e)
        {
            targetString = txtTarget.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            populationSize = Convert.ToInt32(txtPopSize.Text);
            mutationRate = float.Parse(txtMutRate.Text.Replace('.', ','));
            Elitism = Convert.ToInt32(txtElitism.Text);
        }

        private char GetRandomGene()
        {
            int i = random.Next(validCharacters.Length);
            return validCharacters[i];
        }

        private float FitnessFunction(int index)
        {
            float score = 0;
            DNA<char> dna = ga.Population[index];

            for (int i = 0; i < dna.Genes.Length; i++)
            {
                if (dna.Genes[i] == targetString[i])
                {
                    score += 1;
                }
            }

            score /= targetString.Length;

            score = (float)((Math.Pow(5, score) - 1) / (5 - 1));
            
            return score;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }
    }
}
