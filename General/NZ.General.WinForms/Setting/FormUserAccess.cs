using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.Business;
using ShareLib.Models;

namespace NZ.General.WinForms.Setting
{
    public partial class FormUserAccess : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private bool[]          _AccessArray    = new bool[100];
        private bool            _DoRefresh      = true;
        private int             MainCount       = 1;
        private Manager         _Manager;
        #endregion
        #region Constructor
        public          FormUserAccess          (MenuStrip Menu)
        {
            InitializeComponent();
            this.Icon       = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager        = new Manager();
            MenuToRootNode  (Menu);
            RefreshGrid     ();
        }
        #endregion
        #region Methods
        private void    MenuToRootNode          (MenuStrip Menu)
        {
            TreeNode node;
            foreach (ToolStripItem menu in Menu.Items)
                if (menu is ToolStripMenuItem)
                {
                    node        = new TreeNode() { Name = menu.Name, Text = menu.Text };
                    node.Tag    = menu.Tag;

                    if (menu.Image != null)
                    {
                        var img                 = (Image)menu.Image.Clone();
                        img.RotateFlip          (RotateFlipType.Rotate180FlipY);
                        imageList1.Images.Add   (MainCount.ToString(), img);

                        node.ImageKey           = MainCount.ToString();
                        node.SelectedImageKey   = MainCount.ToString();
                        node.StateImageKey      = MainCount.ToString();

                    }

                    CreateSubNodes      (menu, node);
                    treeView1.Nodes.Add (node);

                    //MainCount++;
                }
        }
        private void    CreateSubNodes          (ToolStripItem Menu, TreeNode e)
        {
            if (Menu is ToolStripMenuItem)
            {
                TreeNode node;

                var ListMenu = ((ToolStripMenuItem)Menu).DropDownItems;

                for (int i = 0; i < ListMenu.Count; i++)
                {
                    var Submenu = ListMenu[i];
                    if (Submenu is ToolStripSeparator)
                        continue;
                    MainCount++;

                    node = new TreeNode
                    {
                        Name = Submenu.Name,
                        Text = Submenu.Text,
                        Tag = Submenu.Tag,
                    };

                    if (Submenu.Image != null)
                    {
                        var img                 = (Image)Submenu.Image.Clone();
                        img.RotateFlip          (RotateFlipType.Rotate180FlipY);
                        imageList1.Images.Add   (MainCount.ToString(), img);
                        node.ImageKey           = MainCount.ToString();
                        node.SelectedImageKey   = MainCount.ToString();
                        node.StateImageKey      = MainCount.ToString();
                    }

                    CreateSubNodes  (Submenu, node);
                    e.Nodes.Add     (node);

                }
            }
        }

        private void    GetAccessArray          (TreeNode Node = null)
        {
            IEnumerable<TreeNode> ListNodes =
                Node == null
                    ? treeView1.Nodes.OfType<TreeNode>()
                    : Node.Nodes.OfType<TreeNode>();

            foreach (var SubNodes in ListNodes)
            {
                AppendToArray(SubNodes);
                GetAccessArray(SubNodes);
            }
        }
        private void    AppendToArray           (TreeNode Node)
        {
            if (int.TryParse(Node.Tag.ToString(), out int Index))
            {
                try
                {
                    if (_AccessArray.Length <= Index)
                        Array.Resize(ref _AccessArray, Index + 2);

                    _AccessArray[Index] = Node.Checked;
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    throw;
                }
            }
        }
        private string  ArrayToBitString        ()
        {
            string StringBit = "";

            foreach (bool b in _AccessArray)
                StringBit = (b ? "1" : "0") + StringBit;

            return Conversion.BinToHex(StringBit);

            //decimal.TryParse(StringBit, NumberStyles.Any, 2, out decimal num);

            //return Convert.(StringBit,2);
            //return StringBit;
        }
        private string  NumberToBitString       (int Number)
        {
            return Convert.ToString(Number, 2);
        }

