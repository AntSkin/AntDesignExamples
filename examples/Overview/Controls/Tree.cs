namespace Overview.Controls
{
    public partial class Tree : UserControl
    {
        public Tree()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tree1.PauseLayout = tree2.PauseLayout = true;
            Task.Run(() =>
            {
                Thread.Sleep(200);
                var random = new Random();
                for (int i = 0; i < random.Next(7, 20); i++)
                {
                    var it = new AntDesign.TreeItem("Tree1 " + (i + 1));
                    AddSub(it, 1, random);
                    tree1.Items.Add(it);
                }
                for (int i = 0; i < random.Next(7, 20); i++)
                {
                    var it = new AntDesign.TreeItem("Tree2 " + (i + 1));
                    AddSub(it, 1, random);
                    tree2.Items.Add(it);
                }
            }).ContinueWith(action =>
            {
                tree1.PauseLayout = tree2.PauseLayout = false;
            });
        }

        void AddSub(AntDesign.TreeItem it, int d, Random random)
        {
            if (random.Next(0, 10) > 5 && d < 10)
            {
                var list = new List<AntDesign.TreeItem>();
                for (int i = 0; i < random.Next(3, 9); i++)
                {
                    var its = new AntDesign.TreeItem("Sub_" + d + " " + (i + 1));
                    if (d == 1)
                    {
                        int c = random.Next(0, 10);
                        if (c > 6) its.Icon = Properties.Resources.bg1;
                    }
                    AddSub(its, d + 1, random);
                    list.Add(its);
                }
                it.Sub.AddRange(list);
            }
        }
    }
}