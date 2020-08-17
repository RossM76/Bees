using Bees;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BeeUI
{
    public partial class frmBeeUI : Form
    {
        private Random random = new Random();
        private List<Bee> Bees = new List<Bee>();

        public frmBeeUI()
        {
            InitializeComponent();
        }

        private void frmBeeUI_Load(object sender, EventArgs e)
        {
            GenerateBees();
            RefreshBeeList();
        }

        private void GenerateBees()
        {
            var workerBees = BeeFactory.CreateBees(BeeType.Worker, 10);
            var droneBees = BeeFactory.CreateBees(BeeType.Drone, 10);
            var queenBees = BeeFactory.CreateBees(BeeType.Queen, 10);

            Bees.AddRange(workerBees);
            Bees.AddRange(droneBees);
            Bees.AddRange(queenBees);
        }

        private void RefreshBeeList()
        {
            lvBees.Items.Clear();

            foreach (var bee in Bees)
            {
                var lvItem = new ListViewItem($"Bee - {bee.BeeType} - {bee.GetHashCode()}");
                lvItem.SubItems.Add(new ListViewItem.ListViewSubItem(lvItem, bee.Health.ToString()));
                lvItem.SubItems.Add(new ListViewItem.ListViewSubItem(lvItem, bee.IsDead.ToString()));
                lvItem.Tag = bee;
                lvBees.Items.Add(lvItem);
            }
        }

        private void btnDamage_Click(object sender, EventArgs e)
        {
            foreach(var bee in Bees)
            {
                var damage = random.Next(0, 80);
                bee.Damage(damage);
            }

            RefreshBeeList();
        }
    }
}
