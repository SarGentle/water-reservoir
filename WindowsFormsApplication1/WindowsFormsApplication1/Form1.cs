using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        private Area _area;

        public Form1()
        {
            InitializeComponent();
 
        }

 

        private void btnSimul_Click(object sender, EventArgs e)
        {

            _area = new Area();
            _area.availabalArea = Convert.ToDouble(tbAvailabalArea.Text);
            _area.herbivore = new HerbivoreFishes();
            _area.herbivore.count = Convert.ToInt32(tbHerbirove.Text);
            _area.herbivore.foodNeed = Convert.ToDouble(tbHerbiroveFood.Text);
            _area.herbivore.growthSpeed = Convert.ToDouble(tbHerbiroveSpeed.Text);

            _area.plant = new UnderWaterPlants();
            _area.plant.count = Convert.ToInt32(tbPlants.Text); ;
            _area.plant.countOnAreaUnit = Convert.ToDouble(tbCountOnAreaUnit.Text);
            _area.plant.growthSpeed = Convert.ToDouble(tbGrowthSpeed.Text);

            _area.predator = new UnderWaterPredator();
            _area.predator.count = Convert.ToInt32(tbPredators.Text);
            _area.predator.foodNeed = Convert.ToInt32(tbPredatorsFood.Text);
            _area.predator.growthSpeed = Convert.ToDouble(tbGrowthSpeedPred.Text);
            
            
            chGraphic.Series.Clear();
            chGraphic.Series.Add("Растительноядные рыбы");
            chGraphic.Series.Add("Планктоны и подводные растения");
            chGraphic.Series.Add("Хищные рыбы");
            chGraphic.Series[0].ChartType = SeriesChartType.Line;
            chGraphic.Series[0].BorderWidth = 3;
            chGraphic.Series[1].ChartType = SeriesChartType.Line;
            chGraphic.Series[1].BorderWidth = 3;
            chGraphic.Series[2].ChartType = SeriesChartType.Line;
            chGraphic.Series[2].BorderWidth = 3;

            int cn = Convert.ToInt32(tbCount.Text);

            for (int i = 1; i < cn; i++)
            {
                chGraphic.Series[0].Points.AddXY(i, _area.herbivore.count);
                chGraphic.Series[1].Points.AddXY(i, _area.plant.count);
                chGraphic.Series[2].Points.AddXY(i, _area.predator.count);
                _area.liveLoop();
            }
        }

        private void tbAvailabalArea_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chGraphic_Click(object sender, EventArgs e)
        {

        }
    }
}
