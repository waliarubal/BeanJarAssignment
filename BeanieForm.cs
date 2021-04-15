using System;
using System.Windows.Forms;

namespace BeanieApplication
{
    public partial class BeanieForm : Form
    {
        Random _random;

        public BeanieForm()
        {
            _random = new Random();

            InitializeComponent();

            updnCapacity.Minimum = BeanJar.MIN_CAPACITY;
            updnCapacity.Maximum = BeanJar.MAX_CAPACITY;
            updnCapacity.Value = _random.Next(BeanJar.MIN_CAPACITY, BeanJar.MAX_CAPACITY);

            grpBeanJars.Text = $"Bean Jars - Count: {lstJars.Items.Count}";
        }

        // TODO: Create jars of different capacities.
        // TODO: Make bean color and flavor match.  Don't want Blue RootBeer, etc.  Yuck!
        // TODO: Show what percent of the jar is full.
        // TODO: Show how many beans of each color there are. ----> Stop Here (Phase 1)

        private void FillAndScanButton_Click(object sender, EventArgs e)
        {
            if (lstJars.Items.Count == 0)
            {
                MessageBox.Show("No jars added. Please add some empty jars first.");
                btnAddJar.Focus();
                return;
            }

            txtStatistics.Text = string.Empty;

            foreach(BeanJar jar in lstJars.Items)
            {
                var capacity = jar.Capacity;
                for(var count = 1; count <= capacity; count++)
                {
                    var bean = new Bean();
                    jar.AddBean(bean);
                }

                txtStatistics.Text += jar.GetStatistics();
            }
        }

        private void btnAddJar_Click(object sender, EventArgs e)
        {
            var jar = new BeanJar
            {
                Capacity = (int)updnCapacity.Value
            };
            lstJars.Items.Add(jar);
            grpBeanJars.Text = $"Bean Jars - Count: {lstJars.Items.Count}";

            // random capacity for next jar 
            updnCapacity.Value = _random.Next(BeanJar.MIN_CAPACITY, BeanJar.MAX_CAPACITY);
        }

        private void btnRemoveJar_Click(object sender, EventArgs e)
        {
            if (lstJars.SelectedItem == null)
                return;

            lstJars.Items.Remove(lstJars.SelectedItem);
            grpBeanJars.Text = $"Bean Jars - Count: {lstJars.Items.Count}";
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstJars.Items.Clear();
            grpBeanJars.Text = $"Bean Jars - Count: {lstJars.Items.Count}";
        }
    }
}
