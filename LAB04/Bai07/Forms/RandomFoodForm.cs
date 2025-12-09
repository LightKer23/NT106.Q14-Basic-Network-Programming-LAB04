using Bai07.Models;

namespace Bai07.Forms
{
    public partial class RandomFoodForm : Form
    {
        private readonly FoodItem _food;

        public RandomFoodForm()
        {
            InitializeComponent();
        }
        public RandomFoodForm(FoodItem food)
        {
            InitializeComponent();
            _food = food;
        }

        private void RandomFoodForm_Load(object sender, EventArgs e)
        {
            this.Text = $"Ăn {_food.ten_mon_an} đi!!!";
            foodItemControl1.SetData(_food);
        }
    }
}
