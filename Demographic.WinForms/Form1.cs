using Demographic.FileOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demographic.WinForms
{
    public partial class Form1 : Form
    {

        string initialAgesPath = @"С:\Downloads\InitialAge.csv";
        string deathRulesPath = @"С:\Downloads\DeathRules.csv";
        public Form1()
        {

            InitializeComponent();
            StartYear.Text = "1970";
            EndYear.Text = "2000";
            Population.Text = "1000000";
        }

        private void PopulationTotal_Click(object sender, EventArgs e)
        {

        }

        private void start_Click(object sender, EventArgs e)
        {
            int startYear = Convert.ToInt32(StartYear.Text);
            int endYear = Convert.ToInt32(EndYear.Text);
            int startPopulation = Convert.ToInt32(Population.Text.Replace(" ", ""));
            
            IDataExtractor dataExtractor = new DataExtractor(initialAgesPath, deathRulesPath);
            IEngine engine = new Engine(/*dataExtractor,*/ startYear, endYear, startPopulation);

            DemographiceFacade facade = new DemographiceFacade(engine, dataExtractor);
            facade.InitStartPopulation();
            facade.CalculatePopulation();


            //engine.DoYearTick();

            string[] ages = new string[] { "0 18", "19 44", "45 65", "66 100" };

            List<Years> AllPopulation = engine.GetAllPopulation();
            List<Years> WomanPopulation = engine.GetWomanPopulation();
            List<Years> ManPopulation = engine.GetManPopulation();
            List<int> ManAgePopulation = engine.GetManAgePopulation();
            List<int> WomanAgePopulation = engine.GetWomanAgePopulation();

            for (int i = 0; i <= endYear - startYear; i++)
            {
                this.PopulationTotal.Series["population"].Points.AddXY(AllPopulation[i].Year, AllPopulation[i].Meaning);
                this.PopulationGender.Series["PopulationWonam"].Points.AddXY(WomanPopulation[i].Year, WomanPopulation[i].Meaning);
                this.PopulationGender.Series["PopulationMan"].Points.AddXY(ManPopulation[i].Year, ManPopulation[i].Meaning);
            }
            this.PopulationAge.Series["PopulationWomanAge"].Points.DataBindXY(ages, WomanAgePopulation) ;
            this.PopulationAge.Series["PopulationManAge"].Points.DataBindXY(ages, ManAgePopulation);


            //this.PopulationAge.Series["PopulationWomanAge"].Points.DataBindXY(ages[i], WomanAgePopulation);
        }
    }

}
