using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedIndex < 0)
            {
                lblInfo.Text = "Выберите пункт для удаления";
                return;
            }
            cmbItems.Items.RemoveAt(cmbItems.SelectedIndex);
            cmbItems.Text = string.Empty;
            lblInfo.Text = $"Удалено. Всего пунктов: {cmbItems.Items.Count}";


        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbItems.Items.AddRange(new object[] {"Земля","Луна","Юпитер","Меркурий"});
            cmbItems.SelectedIndex = 0;

            cmbItems.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbItems.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblInfo.Text = cmbItems.SelectedIndex >= 0
            ? $"Выбрано: {cmbItems.SelectedItem}. индекс {cmbItems.SelectedIndex}"
            : "Ничего не выбрано";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string text = txtValue.Text.Trim();
            if (text.Length == 0 || cmbItems.Items.Contains(text)) return;

            cmbItems.Items.Add(text);
            txtValue.Clear();
            lblInfo.Text = $"Добавлено. Всего пунктов: {cmbItems.Items.Count}";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int index = cmbItems.FindStringExact(txtValue.Text.Trim());

            if (index >= 0)
            {
                cmbItems.SelectedIndex = index; 
            }
            else
            {
                lblInfo.Text = "Пункт не найден";
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            cmbItems.Focus();
            cmbItems.DroppedDown = true;

       
        }
    }
}
