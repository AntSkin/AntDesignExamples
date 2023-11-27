namespace Overview.Controls
{
    public partial class Dropdown : UserControl
    {
        public Dropdown()
        {
            InitializeComponent();
            button17.Items.Add(new AntDesign.SelectItem(Properties.Resources.bg1, "汉尼拔 Hannibal"));

            dropdown1.Items.AddRange(new AntDesign.SelectItem[] {
                new AntDesign.SelectItem("one st menu item"),
                new AntDesign.SelectItem("two nd menu item"),
                new AntDesign.SelectItem("three rd menu item"){
                    Sub = new List<object>{
                        new AntDesign.SelectItem("子菜单1"){
                            Sub=new List<object>{ new AntDesign.SelectItem("sub menu") {
                                Sub=new List<object>{
                                    "one st menu item","two nd menu item","three rd menu item"
                                }
                            } }
                        },
                        new AntDesign.SelectItem( "子菜单2")
                    }
                },
                new AntDesign.SelectItem("four menu item"){ Sub=new List<object>{ "five menu item", "six six six menu item"} },
            });
        }

        private void dropdown1_SelectedValueChanged(object sender, object value)
        {
            AntDesign.Message.info((Form)Parent, "已选中：" + value);
        }
    }
}