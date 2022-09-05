using Entities.Concrete;
using Newtonsoft.Json;
using System;
using WinFormsApp1.Shared;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void getAllBtn_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetAll();
            var result = RestHelper.BeautifyJson(responce);
            txtResponce.Text = result;
            List<Car> cars = JsonConvert.DeserializeObject<List<Car>>(result);
            foreach (var item in cars)
            {
                txtResponce.Text += item.Description;
            }
        }

        private async void postBtn_Click(object sender, EventArgs e)
        {
            //var responce = await RestHelper.Post(nameTextBox.Text,jobTextBox.Text);
            //txtResponce.Text = RestHelper.BeautifyJson(responce);
            var responce = await RestHelper.CarPost(brandIdTextBox.Text,colorIdTextBox.Text,modelYearTextBox.Text,dailyPriceTextBox.Text,descriptionTextBox.Text, new Uri("https://localhost:44395/api/cars/add"));
            txtResponce.Text = RestHelper.BeautifyJson(responce);
        }

        private async void getBtn_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(idTextBox.Text);
            var result = RestHelper.BeautifyJson(responce);
            txtResponce.Text = result;

        }

        private async void putBtn_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Put(idTextBox.Text,nameTextBox.Text, jobTextBox.Text);
            txtResponce.Text = RestHelper.BeautifyJson(responce);
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            var responce = await Delete(idTextBox.Text);
            txtResponce.Text = responce;
        }



        private async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("https://reqres.in/api/users/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        System.Net.HttpStatusCode statusCode = res.StatusCode;
                        MessageBox.Show(((int)statusCode).ToString() + "-" + res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }
    }
}