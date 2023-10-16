namespace Overview.Controls
{
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            var random = new Random();
            for (int i = 0; i < random.Next(7, 20); i++)
            {
                var it = new AntDesign.MenuItem("Menu " + (i + 1));
                if (random.Next(0, 9) > 2)
                {
                    for (int j = 0; j < random.Next(3, 9); j++)
                    {
                        var it2 = new AntDesign.MenuItem("Option " + (j + 1));
                        if (random.Next(0, 9) > 7)
                        {
                            for (int k = 0; k < random.Next(3, 9); k++)
                            {
                                it2.Sub.Add(new AntDesign.MenuItem("Sub " + (k + 1)));
                            }
                        }
                        it.Sub.Add(it2);
                    }
                }
                menu2.Items.Add(it);
            }
        }
    }
}