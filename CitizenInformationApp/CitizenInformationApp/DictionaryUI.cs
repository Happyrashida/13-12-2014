using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CitizenInformationApp
{
    public partial class DictionaryUI : Form
    {
        public DictionaryUI()
        {
            InitializeComponent();
        }

        Dictionary<int, string> citizenDictionary = new Dictionary<int, string>(); 

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (citizenDictionary.ContainsKey(Convert.ToInt32(idSearchTextBox.Text)))
            {
                int id = Convert.ToInt16(idSearchTextBox.Text);
                MessageBox.Show(citizenDictionary[id]);
                idSearchTextBox.Clear();
            }
            else
            {
                MessageBox.Show("ID not in list!!!");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (citizenDictionary.ContainsKey(Convert.ToInt32(idAddTextBox.Text)))
            {
                MessageBox.Show("ID already exists!!!");
            }
            else
            {
                int id = Convert.ToInt16(idAddTextBox.Text);
                string details = detailsAddRichTextBox.Text;
                citizenDictionary.Add(id, details);
                idAddTextBox.Clear();
                detailsAddRichTextBox.Clear();
            }
        }

        private void buttonShowAll_Click(object sender, EventArgs e)

        {
            string showAllInfo = string.Empty;
            foreach (var VARIABLE in citizenDictionary)
            {
                showAllInfo += VARIABLE.Key + " " + VARIABLE.Value + "\n";
            }
            MessageBox.Show(showAllInfo);
        }
    }
}
