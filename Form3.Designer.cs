namespace Thread
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.alert = new System.Windows.Forms.TabPage();
            this.listViewLowStock = new System.Windows.Forms.ListView();
            this.GRNNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ArticleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MerchantName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WriteoffList = new System.Windows.Forms.TabPage();
            this.btnwriteoff = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.listViewWriteoff = new System.Windows.Forms.ListView();
            this.GRN_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Article = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Qty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GRN_Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.returnthread = new System.Windows.Forms.TabPage();
            this.rtxtAvailableQty = new System.Windows.Forms.TextBox();
            this.rtxtSelectedColor = new System.Windows.Forms.TextBox();
            this.rtxtSelectedArticle = new System.Windows.Forms.TextBox();
            this.rtxtSelectedGRN = new System.Windows.Forms.TextBox();
            this.list2 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.refilladd = new System.Windows.Forms.Button();
            this.refilsearch = new System.Windows.Forms.Button();
            this.refillqty = new System.Windows.Forms.TextBox();
            this.refilcolor = new System.Windows.Forms.TextBox();
            this.refilarticle = new System.Windows.Forms.TextBox();
            this.lbrefillqty = new System.Windows.Forms.Label();
            this.lbrefilcolor = new System.Windows.Forms.Label();
            this.lbrefillarticle = new System.Windows.Forms.Label();
            this.threadissue = new System.Windows.Forms.TabPage();
            this.styletx = new System.Windows.Forms.TextBox();
            this.stylenum = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.txtSelectedColor = new System.Windows.Forms.TextBox();
            this.txtSelectedArticle = new System.Windows.Forms.TextBox();
            this.txtSelectedGRN = new System.Windows.Forms.TextBox();
            this.issulist = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnissue = new System.Windows.Forms.Button();
            this.txtarticleiss = new System.Windows.Forms.TextBox();
            this.txtissuqty = new System.Windows.Forms.TextBox();
            this.txtcolorissu = new System.Windows.Forms.TextBox();
            this.lbissuqty = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchforissue = new System.Windows.Forms.Button();
            this.entGRN = new System.Windows.Forms.TabPage();
            this.logoutbutton = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnenter = new System.Windows.Forms.Button();
            this.grndatetime = new System.Windows.Forms.DateTimePicker();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.txtarticlenu = new System.Windows.Forms.TextBox();
            this.txtmerchant = new System.Windows.Forms.TextBox();
            this.txtlocation = new System.Windows.Forms.TextBox();
            this.txtuom = new System.Windows.Forms.TextBox();
            this.txtsupplier = new System.Windows.Forms.TextBox();
            this.txtgrnno = new System.Windows.Forms.TextBox();
            this.lbcolor = new System.Windows.Forms.Label();
            this.lbqty = new System.Windows.Forms.Label();
            this.lbarticlenum = new System.Windows.Forms.Label();
            this.lbmerchantname = new System.Windows.Forms.Label();
            this.lbloction = new System.Windows.Forms.Label();
            this.lbuom = new System.Windows.Forms.Label();
            this.lbsupplier = new System.Windows.Forms.Label();
            this.grndate = new System.Windows.Forms.Label();
            this.lbgrnnum = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.alert.SuspendLayout();
            this.WriteoffList.SuspendLayout();
            this.returnthread.SuspendLayout();
            this.threadissue.SuspendLayout();
            this.entGRN.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // alert
            // 
            this.alert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alert.BackgroundImage")));
            this.alert.Controls.Add(this.listViewLowStock);
            this.alert.Location = new System.Drawing.Point(4, 25);
            this.alert.Name = "alert";
            this.alert.Size = new System.Drawing.Size(935, 471);
            this.alert.TabIndex = 5;
            this.alert.Text = "Alert";
            this.alert.UseVisualStyleBackColor = true;
            // 
            // listViewLowStock
            // 
            this.listViewLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GRNNumber,
            this.ArticleName,
            this.color1,
            this.Qty1,
            this.MerchantName});
            this.listViewLowStock.FullRowSelect = true;
            this.listViewLowStock.GridLines = true;
            this.listViewLowStock.HideSelection = false;
            this.listViewLowStock.Location = new System.Drawing.Point(17, 12);
            this.listViewLowStock.Name = "listViewLowStock";
            this.listViewLowStock.Size = new System.Drawing.Size(824, 436);
            this.listViewLowStock.TabIndex = 0;
            this.listViewLowStock.UseCompatibleStateImageBehavior = false;
            this.listViewLowStock.View = System.Windows.Forms.View.Details;
            // 
            // GRNNumber
            // 
            this.GRNNumber.Text = "GRN Number";
            this.GRNNumber.Width = 133;
            // 
            // ArticleName
            // 
            this.ArticleName.Text = "Article Name";
            this.ArticleName.Width = 194;
            // 
            // color1
            // 
            this.color1.Text = "Color";
            this.color1.Width = 228;
            // 
            // Qty1
            // 
            this.Qty1.Text = "Qty";
            this.Qty1.Width = 76;
            // 
            // MerchantName
            // 
            this.MerchantName.Text = "Merchant Name";
            this.MerchantName.Width = 178;
            // 
            // WriteoffList
            // 
            this.WriteoffList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("WriteoffList.BackgroundImage")));
            this.WriteoffList.Controls.Add(this.btnwriteoff);
            this.WriteoffList.Controls.Add(this.btnfilter);
            this.WriteoffList.Controls.Add(this.listViewWriteoff);
            this.WriteoffList.Location = new System.Drawing.Point(4, 25);
            this.WriteoffList.Name = "WriteoffList";
            this.WriteoffList.Size = new System.Drawing.Size(935, 471);
            this.WriteoffList.TabIndex = 4;
            this.WriteoffList.Text = "Writeoff List";
            this.WriteoffList.UseVisualStyleBackColor = true;
            // 
            // btnwriteoff
            // 
            this.btnwriteoff.Location = new System.Drawing.Point(797, 363);
            this.btnwriteoff.Name = "btnwriteoff";
            this.btnwriteoff.Size = new System.Drawing.Size(75, 23);
            this.btnwriteoff.TabIndex = 2;
            this.btnwriteoff.Text = "Write off ";
            this.btnwriteoff.UseVisualStyleBackColor = true;
            this.btnwriteoff.Click += new System.EventHandler(this.btnwriteoff_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.Location = new System.Drawing.Point(3, 16);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(75, 23);
            this.btnfilter.TabIndex = 1;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = true;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // listViewWriteoff
            // 
            this.listViewWriteoff.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.GRN_Number,
            this.Article,
            this.Color,
            this.Qty,
            this.GRN_Date});
            this.listViewWriteoff.FullRowSelect = true;
            this.listViewWriteoff.GridLines = true;
            this.listViewWriteoff.HideSelection = false;
            this.listViewWriteoff.Location = new System.Drawing.Point(3, 45);
            this.listViewWriteoff.Name = "listViewWriteoff";
            this.listViewWriteoff.Size = new System.Drawing.Size(752, 423);
            this.listViewWriteoff.TabIndex = 0;
            this.listViewWriteoff.UseCompatibleStateImageBehavior = false;
            this.listViewWriteoff.View = System.Windows.Forms.View.Details;
            this.listViewWriteoff.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // GRN_Number
            // 
            this.GRN_Number.Text = "GRN Number";
            this.GRN_Number.Width = 131;
            // 
            // Article
            // 
            this.Article.Text = "Article";
            this.Article.Width = 172;
            // 
            // Color
            // 
            this.Color.Text = "Color";
            this.Color.Width = 228;
            // 
            // Qty
            // 
            this.Qty.Text = "Qty";
            this.Qty.Width = 76;
            // 
            // GRN_Date
            // 
            this.GRN_Date.Text = "GRN Date";
            this.GRN_Date.Width = 134;
            // 
            // returnthread
            // 
            this.returnthread.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("returnthread.BackgroundImage")));
            this.returnthread.Controls.Add(this.rtxtAvailableQty);
            this.returnthread.Controls.Add(this.rtxtSelectedColor);
            this.returnthread.Controls.Add(this.rtxtSelectedArticle);
            this.returnthread.Controls.Add(this.rtxtSelectedGRN);
            this.returnthread.Controls.Add(this.list2);
            this.returnthread.Controls.Add(this.listView2);
            this.returnthread.Controls.Add(this.refilladd);
            this.returnthread.Controls.Add(this.refilsearch);
            this.returnthread.Controls.Add(this.refillqty);
            this.returnthread.Controls.Add(this.refilcolor);
            this.returnthread.Controls.Add(this.refilarticle);
            this.returnthread.Controls.Add(this.lbrefillqty);
            this.returnthread.Controls.Add(this.lbrefilcolor);
            this.returnthread.Controls.Add(this.lbrefillarticle);
            this.returnthread.Location = new System.Drawing.Point(4, 25);
            this.returnthread.Name = "returnthread";
            this.returnthread.Size = new System.Drawing.Size(935, 471);
            this.returnthread.TabIndex = 2;
            this.returnthread.Text = "Return Thread";
            this.returnthread.UseVisualStyleBackColor = true;
            // 
            // rtxtAvailableQty
            // 
            this.rtxtAvailableQty.Location = new System.Drawing.Point(774, 240);
            this.rtxtAvailableQty.Name = "rtxtAvailableQty";
            this.rtxtAvailableQty.Size = new System.Drawing.Size(141, 22);
            this.rtxtAvailableQty.TabIndex = 13;
            // 
            // rtxtSelectedColor
            // 
            this.rtxtSelectedColor.Location = new System.Drawing.Point(774, 195);
            this.rtxtSelectedColor.Name = "rtxtSelectedColor";
            this.rtxtSelectedColor.Size = new System.Drawing.Size(141, 22);
            this.rtxtSelectedColor.TabIndex = 12;
            // 
            // rtxtSelectedArticle
            // 
            this.rtxtSelectedArticle.Location = new System.Drawing.Point(774, 152);
            this.rtxtSelectedArticle.Name = "rtxtSelectedArticle";
            this.rtxtSelectedArticle.Size = new System.Drawing.Size(141, 22);
            this.rtxtSelectedArticle.TabIndex = 11;
            // 
            // rtxtSelectedGRN
            // 
            this.rtxtSelectedGRN.Location = new System.Drawing.Point(774, 111);
            this.rtxtSelectedGRN.Name = "rtxtSelectedGRN";
            this.rtxtSelectedGRN.Size = new System.Drawing.Size(141, 22);
            this.rtxtSelectedGRN.TabIndex = 10;
            // 
            // list2
            // 
            this.list2.AutoSize = true;
            this.list2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list2.Location = new System.Drawing.Point(20, 92);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(31, 16);
            this.list2.TabIndex = 9;
            this.list2.Text = "List";
            // 
            // listView2
            // 
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(20, 111);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(718, 353);
            this.listView2.TabIndex = 8;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // refilladd
            // 
            this.refilladd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refilladd.Location = new System.Drawing.Point(760, 377);
            this.refilladd.Name = "refilladd";
            this.refilladd.Size = new System.Drawing.Size(84, 26);
            this.refilladd.TabIndex = 7;
            this.refilladd.Text = "Add";
            this.refilladd.UseVisualStyleBackColor = true;
            this.refilladd.Click += new System.EventHandler(this.refilladd_Click);
            // 
            // refilsearch
            // 
            this.refilsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refilsearch.Location = new System.Drawing.Point(806, 53);
            this.refilsearch.Name = "refilsearch";
            this.refilsearch.Size = new System.Drawing.Size(75, 28);
            this.refilsearch.TabIndex = 6;
            this.refilsearch.Text = "Search";
            this.refilsearch.UseVisualStyleBackColor = true;
            this.refilsearch.Click += new System.EventHandler(this.refilsearch_Click);
            // 
            // refillqty
            // 
            this.refillqty.Location = new System.Drawing.Point(760, 349);
            this.refillqty.Name = "refillqty";
            this.refillqty.Size = new System.Drawing.Size(168, 22);
            this.refillqty.TabIndex = 5;
            // 
            // refilcolor
            // 
            this.refilcolor.Location = new System.Drawing.Point(496, 54);
            this.refilcolor.Name = "refilcolor";
            this.refilcolor.Size = new System.Drawing.Size(273, 22);
            this.refilcolor.TabIndex = 4;
            // 
            // refilarticle
            // 
            this.refilarticle.Location = new System.Drawing.Point(114, 52);
            this.refilarticle.Name = "refilarticle";
            this.refilarticle.Size = new System.Drawing.Size(273, 22);
            this.refilarticle.TabIndex = 3;
            // 
            // lbrefillqty
            // 
            this.lbrefillqty.AutoSize = true;
            this.lbrefillqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefillqty.Location = new System.Drawing.Point(756, 326);
            this.lbrefillqty.Name = "lbrefillqty";
            this.lbrefillqty.Size = new System.Drawing.Size(87, 20);
            this.lbrefillqty.TabIndex = 2;
            this.lbrefillqty.Text = "Refill  Qty";
            // 
            // lbrefilcolor
            // 
            this.lbrefilcolor.AutoSize = true;
            this.lbrefilcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefilcolor.Location = new System.Drawing.Point(426, 57);
            this.lbrefilcolor.Name = "lbrefilcolor";
            this.lbrefilcolor.Size = new System.Drawing.Size(51, 20);
            this.lbrefilcolor.TabIndex = 1;
            this.lbrefilcolor.Text = "Color";
            // 
            // lbrefillarticle
            // 
            this.lbrefillarticle.AutoSize = true;
            this.lbrefillarticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbrefillarticle.Location = new System.Drawing.Point(33, 57);
            this.lbrefillarticle.Name = "lbrefillarticle";
            this.lbrefillarticle.Size = new System.Drawing.Size(82, 18);
            this.lbrefillarticle.TabIndex = 0;
            this.lbrefillarticle.Text = "Article No";
            // 
            // threadissue
            // 
            this.threadissue.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("threadissue.BackgroundImage")));
            this.threadissue.Controls.Add(this.styletx);
            this.threadissue.Controls.Add(this.stylenum);
            this.threadissue.Controls.Add(this.txtAvailableQty);
            this.threadissue.Controls.Add(this.txtSelectedColor);
            this.threadissue.Controls.Add(this.txtSelectedArticle);
            this.threadissue.Controls.Add(this.txtSelectedGRN);
            this.threadissue.Controls.Add(this.issulist);
            this.threadissue.Controls.Add(this.listView1);
            this.threadissue.Controls.Add(this.btnissue);
            this.threadissue.Controls.Add(this.txtarticleiss);
            this.threadissue.Controls.Add(this.txtissuqty);
            this.threadissue.Controls.Add(this.txtcolorissu);
            this.threadissue.Controls.Add(this.lbissuqty);
            this.threadissue.Controls.Add(this.label2);
            this.threadissue.Controls.Add(this.label1);
            this.threadissue.Controls.Add(this.searchforissue);
            this.threadissue.Location = new System.Drawing.Point(4, 25);
            this.threadissue.Name = "threadissue";
            this.threadissue.Padding = new System.Windows.Forms.Padding(3);
            this.threadissue.Size = new System.Drawing.Size(935, 471);
            this.threadissue.TabIndex = 1;
            this.threadissue.Text = "Thread Issue";
            this.threadissue.UseVisualStyleBackColor = true;
            // 
            // styletx
            // 
            this.styletx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.styletx.Location = new System.Drawing.Point(816, 378);
            this.styletx.Name = "styletx";
            this.styletx.Size = new System.Drawing.Size(100, 20);
            this.styletx.TabIndex = 16;
            // 
            // stylenum
            // 
            this.stylenum.AutoSize = true;
            this.stylenum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylenum.Location = new System.Drawing.Point(729, 383);
            this.stylenum.Name = "stylenum";
            this.stylenum.Size = new System.Drawing.Size(49, 20);
            this.stylenum.TabIndex = 15;
            this.stylenum.Text = "Style";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQty.Location = new System.Drawing.Point(765, 227);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.Size = new System.Drawing.Size(128, 20);
            this.txtAvailableQty.TabIndex = 14;
            // 
            // txtSelectedColor
            // 
            this.txtSelectedColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedColor.Location = new System.Drawing.Point(765, 185);
            this.txtSelectedColor.Name = "txtSelectedColor";
            this.txtSelectedColor.Size = new System.Drawing.Size(128, 20);
            this.txtSelectedColor.TabIndex = 13;
            // 
            // txtSelectedArticle
            // 
            this.txtSelectedArticle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedArticle.Location = new System.Drawing.Point(765, 141);
            this.txtSelectedArticle.Name = "txtSelectedArticle";
            this.txtSelectedArticle.Size = new System.Drawing.Size(128, 20);
            this.txtSelectedArticle.TabIndex = 12;
            // 
            // txtSelectedGRN
            // 
            this.txtSelectedGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedGRN.Location = new System.Drawing.Point(765, 99);
            this.txtSelectedGRN.Name = "txtSelectedGRN";
            this.txtSelectedGRN.Size = new System.Drawing.Size(128, 20);
            this.txtSelectedGRN.TabIndex = 11;
            // 
            // issulist
            // 
            this.issulist.AutoSize = true;
            this.issulist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issulist.Location = new System.Drawing.Point(25, 99);
            this.issulist.Name = "issulist";
            this.issulist.Size = new System.Drawing.Size(31, 16);
            this.issulist.TabIndex = 10;
            this.issulist.Text = "List";
            // 
            // listView1
            // 
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 118);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(682, 346);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btnissue
            // 
            this.btnissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissue.Location = new System.Drawing.Point(729, 417);
            this.btnissue.Name = "btnissue";
            this.btnissue.Size = new System.Drawing.Size(86, 31);
            this.btnissue.TabIndex = 8;
            this.btnissue.Text = "Issue";
            this.btnissue.UseVisualStyleBackColor = true;
            this.btnissue.Click += new System.EventHandler(this.btnissue_Click);
            // 
            // txtarticleiss
            // 
            this.txtarticleiss.Location = new System.Drawing.Point(471, 38);
            this.txtarticleiss.Name = "txtarticleiss";
            this.txtarticleiss.Size = new System.Drawing.Size(236, 22);
            this.txtarticleiss.TabIndex = 7;
            // 
            // txtissuqty
            // 
            this.txtissuqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtissuqty.Location = new System.Drawing.Point(816, 335);
            this.txtissuqty.Name = "txtissuqty";
            this.txtissuqty.Size = new System.Drawing.Size(100, 20);
            this.txtissuqty.TabIndex = 6;
            // 
            // txtcolorissu
            // 
            this.txtcolorissu.Location = new System.Drawing.Point(89, 38);
            this.txtcolorissu.Name = "txtcolorissu";
            this.txtcolorissu.Size = new System.Drawing.Size(236, 22);
            this.txtcolorissu.TabIndex = 4;
            // 
            // lbissuqty
            // 
            this.lbissuqty.AutoSize = true;
            this.lbissuqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbissuqty.Location = new System.Drawing.Point(725, 335);
            this.lbissuqty.Name = "lbissuqty";
            this.lbissuqty.Size = new System.Drawing.Size(85, 20);
            this.lbissuqty.TabIndex = 3;
            this.lbissuqty.Text = "Issue Qty";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Article";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Color";
            // 
            // searchforissue
            // 
            this.searchforissue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchforissue.Location = new System.Drawing.Point(765, 35);
            this.searchforissue.Name = "searchforissue";
            this.searchforissue.Size = new System.Drawing.Size(105, 29);
            this.searchforissue.TabIndex = 0;
            this.searchforissue.Text = "Search";
            this.searchforissue.UseVisualStyleBackColor = true;
            this.searchforissue.Click += new System.EventHandler(this.searchforissue_Click);
            // 
            // entGRN
            // 
            this.entGRN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("entGRN.BackgroundImage")));
            this.entGRN.Controls.Add(this.logoutbutton);
            this.entGRN.Controls.Add(this.btnreset);
            this.entGRN.Controls.Add(this.btnenter);
            this.entGRN.Controls.Add(this.grndatetime);
            this.entGRN.Controls.Add(this.txtcolor);
            this.entGRN.Controls.Add(this.txtqty);
            this.entGRN.Controls.Add(this.txtarticlenu);
            this.entGRN.Controls.Add(this.txtmerchant);
            this.entGRN.Controls.Add(this.txtlocation);
            this.entGRN.Controls.Add(this.txtuom);
            this.entGRN.Controls.Add(this.txtsupplier);
            this.entGRN.Controls.Add(this.txtgrnno);
            this.entGRN.Controls.Add(this.lbcolor);
            this.entGRN.Controls.Add(this.lbqty);
            this.entGRN.Controls.Add(this.lbarticlenum);
            this.entGRN.Controls.Add(this.lbmerchantname);
            this.entGRN.Controls.Add(this.lbloction);
            this.entGRN.Controls.Add(this.lbuom);
            this.entGRN.Controls.Add(this.lbsupplier);
            this.entGRN.Controls.Add(this.grndate);
            this.entGRN.Controls.Add(this.lbgrnnum);
            this.entGRN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entGRN.Location = new System.Drawing.Point(4, 25);
            this.entGRN.Name = "entGRN";
            this.entGRN.Padding = new System.Windows.Forms.Padding(3);
            this.entGRN.Size = new System.Drawing.Size(935, 471);
            this.entGRN.TabIndex = 0;
            this.entGRN.Text = "Enter GRN";
            this.entGRN.UseVisualStyleBackColor = true;
            this.entGRN.Click += new System.EventHandler(this.entGRN_Click);
            // 
            // logoutbutton
            // 
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutbutton.Image = ((System.Drawing.Image)(resources.GetObject("logoutbutton.Image")));
            this.logoutbutton.Location = new System.Drawing.Point(872, 3);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(56, 45);
            this.logoutbutton.TabIndex = 21;
            this.logoutbutton.Text = "Logout";
            this.logoutbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutbutton.UseVisualStyleBackColor = false;
            this.logoutbutton.Click += new System.EventHandler(this.logoutbutton_Click);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(532, 402);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(119, 29);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnenter
            // 
            this.btnenter.Location = new System.Drawing.Point(685, 394);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(152, 45);
            this.btnenter.TabIndex = 19;
            this.btnenter.Text = "Enter System";
            this.btnenter.UseVisualStyleBackColor = true;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // grndatetime
            // 
            this.grndatetime.CustomFormat = "yyyy MM dd hh:mm:ss";
            this.grndatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grndatetime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.grndatetime.Location = new System.Drawing.Point(138, 103);
            this.grndatetime.Name = "grndatetime";
            this.grndatetime.Size = new System.Drawing.Size(225, 22);
            this.grndatetime.TabIndex = 18;
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcolor.Location = new System.Drawing.Point(507, 306);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(345, 22);
            this.txtcolor.TabIndex = 17;
            this.txtcolor.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(598, 219);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(106, 22);
            this.txtqty.TabIndex = 16;
            // 
            // txtarticlenu
            // 
            this.txtarticlenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarticlenu.Location = new System.Drawing.Point(553, 141);
            this.txtarticlenu.Name = "txtarticlenu";
            this.txtarticlenu.Size = new System.Drawing.Size(345, 22);
            this.txtarticlenu.TabIndex = 15;
            // 
            // txtmerchant
            // 
            this.txtmerchant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmerchant.Location = new System.Drawing.Point(553, 57);
            this.txtmerchant.Name = "txtmerchant";
            this.txtmerchant.Size = new System.Drawing.Size(345, 22);
            this.txtmerchant.TabIndex = 14;
            // 
            // txtlocation
            // 
            this.txtlocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlocation.Location = new System.Drawing.Point(118, 358);
            this.txtlocation.Name = "txtlocation";
            this.txtlocation.Size = new System.Drawing.Size(345, 22);
            this.txtlocation.TabIndex = 13;
            // 
            // txtuom
            // 
            this.txtuom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuom.Location = new System.Drawing.Point(118, 261);
            this.txtuom.Name = "txtuom";
            this.txtuom.Size = new System.Drawing.Size(212, 22);
            this.txtuom.TabIndex = 12;
            // 
            // txtsupplier
            // 
            this.txtsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsupplier.Location = new System.Drawing.Point(118, 181);
            this.txtsupplier.Name = "txtsupplier";
            this.txtsupplier.Size = new System.Drawing.Size(345, 22);
            this.txtsupplier.TabIndex = 11;
            // 
            // txtgrnno
            // 
            this.txtgrnno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgrnno.Location = new System.Drawing.Point(138, 17);
            this.txtgrnno.Name = "txtgrnno";
            this.txtgrnno.Size = new System.Drawing.Size(156, 22);
            this.txtgrnno.TabIndex = 9;
            // 
            // lbcolor
            // 
            this.lbcolor.AutoSize = true;
            this.lbcolor.Location = new System.Drawing.Point(440, 308);
            this.lbcolor.Name = "lbcolor";
            this.lbcolor.Size = new System.Drawing.Size(51, 20);
            this.lbcolor.TabIndex = 8;
            this.lbcolor.Text = "Color";
            this.lbcolor.Click += new System.EventHandler(this.lbcolor_Click);
            // 
            // lbqty
            // 
            this.lbqty.AutoSize = true;
            this.lbqty.Location = new System.Drawing.Point(549, 221);
            this.lbqty.Name = "lbqty";
            this.lbqty.Size = new System.Drawing.Size(36, 20);
            this.lbqty.TabIndex = 7;
            this.lbqty.Text = "Qty";
            // 
            // lbarticlenum
            // 
            this.lbarticlenum.AutoSize = true;
            this.lbarticlenum.Location = new System.Drawing.Point(429, 143);
            this.lbarticlenum.Name = "lbarticlenum";
            this.lbarticlenum.Size = new System.Drawing.Size(111, 20);
            this.lbarticlenum.TabIndex = 6;
            this.lbarticlenum.Text = "Article Name";
            // 
            // lbmerchantname
            // 
            this.lbmerchantname.AutoSize = true;
            this.lbmerchantname.Location = new System.Drawing.Point(405, 59);
            this.lbmerchantname.Name = "lbmerchantname";
            this.lbmerchantname.Size = new System.Drawing.Size(135, 20);
            this.lbmerchantname.TabIndex = 5;
            this.lbmerchantname.Text = "Merchant Name";
            // 
            // lbloction
            // 
            this.lbloction.AutoSize = true;
            this.lbloction.Location = new System.Drawing.Point(19, 364);
            this.lbloction.Name = "lbloction";
            this.lbloction.Size = new System.Drawing.Size(78, 20);
            this.lbloction.TabIndex = 4;
            this.lbloction.Text = "Location";
            // 
            // lbuom
            // 
            this.lbuom.AutoSize = true;
            this.lbuom.Location = new System.Drawing.Point(19, 267);
            this.lbuom.Name = "lbuom";
            this.lbuom.Size = new System.Drawing.Size(49, 20);
            this.lbuom.TabIndex = 3;
            this.lbuom.Text = "UOM";
            // 
            // lbsupplier
            // 
            this.lbsupplier.AutoSize = true;
            this.lbsupplier.Location = new System.Drawing.Point(19, 184);
            this.lbsupplier.Name = "lbsupplier";
            this.lbsupplier.Size = new System.Drawing.Size(75, 20);
            this.lbsupplier.TabIndex = 2;
            this.lbsupplier.Text = "Supplier";
            // 
            // grndate
            // 
            this.grndate.AutoSize = true;
            this.grndate.Location = new System.Drawing.Point(19, 104);
            this.grndate.Name = "grndate";
            this.grndate.Size = new System.Drawing.Size(92, 20);
            this.grndate.TabIndex = 1;
            this.grndate.Text = "GRN Date";
            // 
            // lbgrnnum
            // 
            this.lbgrnnum.AutoSize = true;
            this.lbgrnnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgrnnum.Location = new System.Drawing.Point(8, 23);
            this.lbgrnnum.Name = "lbgrnnum";
            this.lbgrnnum.Size = new System.Drawing.Size(115, 20);
            this.lbgrnnum.TabIndex = 0;
            this.lbgrnnum.Text = "GRN Number";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.entGRN);
            this.tabControl1.Controls.Add(this.threadissue);
            this.tabControl1.Controls.Add(this.returnthread);
            this.tabControl1.Controls.Add(this.WriteoffList);
            this.tabControl1.Controls.Add(this.alert);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(76, 21);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(943, 500);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 501);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.alert.ResumeLayout(false);
            this.WriteoffList.ResumeLayout(false);
            this.returnthread.ResumeLayout(false);
            this.returnthread.PerformLayout();
            this.threadissue.ResumeLayout(false);
            this.threadissue.PerformLayout();
            this.entGRN.ResumeLayout(false);
            this.entGRN.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage alert;
        private System.Windows.Forms.TabPage WriteoffList;
        private System.Windows.Forms.TabPage returnthread;
        private System.Windows.Forms.Label list2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button refilladd;
        private System.Windows.Forms.Button refilsearch;
        private System.Windows.Forms.TextBox refillqty;
        private System.Windows.Forms.TextBox refilcolor;
        private System.Windows.Forms.TextBox refilarticle;
        private System.Windows.Forms.Label lbrefillqty;
        private System.Windows.Forms.Label lbrefilcolor;
        private System.Windows.Forms.Label lbrefillarticle;
        private System.Windows.Forms.TabPage threadissue;
        private System.Windows.Forms.Label issulist;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnissue;
        private System.Windows.Forms.TextBox txtarticleiss;
        private System.Windows.Forms.TextBox txtissuqty;
        private System.Windows.Forms.TextBox txtcolorissu;
        private System.Windows.Forms.Label lbissuqty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchforissue;
        private System.Windows.Forms.TabPage entGRN;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.DateTimePicker grndatetime;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.TextBox txtarticlenu;
        private System.Windows.Forms.TextBox txtmerchant;
        private System.Windows.Forms.TextBox txtuom;
        private System.Windows.Forms.TextBox txtsupplier;
        private System.Windows.Forms.TextBox txtgrnno;
        private System.Windows.Forms.Label lbcolor;
        private System.Windows.Forms.Label lbqty;
        private System.Windows.Forms.Label lbarticlenum;
        private System.Windows.Forms.Label lbmerchantname;
        private System.Windows.Forms.Label lbloction;
        private System.Windows.Forms.Label lbuom;
        private System.Windows.Forms.Label lbsupplier;
        private System.Windows.Forms.Label grndate;
        private System.Windows.Forms.Label lbgrnnum;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtlocation;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtAvailableQty;
        private System.Windows.Forms.TextBox txtSelectedColor;
        private System.Windows.Forms.TextBox txtSelectedArticle;
        private System.Windows.Forms.TextBox txtSelectedGRN;
        private System.Windows.Forms.TextBox rtxtAvailableQty;
        private System.Windows.Forms.TextBox rtxtSelectedColor;
        private System.Windows.Forms.TextBox rtxtSelectedArticle;
        private System.Windows.Forms.TextBox rtxtSelectedGRN;
        private System.Windows.Forms.TextBox styletx;
        private System.Windows.Forms.Label stylenum;
        private System.Windows.Forms.ListView listViewWriteoff;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.ColumnHeader GRN_Number;
        private System.Windows.Forms.ColumnHeader Article;
        private System.Windows.Forms.ColumnHeader Color;
        private System.Windows.Forms.ColumnHeader Qty;
        private System.Windows.Forms.ColumnHeader GRN_Date;
        private System.Windows.Forms.Button btnwriteoff;
        private System.Windows.Forms.Button logoutbutton;
        private System.Windows.Forms.ListView listViewLowStock;
        private System.Windows.Forms.ColumnHeader GRNNumber;
        private System.Windows.Forms.ColumnHeader ArticleName;
        private System.Windows.Forms.ColumnHeader color1;
        private System.Windows.Forms.ColumnHeader Qty1;
        private System.Windows.Forms.ColumnHeader MerchantName;
    }
}