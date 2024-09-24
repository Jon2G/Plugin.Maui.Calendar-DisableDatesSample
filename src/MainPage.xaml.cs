namespace DisableDatesSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyCalendar.DisabledDates = [
                new DateTime(2024,09,24),
                new DateTime(2024,09,30),
                new DateTime(2024,10,01)
            ];


        }
    }

}
