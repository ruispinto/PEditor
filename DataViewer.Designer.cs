
namespace PEditor
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cardsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seriesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conditionItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageTypeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materialItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orientationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.publisherItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sentTypeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.languagesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differencesItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridCard = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.lbl_cardCounter = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lblCards = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPostcardNumber = new System.Windows.Forms.Label();
            this.lblRowNumber = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnBlog = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chkDelete = new System.Windows.Forms.CheckBox();
            this.sFDialog = new System.Windows.Forms.SaveFileDialog();
            this.dataGridExport = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cardsItem,
            this.seriesItem,
            this.tablesItem,
            this.changeLanguage,
            this.aboutItem,
            this.exitItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuOptions";
            // 
            // cardsItem
            // 
            this.cardsItem.BackColor = System.Drawing.SystemColors.Control;
            this.cardsItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cardsItem.Name = "cardsItem";
            this.cardsItem.Size = new System.Drawing.Size(79, 23);
            this.cardsItem.Text = "Postcards";
            this.cardsItem.Click += new System.EventHandler(this.cardsItem_Click);
            // 
            // seriesItem
            // 
            this.seriesItem.BackColor = System.Drawing.SystemColors.Control;
            this.seriesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.seriesItem.Name = "seriesItem";
            this.seriesItem.Size = new System.Drawing.Size(56, 23);
            this.seriesItem.Text = "Series";
            this.seriesItem.Click += new System.EventHandler(this.seriesItem_Click);
            // 
            // tablesItem
            // 
            this.tablesItem.BackColor = System.Drawing.SystemColors.Control;
            this.tablesItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorItem,
            this.conditionItem,
            this.countryItem,
            this.imageTypeItem,
            this.materialItem,
            this.orientationItem,
            this.publisherItem,
            this.sentTypeItem,
            this.shapeItem,
            this.sizeItem,
            this.themeItem,
            this.yearItem,
            this.toolStripSeparator1,
            this.languagesItem,
            this.labelsItem,
            this.differencesItem});
            this.tablesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tablesItem.Name = "tablesItem";
            this.tablesItem.Size = new System.Drawing.Size(57, 23);
            this.tablesItem.Text = "Tables";
            // 
            // colorItem
            // 
            this.colorItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.colorItem.Name = "colorItem";
            this.colorItem.Size = new System.Drawing.Size(148, 24);
            this.colorItem.Text = "Color";
            this.colorItem.Click += new System.EventHandler(this.colorItem_Click);
            // 
            // conditionItem
            // 
            this.conditionItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.conditionItem.Name = "conditionItem";
            this.conditionItem.Size = new System.Drawing.Size(148, 24);
            this.conditionItem.Text = "Condition";
            this.conditionItem.Click += new System.EventHandler(this.conditionItem_Click);
            // 
            // countryItem
            // 
            this.countryItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.countryItem.Name = "countryItem";
            this.countryItem.Size = new System.Drawing.Size(148, 24);
            this.countryItem.Text = "Country";
            this.countryItem.Click += new System.EventHandler(this.countryItem_Click);
            // 
            // imageTypeItem
            // 
            this.imageTypeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.imageTypeItem.Name = "imageTypeItem";
            this.imageTypeItem.Size = new System.Drawing.Size(148, 24);
            this.imageTypeItem.Text = "Image Type";
            this.imageTypeItem.Click += new System.EventHandler(this.imageTypeItem_Click);
            // 
            // materialItem
            // 
            this.materialItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialItem.Name = "materialItem";
            this.materialItem.Size = new System.Drawing.Size(148, 24);
            this.materialItem.Text = "Material";
            this.materialItem.Click += new System.EventHandler(this.materialItem_Click);
            // 
            // orientationItem
            // 
            this.orientationItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.orientationItem.Name = "orientationItem";
            this.orientationItem.Size = new System.Drawing.Size(148, 24);
            this.orientationItem.Text = "Orientation";
            this.orientationItem.Click += new System.EventHandler(this.orientationItem_Click);
            // 
            // publisherItem
            // 
            this.publisherItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.publisherItem.Name = "publisherItem";
            this.publisherItem.Size = new System.Drawing.Size(148, 24);
            this.publisherItem.Text = "Publisher";
            this.publisherItem.Click += new System.EventHandler(this.publisherItem_Click);
            // 
            // sentTypeItem
            // 
            this.sentTypeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sentTypeItem.Name = "sentTypeItem";
            this.sentTypeItem.Size = new System.Drawing.Size(148, 24);
            this.sentTypeItem.Text = "Sent Type";
            this.sentTypeItem.Click += new System.EventHandler(this.sentTypeItem_Click);
            // 
            // shapeItem
            // 
            this.shapeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.shapeItem.Name = "shapeItem";
            this.shapeItem.Size = new System.Drawing.Size(148, 24);
            this.shapeItem.Text = "Shape";
            this.shapeItem.Click += new System.EventHandler(this.shapeItem_Click);
            // 
            // sizeItem
            // 
            this.sizeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sizeItem.Name = "sizeItem";
            this.sizeItem.Size = new System.Drawing.Size(148, 24);
            this.sizeItem.Text = "Size";
            this.sizeItem.Click += new System.EventHandler(this.sizeItem_Click);
            // 
            // themeItem
            // 
            this.themeItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.themeItem.Name = "themeItem";
            this.themeItem.Size = new System.Drawing.Size(148, 24);
            this.themeItem.Text = "Theme";
            this.themeItem.Click += new System.EventHandler(this.themeItem_Click);
            // 
            // yearItem
            // 
            this.yearItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.yearItem.Name = "yearItem";
            this.yearItem.Size = new System.Drawing.Size(148, 24);
            this.yearItem.Text = "Year";
            this.yearItem.Click += new System.EventHandler(this.yearItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // languagesItem
            // 
            this.languagesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.languagesItem.Name = "languagesItem";
            this.languagesItem.Size = new System.Drawing.Size(148, 24);
            this.languagesItem.Text = "Languages";
            this.languagesItem.Click += new System.EventHandler(this.languagesItem_Click);
            // 
            // labelsItem
            // 
            this.labelsItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelsItem.Name = "labelsItem";
            this.labelsItem.Size = new System.Drawing.Size(148, 24);
            this.labelsItem.Text = "Labels";
            this.labelsItem.Click += new System.EventHandler(this.labelsItem_Click);
            // 
            // differencesItem
            // 
            this.differencesItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.differencesItem.Name = "differencesItem";
            this.differencesItem.Size = new System.Drawing.Size(148, 24);
            this.differencesItem.Text = "Differences";
            this.differencesItem.Visible = false;
            // 
            // changeLanguage
            // 
            this.changeLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.changeLanguage.Name = "changeLanguage";
            this.changeLanguage.Size = new System.Drawing.Size(51, 23);
            this.changeLanguage.Text = "Lang";
            this.changeLanguage.Click += new System.EventHandler(this.changeLanguage_Click);
            // 
            // aboutItem
            // 
            this.aboutItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.aboutItem.Name = "aboutItem";
            this.aboutItem.Size = new System.Drawing.Size(59, 23);
            this.aboutItem.Text = "About";
            this.aboutItem.Click += new System.EventHandler(this.aboutItem_Click);
            // 
            // exitItem
            // 
            this.exitItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exitItem.Name = "exitItem";
            this.exitItem.Size = new System.Drawing.Size(42, 23);
            this.exitItem.Text = "Exit";
            this.exitItem.Click += new System.EventHandler(this.exitItem_Click);
            // 
            // dataGridCard
            // 
            this.dataGridCard.AllowUserToAddRows = false;
            this.dataGridCard.AllowUserToDeleteRows = false;
            this.dataGridCard.AllowUserToResizeRows = false;
            this.dataGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridCard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridCard.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCard.GridColor = System.Drawing.Color.Gray;
            this.dataGridCard.Location = new System.Drawing.Point(11, 67);
            this.dataGridCard.MultiSelect = false;
            this.dataGridCard.Name = "dataGridCard";
            this.dataGridCard.ReadOnly = true;
            this.dataGridCard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridCard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCard.ShowCellErrors = false;
            this.dataGridCard.ShowCellToolTips = false;
            this.dataGridCard.ShowEditingIcon = false;
            this.dataGridCard.ShowRowErrors = false;
            this.dataGridCard.Size = new System.Drawing.Size(916, 406);
            this.dataGridCard.TabIndex = 0;
            this.dataGridCard.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateCellLocation);
            this.dataGridCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.updateCellLocation);
            this.dataGridCard.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._viewCard);
            this.dataGridCard.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._viewCard);
            this.dataGridCard.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.updateCellLocation);
            this.dataGridCard.KeyDown += new System.Windows.Forms.KeyEventHandler(this.updateCellLocation);
            this.dataGridCard.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            this.dataGridCard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.updateCellLocation);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.lbl_cardCounter);
            this.panel1.Controls.Add(this.btn_search);
            this.panel1.Controls.Add(this.txt_search);
            this.panel1.Controls.Add(this.lblCards);
            this.panel1.Location = new System.Drawing.Point(11, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 35);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(423, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 26);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lbl_cardCounter
            // 
            this.lbl_cardCounter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_cardCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cardCounter.Location = new System.Drawing.Point(784, 6);
            this.lbl_cardCounter.Name = "lbl_cardCounter";
            this.lbl_cardCounter.Size = new System.Drawing.Size(68, 22);
            this.lbl_cardCounter.TabIndex = 0;
            this.lbl_cardCounter.Text = "0";
            this.lbl_cardCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.Black;
            this.btn_search.Location = new System.Drawing.Point(327, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(85, 26);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txt_search.Location = new System.Drawing.Point(9, 5);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(312, 23);
            this.txt_search.TabIndex = 1;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this._chkKeyPressed);
            // 
            // lblCards
            // 
            this.lblCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCards.Location = new System.Drawing.Point(849, 9);
            this.lblCards.Name = "lblCards";
            this.lblCards.Size = new System.Drawing.Size(59, 15);
            this.lblCards.TabIndex = 0;
            this.lblCards.Text = "postcards";
            this.lblCards.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.lblPostcardNumber);
            this.panel2.Controls.Add(this.lblRowNumber);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(11, 479);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 35);
            this.panel2.TabIndex = 0;
            // 
            // lblPostcardNumber
            // 
            this.lblPostcardNumber.AutoSize = true;
            this.lblPostcardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblPostcardNumber.ForeColor = System.Drawing.Color.Silver;
            this.lblPostcardNumber.Location = new System.Drawing.Point(6, 18);
            this.lblPostcardNumber.Name = "lblPostcardNumber";
            this.lblPostcardNumber.Size = new System.Drawing.Size(89, 13);
            this.lblPostcardNumber.TabIndex = 0;
            this.lblPostcardNumber.Text = "Postcard Number";
            this.lblPostcardNumber.Visible = false;
            // 
            // lblRowNumber
            // 
            this.lblRowNumber.AutoSize = true;
            this.lblRowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblRowNumber.ForeColor = System.Drawing.Color.Silver;
            this.lblRowNumber.Location = new System.Drawing.Point(6, 2);
            this.lblRowNumber.Name = "lblRowNumber";
            this.lblRowNumber.Size = new System.Drawing.Size(29, 13);
            this.lblRowNumber.TabIndex = 0;
            this.lblRowNumber.Text = "Row";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(516, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 26);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdd.Location = new System.Drawing.Point(426, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 26);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.btnBlog);
            this.panel3.Controls.Add(this.btnExport);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.chkDelete);
            this.panel3.Location = new System.Drawing.Point(629, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 35);
            this.panel3.TabIndex = 5;
            // 
            // btnBlog
            // 
            this.btnBlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBlog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBlog.Location = new System.Drawing.Point(211, 4);
            this.btnBlog.Name = "btnBlog";
            this.btnBlog.Size = new System.Drawing.Size(85, 26);
            this.btnBlog.TabIndex = 9;
            this.btnBlog.Text = "Blog";
            this.btnBlog.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBlog.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExport.Location = new System.Drawing.Point(120, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(85, 26);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Export";
            this.btnExport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(23, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 26);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // chkDelete
            // 
            this.chkDelete.AutoSize = true;
            this.chkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkDelete.Location = new System.Drawing.Point(3, 12);
            this.chkDelete.Name = "chkDelete";
            this.chkDelete.Size = new System.Drawing.Size(15, 14);
            this.chkDelete.TabIndex = 6;
            this.chkDelete.UseVisualStyleBackColor = true;
            this.chkDelete.CheckedChanged += new System.EventHandler(this.chkDelete_CheckedChanged);
            // 
            // dataGridExport
            // 
            this.dataGridExport.AllowUserToAddRows = false;
            this.dataGridExport.AllowUserToDeleteRows = false;
            this.dataGridExport.AllowUserToResizeRows = false;
            this.dataGridExport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridExport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridExport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridExport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridExport.GridColor = System.Drawing.Color.Gray;
            this.dataGridExport.Location = new System.Drawing.Point(11, 67);
            this.dataGridExport.MultiSelect = false;
            this.dataGridExport.Name = "dataGridExport";
            this.dataGridExport.ReadOnly = true;
            this.dataGridExport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridExport.ShowCellErrors = false;
            this.dataGridExport.ShowCellToolTips = false;
            this.dataGridExport.ShowEditingIcon = false;
            this.dataGridExport.ShowRowErrors = false;
            this.dataGridExport.Size = new System.Drawing.Size(916, 406);
            this.dataGridExport.TabIndex = 6;
            this.dataGridExport.Visible = false;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(939, 518);
            this.Controls.Add(this.dataGridExport);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridCard);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(955, 539);
            this.Name = "DataViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Postcards Catalog Editor";
            this.Load += new System.EventHandler(this.DataViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCard)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cardsItem;
        private System.Windows.Forms.ToolStripMenuItem seriesItem;
        private System.Windows.Forms.ToolStripMenuItem exitItem;
        private System.Windows.Forms.ToolStripMenuItem aboutItem;
        private System.Windows.Forms.DataGridView dataGridCard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_cardCounter;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lblCards;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripMenuItem changeLanguage;
        private System.Windows.Forms.ToolStripMenuItem tablesItem;
        private System.Windows.Forms.ToolStripMenuItem colorItem;
        private System.Windows.Forms.ToolStripMenuItem conditionItem;
        private System.Windows.Forms.ToolStripMenuItem countryItem;
        private System.Windows.Forms.ToolStripMenuItem imageTypeItem;
        private System.Windows.Forms.ToolStripMenuItem materialItem;
        private System.Windows.Forms.ToolStripMenuItem orientationItem;
        private System.Windows.Forms.ToolStripMenuItem publisherItem;
        private System.Windows.Forms.ToolStripMenuItem sentTypeItem;
        private System.Windows.Forms.ToolStripMenuItem shapeItem;
        private System.Windows.Forms.ToolStripMenuItem sizeItem;
        private System.Windows.Forms.ToolStripMenuItem themeItem;
        private System.Windows.Forms.ToolStripMenuItem yearItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBlog;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox chkDelete;
        private System.Windows.Forms.Label lblPostcardNumber;
        private System.Windows.Forms.Label lblRowNumber;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem languagesItem;
        private System.Windows.Forms.ToolStripMenuItem labelsItem;
        private System.Windows.Forms.ToolStripMenuItem differencesItem;
        private System.Windows.Forms.SaveFileDialog sFDialog;
        private System.Windows.Forms.DataGridView dataGridExport;
    }
}