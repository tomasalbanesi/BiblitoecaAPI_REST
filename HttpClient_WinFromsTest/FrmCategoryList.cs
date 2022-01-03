using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HttpClient_WinFromsTest
{
    public partial class FrmCategoryList : Form
    {

        public FrmCategoryList()
        {
            InitializeComponent();
        }

        private void FrmCategoryList_Load(object sender, EventArgs e)
        {
            dgvCategoriesList.Rows.Clear();
            var res = ListCategories();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            dgvCategoriesList.Rows.Clear();
            var res = ListCategories();
        }

        private async Task ListCategories()
        {
            var url = "https://localhost:44306/api/categories";

            using (var http = new HttpClient())
            {
                var response = await http.GetStringAsync(url);
                var categories = JsonConvert.DeserializeObject<List<Category>>(response);
                
                foreach (var category in categories)
                {
                    dgvCategoriesList.Rows.Add(new object[]
                    {
                        category.IdCategory,
                        category.Name
                    });
                }
            }
          
        }

    }
}
