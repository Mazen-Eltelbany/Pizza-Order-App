using System.Windows.Forms;

namespace MyFirstWinFormsProject
{
    public partial class pizzaorder:Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pizzaorder));
            this.gbsize = new System.Windows.Forms.GroupBox();
            this.rdlarge = new System.Windows.Forms.RadioButton();
            this.rdmedium = new System.Windows.Forms.RadioButton();
            this.rdsmall = new System.Windows.Forms.RadioButton();
            this.gbtopping = new System.Windows.Forms.GroupBox();
            this.chpepper = new System.Windows.Forms.CheckBox();
            this.cholives = new System.Windows.Forms.CheckBox();
            this.chonion = new System.Windows.Forms.CheckBox();
            this.chtomato = new System.Windows.Forms.CheckBox();
            this.chmushroom = new System.Windows.Forms.CheckBox();
            this.chcheese = new System.Windows.Forms.CheckBox();
            this.gbcrust = new System.Windows.Forms.GroupBox();
            this.rdthick = new System.Windows.Forms.RadioButton();
            this.rdthin = new System.Windows.Forms.RadioButton();
            this.gbwheretoeat = new System.Windows.Forms.GroupBox();
            this.rdtakeout = new System.Windows.Forms.RadioButton();
            this.rdeatin = new System.Windows.Forms.RadioButton();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.sizelb = new System.Windows.Forms.Label();
            this.sizelabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.crustlb = new System.Windows.Forms.Label();
            this.crustlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wtelabel = new System.Windows.Forms.Label();
            this.maintitle = new System.Windows.Forms.Label();
            this.pricelb = new System.Windows.Forms.Label();
            this.totalpricelabel = new System.Windows.Forms.Label();
            this.orderbox = new System.Windows.Forms.GroupBox();
            this.toppinglb = new System.Windows.Forms.Label();
            this.gbsize.SuspendLayout();
            this.gbtopping.SuspendLayout();
            this.gbcrust.SuspendLayout();
            this.gbwheretoeat.SuspendLayout();
            this.orderbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbsize
            // 
            this.gbsize.Controls.Add(this.rdlarge);
            this.gbsize.Controls.Add(this.rdmedium);
            this.gbsize.Controls.Add(this.rdsmall);
            this.gbsize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbsize.Location = new System.Drawing.Point(53, 111);
            this.gbsize.Margin = new System.Windows.Forms.Padding(4);
            this.gbsize.Name = "gbsize";
            this.gbsize.Padding = new System.Windows.Forms.Padding(4);
            this.gbsize.Size = new System.Drawing.Size(196, 221);
            this.gbsize.TabIndex = 0;
            this.gbsize.TabStop = false;
            this.gbsize.Text = "Size";
            // 
            // rdlarge
            // 
            this.rdlarge.AutoSize = true;
            this.rdlarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdlarge.Location = new System.Drawing.Point(36, 142);
            this.rdlarge.Margin = new System.Windows.Forms.Padding(4);
            this.rdlarge.Name = "rdlarge";
            this.rdlarge.Size = new System.Drawing.Size(83, 29);
            this.rdlarge.TabIndex = 2;
            this.rdlarge.Tag = "40";
            this.rdlarge.Text = "Large";
            this.rdlarge.UseVisualStyleBackColor = true;
            this.rdlarge.CheckedChanged += new System.EventHandler(this.rdlarge_CheckedChanged);
            // 
            // rdmedium
            // 
            this.rdmedium.AutoSize = true;
            this.rdmedium.Checked = true;
            this.rdmedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdmedium.Location = new System.Drawing.Point(36, 91);
            this.rdmedium.Margin = new System.Windows.Forms.Padding(4);
            this.rdmedium.Name = "rdmedium";
            this.rdmedium.Size = new System.Drawing.Size(103, 29);
            this.rdmedium.TabIndex = 1;
            this.rdmedium.TabStop = true;
            this.rdmedium.Tag = "30";
            this.rdmedium.Text = "Medium";
            this.rdmedium.UseVisualStyleBackColor = true;
            this.rdmedium.CheckedChanged += new System.EventHandler(this.rdmedium_CheckedChanged);
            // 
            // rdsmall
            // 
            this.rdsmall.AutoSize = true;
            this.rdsmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdsmall.Location = new System.Drawing.Point(36, 45);
            this.rdsmall.Margin = new System.Windows.Forms.Padding(4);
            this.rdsmall.Name = "rdsmall";
            this.rdsmall.Size = new System.Drawing.Size(82, 29);
            this.rdsmall.TabIndex = 0;
            this.rdsmall.Tag = "20";
            this.rdsmall.Text = "Small";
            this.rdsmall.UseVisualStyleBackColor = true;
            this.rdsmall.CheckedChanged += new System.EventHandler(this.rdsmall_CheckedChanged);
            // 
            // gbtopping
            // 
            this.gbtopping.BackColor = System.Drawing.Color.White;
            this.gbtopping.Controls.Add(this.chpepper);
            this.gbtopping.Controls.Add(this.cholives);
            this.gbtopping.Controls.Add(this.chonion);
            this.gbtopping.Controls.Add(this.chtomato);
            this.gbtopping.Controls.Add(this.chmushroom);
            this.gbtopping.Controls.Add(this.chcheese);
            this.gbtopping.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtopping.Location = new System.Drawing.Point(333, 111);
            this.gbtopping.Margin = new System.Windows.Forms.Padding(4);
            this.gbtopping.Name = "gbtopping";
            this.gbtopping.Padding = new System.Windows.Forms.Padding(4);
            this.gbtopping.Size = new System.Drawing.Size(335, 187);
            this.gbtopping.TabIndex = 1;
            this.gbtopping.TabStop = false;
            this.gbtopping.Text = "Toppings";
            this.gbtopping.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // chpepper
            // 
            this.chpepper.AutoSize = true;
            this.chpepper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chpepper.Location = new System.Drawing.Point(161, 139);
            this.chpepper.Margin = new System.Windows.Forms.Padding(4);
            this.chpepper.Name = "chpepper";
            this.chpepper.Size = new System.Drawing.Size(166, 29);
            this.chpepper.TabIndex = 5;
            this.chpepper.Tag = "5";
            this.chpepper.Text = "Green Peppers";
            this.chpepper.UseVisualStyleBackColor = true;
            this.chpepper.CheckedChanged += new System.EventHandler(this.chpepper_CheckedChanged);
            // 
            // cholives
            // 
            this.cholives.AutoSize = true;
            this.cholives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cholives.Location = new System.Drawing.Point(161, 88);
            this.cholives.Margin = new System.Windows.Forms.Padding(4);
            this.cholives.Name = "cholives";
            this.cholives.Size = new System.Drawing.Size(89, 29);
            this.cholives.TabIndex = 4;
            this.cholives.Tag = "5";
            this.cholives.Text = "Olives";
            this.cholives.UseVisualStyleBackColor = true;
            this.cholives.CheckedChanged += new System.EventHandler(this.cholives_CheckedChanged);
            // 
            // chonion
            // 
            this.chonion.AutoSize = true;
            this.chonion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chonion.Location = new System.Drawing.Point(161, 46);
            this.chonion.Margin = new System.Windows.Forms.Padding(4);
            this.chonion.Name = "chonion";
            this.chonion.Size = new System.Drawing.Size(87, 29);
            this.chonion.TabIndex = 3;
            this.chonion.Tag = "5";
            this.chonion.Text = "Onion";
            this.chonion.UseVisualStyleBackColor = true;
            this.chonion.CheckedChanged += new System.EventHandler(this.chonion_CheckedChanged);
            // 
            // chtomato
            // 
            this.chtomato.AutoSize = true;
            this.chtomato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chtomato.Location = new System.Drawing.Point(8, 142);
            this.chtomato.Margin = new System.Windows.Forms.Padding(4);
            this.chtomato.Name = "chtomato";
            this.chtomato.Size = new System.Drawing.Size(122, 29);
            this.chtomato.TabIndex = 2;
            this.chtomato.Tag = "5";
            this.chtomato.Text = "Tomatoes";
            this.chtomato.UseVisualStyleBackColor = true;
            this.chtomato.CheckedChanged += new System.EventHandler(this.chtomato_CheckedChanged);
            // 
            // chmushroom
            // 
            this.chmushroom.AutoSize = true;
            this.chmushroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chmushroom.Location = new System.Drawing.Point(8, 92);
            this.chmushroom.Margin = new System.Windows.Forms.Padding(4);
            this.chmushroom.Name = "chmushroom";
            this.chmushroom.Size = new System.Drawing.Size(137, 29);
            this.chmushroom.TabIndex = 1;
            this.chmushroom.Tag = "5";
            this.chmushroom.Text = "Mushrooms";
            this.chmushroom.UseVisualStyleBackColor = true;
            this.chmushroom.CheckedChanged += new System.EventHandler(this.chmushroom_CheckedChanged);
            // 
            // chcheese
            // 
            this.chcheese.AutoSize = true;
            this.chcheese.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chcheese.Location = new System.Drawing.Point(8, 46);
            this.chcheese.Margin = new System.Windows.Forms.Padding(4);
            this.chcheese.Name = "chcheese";
            this.chcheese.Size = new System.Drawing.Size(153, 29);
            this.chcheese.TabIndex = 0;
            this.chcheese.Tag = "5";
            this.chcheese.Text = "Extra Cheese";
            this.chcheese.UseVisualStyleBackColor = true;
            this.chcheese.CheckedChanged += new System.EventHandler(this.chcheese_CheckedChanged);
            // 
            // gbcrust
            // 
            this.gbcrust.Controls.Add(this.rdthick);
            this.gbcrust.Controls.Add(this.rdthin);
            this.gbcrust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbcrust.Location = new System.Drawing.Point(42, 340);
            this.gbcrust.Margin = new System.Windows.Forms.Padding(4);
            this.gbcrust.Name = "gbcrust";
            this.gbcrust.Padding = new System.Windows.Forms.Padding(4);
            this.gbcrust.Size = new System.Drawing.Size(248, 126);
            this.gbcrust.TabIndex = 2;
            this.gbcrust.TabStop = false;
            this.gbcrust.Text = "Crust Type";
            // 
            // rdthick
            // 
            this.rdthick.AutoSize = true;
            this.rdthick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthick.Location = new System.Drawing.Point(38, 75);
            this.rdthick.Margin = new System.Windows.Forms.Padding(4);
            this.rdthick.Name = "rdthick";
            this.rdthick.Size = new System.Drawing.Size(133, 29);
            this.rdthick.TabIndex = 1;
            this.rdthick.Tag = "10";
            this.rdthick.Text = "Thick Crust";
            this.rdthick.UseVisualStyleBackColor = true;
            this.rdthick.CheckedChanged += new System.EventHandler(this.rdthick_CheckedChanged);
            // 
            // rdthin
            // 
            this.rdthin.AutoSize = true;
            this.rdthin.Checked = true;
            this.rdthin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdthin.Location = new System.Drawing.Point(38, 31);
            this.rdthin.Margin = new System.Windows.Forms.Padding(4);
            this.rdthin.Name = "rdthin";
            this.rdthin.Size = new System.Drawing.Size(124, 29);
            this.rdthin.TabIndex = 0;
            this.rdthin.TabStop = true;
            this.rdthin.Tag = "0";
            this.rdthin.Text = "Thin Crust";
            this.rdthin.UseVisualStyleBackColor = true;
            this.rdthin.CheckedChanged += new System.EventHandler(this.rdthin_CheckedChanged);
            // 
            // gbwheretoeat
            // 
            this.gbwheretoeat.Controls.Add(this.rdtakeout);
            this.gbwheretoeat.Controls.Add(this.rdeatin);
            this.gbwheretoeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbwheretoeat.Location = new System.Drawing.Point(341, 341);
            this.gbwheretoeat.Margin = new System.Windows.Forms.Padding(4);
            this.gbwheretoeat.Name = "gbwheretoeat";
            this.gbwheretoeat.Padding = new System.Windows.Forms.Padding(4);
            this.gbwheretoeat.Size = new System.Drawing.Size(335, 85);
            this.gbwheretoeat.TabIndex = 3;
            this.gbwheretoeat.TabStop = false;
            this.gbwheretoeat.Text = "Where To Eat";
            // 
            // rdtakeout
            // 
            this.rdtakeout.AutoSize = true;
            this.rdtakeout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdtakeout.Location = new System.Drawing.Point(120, 31);
            this.rdtakeout.Margin = new System.Windows.Forms.Padding(4);
            this.rdtakeout.Name = "rdtakeout";
            this.rdtakeout.Size = new System.Drawing.Size(115, 29);
            this.rdtakeout.TabIndex = 1;
            this.rdtakeout.Text = "Take Out";
            this.rdtakeout.UseVisualStyleBackColor = true;
            this.rdtakeout.CheckedChanged += new System.EventHandler(this.rdtakeout_CheckedChanged);
            // 
            // rdeatin
            // 
            this.rdeatin.AutoSize = true;
            this.rdeatin.Checked = true;
            this.rdeatin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdeatin.Location = new System.Drawing.Point(8, 31);
            this.rdeatin.Margin = new System.Windows.Forms.Padding(4);
            this.rdeatin.Name = "rdeatin";
            this.rdeatin.Size = new System.Drawing.Size(88, 29);
            this.rdeatin.TabIndex = 0;
            this.rdeatin.TabStop = true;
            this.rdeatin.Text = " Eat In";
            this.rdeatin.UseVisualStyleBackColor = true;
            this.rdeatin.CheckedChanged += new System.EventHandler(this.rdeatin_CheckedChanged);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(303, 451);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(170, 49);
            this.btnOrder.TabIndex = 4;
            this.btnOrder.Text = "Order Pizza";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(534, 451);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(170, 49);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset Form";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // sizelb
            // 
            this.sizelb.AutoSize = true;
            this.sizelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizelb.Location = new System.Drawing.Point(17, 35);
            this.sizelb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizelb.Name = "sizelb";
            this.sizelb.Size = new System.Drawing.Size(62, 25);
            this.sizelb.TabIndex = 10;
            this.sizelb.Text = "Size:";
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizelabel.Location = new System.Drawing.Point(58, 35);
            this.sizelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(82, 25);
            this.sizelabel.TabIndex = 11;
            this.sizelabel.Text = "Medium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toppings:";
            // 
            // crustlb
            // 
            this.crustlb.AutoSize = true;
            this.crustlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crustlb.Location = new System.Drawing.Point(7, 142);
            this.crustlb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crustlb.Name = "crustlb";
            this.crustlb.Size = new System.Drawing.Size(126, 25);
            this.crustlb.TabIndex = 14;
            this.crustlb.Text = "Crust Type:";
            // 
            // crustlabel
            // 
            this.crustlabel.AutoSize = true;
            this.crustlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crustlabel.Location = new System.Drawing.Point(114, 143);
            this.crustlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.crustlabel.Name = "crustlabel";
            this.crustlabel.Size = new System.Drawing.Size(103, 25);
            this.crustlabel.TabIndex = 15;
            this.crustlabel.Text = "Thin Crust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Where To Eat:";
            // 
            // wtelabel
            // 
            this.wtelabel.AutoSize = true;
            this.wtelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wtelabel.Location = new System.Drawing.Point(118, 197);
            this.wtelabel.Name = "wtelabel";
            this.wtelabel.Size = new System.Drawing.Size(67, 25);
            this.wtelabel.TabIndex = 17;
            this.wtelabel.Text = "Eat In ";
            // 
            // maintitle
            // 
            this.maintitle.AutoSize = true;
            this.maintitle.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.maintitle.Location = new System.Drawing.Point(193, 9);
            this.maintitle.Name = "maintitle";
            this.maintitle.Size = new System.Drawing.Size(758, 98);
            this.maintitle.TabIndex = 18;
            this.maintitle.Text = "MAKE YOUR PIZZA";
            this.maintitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.maintitle.Click += new System.EventHandler(this.maintitle_Click);
            // 
            // pricelb
            // 
            this.pricelb.AutoSize = true;
            this.pricelb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pricelb.Location = new System.Drawing.Point(17, 245);
            this.pricelb.Name = "pricelb";
            this.pricelb.Size = new System.Drawing.Size(123, 25);
            this.pricelb.TabIndex = 19;
            this.pricelb.Text = "Total Price:";
            // 
            // totalpricelabel
            // 
            this.totalpricelabel.AutoSize = true;
            this.totalpricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 46.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpricelabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalpricelabel.Location = new System.Drawing.Point(108, 245);
            this.totalpricelabel.Name = "totalpricelabel";
            this.totalpricelabel.Size = new System.Drawing.Size(124, 89);
            this.totalpricelabel.TabIndex = 20;
            this.totalpricelabel.Text = "$0";
            // 
            // orderbox
            // 
            this.orderbox.Controls.Add(this.totalpricelabel);
            this.orderbox.Controls.Add(this.sizelabel);
            this.orderbox.Controls.Add(this.pricelb);
            this.orderbox.Controls.Add(this.sizelb);
            this.orderbox.Controls.Add(this.wtelabel);
            this.orderbox.Controls.Add(this.label1);
            this.orderbox.Controls.Add(this.toppinglb);
            this.orderbox.Controls.Add(this.crustlabel);
            this.orderbox.Controls.Add(this.label5);
            this.orderbox.Controls.Add(this.crustlb);
            this.orderbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbox.Location = new System.Drawing.Point(734, 110);
            this.orderbox.Name = "orderbox";
            this.orderbox.Size = new System.Drawing.Size(335, 349);
            this.orderbox.TabIndex = 22;
            this.orderbox.TabStop = false;
            this.orderbox.Text = "Order Summary";
            this.orderbox.Enter += new System.EventHandler(this.orderbox_Enter);
            // 
            // toppinglb
            // 
            this.toppinglb.AutoSize = true;
            this.toppinglb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toppinglb.Location = new System.Drawing.Point(30, 117);
            this.toppinglb.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toppinglb.Name = "toppinglb";
            this.toppinglb.Size = new System.Drawing.Size(129, 25);
            this.toppinglb.TabIndex = 12;
            this.toppinglb.Text = "No Toppings.";
            this.toppinglb.Click += new System.EventHandler(this.toppinglb_Click);
            // 
            // pizzaorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PizzaOrder.Properties.Resources.Pepperoni_pizza_on_black_background_design_stock_images;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1075, 522);
            this.Controls.Add(this.orderbox);
            this.Controls.Add(this.maintitle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.gbwheretoeat);
            this.Controls.Add(this.gbcrust);
            this.Controls.Add(this.gbtopping);
            this.Controls.Add(this.gbsize);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pizzaorder";
            this.Text = "Pizza Order";
            this.Load += new System.EventHandler(this.PizzaMenu_Load);
            this.gbsize.ResumeLayout(false);
            this.gbsize.PerformLayout();
            this.gbtopping.ResumeLayout(false);
            this.gbtopping.PerformLayout();
            this.gbcrust.ResumeLayout(false);
            this.gbcrust.PerformLayout();
            this.gbwheretoeat.ResumeLayout(false);
            this.gbwheretoeat.PerformLayout();
            this.orderbox.ResumeLayout(false);
            this.orderbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbsize;
        private System.Windows.Forms.RadioButton rdlarge;
        private System.Windows.Forms.RadioButton rdmedium;
        private System.Windows.Forms.RadioButton rdsmall;
        private System.Windows.Forms.GroupBox gbtopping;
        private System.Windows.Forms.GroupBox gbcrust;
        private System.Windows.Forms.RadioButton rdthick;
        private System.Windows.Forms.RadioButton rdthin;
        private System.Windows.Forms.CheckBox chpepper;
        private System.Windows.Forms.CheckBox cholives;
        private System.Windows.Forms.CheckBox chonion;
        private System.Windows.Forms.CheckBox chtomato;
        private System.Windows.Forms.CheckBox chmushroom;
        private System.Windows.Forms.CheckBox chcheese;
        private System.Windows.Forms.GroupBox gbwheretoeat;
        private System.Windows.Forms.RadioButton rdtakeout;
        private System.Windows.Forms.RadioButton rdeatin;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label sizelb;
        private System.Windows.Forms.Label sizelabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label crustlb;
        private System.Windows.Forms.Label crustlabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label wtelabel;
        private System.Windows.Forms.Label maintitle;
        private System.Windows.Forms.Label pricelb;
        private System.Windows.Forms.Label totalpricelabel;
        private System.Windows.Forms.GroupBox orderbox;
        private System.Windows.Forms.Label toppinglb;
    }
}