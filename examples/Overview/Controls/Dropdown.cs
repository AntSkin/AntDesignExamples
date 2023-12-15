// COPYRIGHT (C) Tom. ALL RIGHTS RESERVED.
// THE AntDesignExamples PROJECT IS AN WINFORM LIBRARY LICENSED UNDER THE Apache-2.0 License.
// LICENSED UNDER THE Apache License, VERSION 2.0 (THE "License")
// YOU MAY NOT USE THIS FILE EXCEPT IN COMPLIANCE WITH THE License.
// YOU MAY OBTAIN A COPY OF THE LICENSE AT
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// UNLESS REQUIRED BY APPLICABLE LAW OR AGREED TO IN WRITING, SOFTWARE
// DISTRIBUTED UNDER THE LICENSE IS DISTRIBUTED ON AN "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, EITHER EXPRESS OR IMPLIED.
// SEE THE LICENSE FOR THE SPECIFIC LANGUAGE GOVERNING PERMISSIONS AND
// LIMITATIONS UNDER THE License.
// GITHUB: https://github.com/AntSkin/AntDesignExamples
// CSDN: https://blog.csdn.net/v_132
// QQ: 17379620

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
            AntDesign.Message.info((Form)Parent, "已选中：" + value, Font);
        }
    }
}