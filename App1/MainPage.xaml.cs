namespace App1
{
    public partial class MainPage : ContentPage
    {
        String img1_str = "wow.jpg";
        String img2_str = "wow2.jpg";
        String img3_str = "wow3.jpg";
        String img4_str = "wow4.jpg";

        List<student> students = new List<student>();
        public MainPage()
        {
            InitializeComponent();
        }

        private void bt1_Clicked(object sender, EventArgs e)
        {
            Stu_List_View.ItemsSource = students;
            students.Add(new student());
            Stu_List_View.ItemsSource = null;
            Stu_List_View.ItemsSource = students;
        }
    }

}