        private void    SetSubNodesState        (TreeNode e, bool State)
        {
            e.Checked = State;
            foreach (TreeNode child in e.Nodes)
                SetSubNodesState(child, State);
        }
        private bool    IsOK                    ()
        {
            if (mS_GridX1.CurrentRow == null || mS_GridX1.CurrentRow.RowType != RowType.Record)
            {
                MS_Message.Show("کاربر مورد نظر را انتخاب کنید");
                return false;
            }
            return true;
        }

        private void    RefreshGrid             ()
        {
            try
            {
                var list =
                    _Manager
                        .GetList<User>()
                        ?.ToList();
                mS_GridX1.DataSource = list;
                ////var Server = new AppServiceQuery<User>();
                //IEnumerable<User> ListAccount = new List<User>();
                //var result = Server.LoadList(out ListAccount);

                //if (result.Result)
                //    mS_GridX1.DataSource = ListAccount;
                //else
                //    MS_Message.Show("خطا در خواندن اطلاعات", "خطا", result.Message, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void    Save                    ()
        {
            try
            {
                var User            = mS_GridX1.CurrentRow.DataRow as User;
                GetAccessArray      ();
                var s               = ArrayToBitString();
                User.OriginalAccess = s;
                _Manager.Save       (User);

                new Form_Notify("سطح دسترسی", 
                                    "سطح دسترسی کاربر با موفقیت ثبت شد")
                                .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

                RefreshGrid         ();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ذخیره اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void    LoadAccess              (ref string AccessBitString, TreeNode Node = null)
        {
            _DoRefresh      = false;
            var ParentNode  = Node?.Nodes.OfType<TreeNode>() 
                            ?? treeView1.Nodes.OfType<TreeNode>();

            foreach (var subNode in ParentNode)
            {
                var index = Convert.ToInt32(subNode.Tag.ToString());
                if (index < AccessBitString.Length)
                    subNode.Checked = AccessBitString[index] == '1';
                else
                    subNode.Checked = false;
                LoadAccess(ref AccessBitString, subNode);
            }

            _DoRefresh = true;

        }
        #endregion

        private void ms_CheckAll_Click          (object sender, EventArgs e)
        {
            _DoRefresh = false;
            foreach (var treeNode in treeView1.Nodes.OfType<TreeNode>())
                SetSubNodesState(treeNode, true);
            _DoRefresh = true;
        }
        private void ms_UnCheckAll_Click        (object sender, EventArgs e)
        {
            _DoRefresh = false;
            foreach (var treeNode in treeView1.Nodes.OfType<TreeNode>())
                SetSubNodesState(treeNode, false);
            _DoRefresh = true;
        }
        private void ms_Save_Click              (object sender, EventArgs e)
        {
            if (!IsOK())
                return;
            Save();
        }

        private void treeView1_AfterCheck       (object sender, TreeViewEventArgs e)
        {
            if (!_DoRefresh)
                return;

            _DoRefresh = false;
            bool state = e.Node.Checked;
            SetSubNodesState(e.Node, state);
            _DoRefresh = true;
        }
        private void mS_GridX1_SelectionChanged (object sender, EventArgs e)
        {
            if (mS_GridX1.CurrentRow.RowType == RowType.Record)
            {
                var User = mS_GridX1.CurrentRow.DataRow as User;
                var accessCode = User.OriginalAccess;

                if (!string.IsNullOrWhiteSpace(accessCode))
                {
                    accessCode = Conversion.HexToBin(accessCode);

                    accessCode = string.Join("", accessCode.Reverse());
                    LoadAccess(ref accessCode);
                }
                else
                {
                    new Form_Notify("سطح دسترسی","هیچ محدوده دسترسی تعیین نشده است")
                            .Popup(Form_Notify.Direction_Show.Right_To_Left,2000);
                    ms_UnCheckAll.PerformClick();
                }

            }
        }
    }
}
