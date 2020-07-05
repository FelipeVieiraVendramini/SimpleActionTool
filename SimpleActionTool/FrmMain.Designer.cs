namespace SimpleActionTool
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.numIdNext = new System.Windows.Forms.NumericUpDown();
            this.numIdNextFail = new System.Windows.Forms.NumericUpDown();
            this.numType = new System.Windows.Forms.NumericUpDown();
            this.numData = new System.Windows.Forms.NumericUpDown();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.txtReply0 = new System.Windows.Forms.TextBox();
            this.txtReply2 = new System.Windows.Forms.TextBox();
            this.txtReply4 = new System.Windows.Forms.TextBox();
            this.txtReply6 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cmbReplyType0 = new System.Windows.Forms.ComboBox();
            this.txtReply1 = new System.Windows.Forms.TextBox();
            this.txtReply3 = new System.Windows.Forms.TextBox();
            this.txtReply5 = new System.Windows.Forms.TextBox();
            this.txtReply7 = new System.Windows.Forms.TextBox();
            this.cmbReplyType1 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType2 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType3 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType4 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType5 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType6 = new System.Windows.Forms.ComboBox();
            this.cmbReplyType7 = new System.Windows.Forms.ComboBox();
            this.cmbFace = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNextFail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).BeginInit();
            this.SuspendLayout();
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(12, 12);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(105, 20);
            this.numId.TabIndex = 0;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            // 
            // numIdNext
            // 
            this.numIdNext.Location = new System.Drawing.Point(123, 12);
            this.numIdNext.Name = "numIdNext";
            this.numIdNext.Size = new System.Drawing.Size(105, 20);
            this.numIdNext.TabIndex = 1;
            // 
            // numIdNextFail
            // 
            this.numIdNextFail.Location = new System.Drawing.Point(234, 12);
            this.numIdNextFail.Name = "numIdNextFail";
            this.numIdNextFail.Size = new System.Drawing.Size(105, 20);
            this.numIdNextFail.TabIndex = 2;
            // 
            // numType
            // 
            this.numType.Location = new System.Drawing.Point(345, 12);
            this.numType.Name = "numType";
            this.numType.Size = new System.Drawing.Size(105, 20);
            this.numType.TabIndex = 3;
            this.numType.ValueChanged += new System.EventHandler(this.numType_ValueChanged);
            // 
            // numData
            // 
            this.numData.Location = new System.Drawing.Point(456, 12);
            this.numData.Name = "numData";
            this.numData.Size = new System.Drawing.Size(105, 20);
            this.numData.TabIndex = 4;
            // 
            // txtParam
            // 
            this.txtParam.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtParam.Location = new System.Drawing.Point(12, 38);
            this.txtParam.Multiline = true;
            this.txtParam.Name = "txtParam";
            this.txtParam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParam.Size = new System.Drawing.Size(549, 108);
            this.txtParam.TabIndex = 5;
            // 
            // txtReply0
            // 
            this.txtReply0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReply0.Location = new System.Drawing.Point(12, 152);
            this.txtReply0.Name = "txtReply0";
            this.txtReply0.Size = new System.Drawing.Size(151, 20);
            this.txtReply0.TabIndex = 6;
            this.txtReply0.TextChanged += new System.EventHandler(this.txtReply0_TextChanged);
            // 
            // txtReply2
            // 
            this.txtReply2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReply2.Location = new System.Drawing.Point(12, 178);
            this.txtReply2.Name = "txtReply2";
            this.txtReply2.Size = new System.Drawing.Size(151, 20);
            this.txtReply2.TabIndex = 10;
            this.txtReply2.TextChanged += new System.EventHandler(this.txtReply2_TextChanged);
            // 
            // txtReply4
            // 
            this.txtReply4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReply4.Location = new System.Drawing.Point(12, 204);
            this.txtReply4.Name = "txtReply4";
            this.txtReply4.Size = new System.Drawing.Size(151, 20);
            this.txtReply4.TabIndex = 14;
            this.txtReply4.TextChanged += new System.EventHandler(this.txtReply4_TextChanged);
            // 
            // txtReply6
            // 
            this.txtReply6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtReply6.Location = new System.Drawing.Point(12, 230);
            this.txtReply6.Name = "txtReply6";
            this.txtReply6.Size = new System.Drawing.Size(151, 20);
            this.txtReply6.TabIndex = 18;
            this.txtReply6.TextChanged += new System.EventHandler(this.txtReply6_TextChanged);
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResult.Location = new System.Drawing.Point(12, 291);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(548, 235);
            this.txtResult.TabIndex = 24;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(404, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 23;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cmbReplyType0
            // 
            this.cmbReplyType0.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReplyType0.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType0.FormattingEnabled = true;
            this.cmbReplyType0.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType0.Location = new System.Drawing.Point(169, 152);
            this.cmbReplyType0.Name = "cmbReplyType0";
            this.cmbReplyType0.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType0.TabIndex = 7;
            // 
            // txtReply1
            // 
            this.txtReply1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReply1.Location = new System.Drawing.Point(320, 152);
            this.txtReply1.Name = "txtReply1";
            this.txtReply1.Size = new System.Drawing.Size(151, 20);
            this.txtReply1.TabIndex = 8;
            this.txtReply1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtReply3
            // 
            this.txtReply3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReply3.Location = new System.Drawing.Point(320, 178);
            this.txtReply3.Name = "txtReply3";
            this.txtReply3.Size = new System.Drawing.Size(151, 20);
            this.txtReply3.TabIndex = 12;
            this.txtReply3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtReply5
            // 
            this.txtReply5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReply5.Location = new System.Drawing.Point(320, 204);
            this.txtReply5.Name = "txtReply5";
            this.txtReply5.Size = new System.Drawing.Size(151, 20);
            this.txtReply5.TabIndex = 16;
            this.txtReply5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtReply7
            // 
            this.txtReply7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReply7.Location = new System.Drawing.Point(320, 230);
            this.txtReply7.Name = "txtReply7";
            this.txtReply7.Size = new System.Drawing.Size(151, 20);
            this.txtReply7.TabIndex = 20;
            this.txtReply7.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // cmbReplyType1
            // 
            this.cmbReplyType1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReplyType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType1.FormattingEnabled = true;
            this.cmbReplyType1.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType1.Location = new System.Drawing.Point(481, 152);
            this.cmbReplyType1.Name = "cmbReplyType1";
            this.cmbReplyType1.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType1.TabIndex = 9;
            // 
            // cmbReplyType2
            // 
            this.cmbReplyType2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReplyType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType2.FormattingEnabled = true;
            this.cmbReplyType2.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType2.Location = new System.Drawing.Point(169, 179);
            this.cmbReplyType2.Name = "cmbReplyType2";
            this.cmbReplyType2.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType2.TabIndex = 11;
            // 
            // cmbReplyType3
            // 
            this.cmbReplyType3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReplyType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType3.FormattingEnabled = true;
            this.cmbReplyType3.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType3.Location = new System.Drawing.Point(481, 179);
            this.cmbReplyType3.Name = "cmbReplyType3";
            this.cmbReplyType3.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType3.TabIndex = 13;
            // 
            // cmbReplyType4
            // 
            this.cmbReplyType4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReplyType4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType4.FormattingEnabled = true;
            this.cmbReplyType4.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType4.Location = new System.Drawing.Point(169, 203);
            this.cmbReplyType4.Name = "cmbReplyType4";
            this.cmbReplyType4.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType4.TabIndex = 15;
            // 
            // cmbReplyType5
            // 
            this.cmbReplyType5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReplyType5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType5.FormattingEnabled = true;
            this.cmbReplyType5.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType5.Location = new System.Drawing.Point(481, 203);
            this.cmbReplyType5.Name = "cmbReplyType5";
            this.cmbReplyType5.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType5.TabIndex = 17;
            // 
            // cmbReplyType6
            // 
            this.cmbReplyType6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbReplyType6.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType6.FormattingEnabled = true;
            this.cmbReplyType6.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType6.Location = new System.Drawing.Point(169, 229);
            this.cmbReplyType6.Name = "cmbReplyType6";
            this.cmbReplyType6.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType6.TabIndex = 19;
            // 
            // cmbReplyType7
            // 
            this.cmbReplyType7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbReplyType7.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReplyType7.FormattingEnabled = true;
            this.cmbReplyType7.Items.AddRange(new object[] {
            "Text",
            "Input"});
            this.cmbReplyType7.Location = new System.Drawing.Point(481, 229);
            this.cmbReplyType7.Name = "cmbReplyType7";
            this.cmbReplyType7.Size = new System.Drawing.Size(79, 21);
            this.cmbReplyType7.TabIndex = 21;
            // 
            // cmbFace
            // 
            this.cmbFace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFace.FormattingEnabled = true;
            this.cmbFace.Items.AddRange(new object[] {
            "610001",
            "610002",
            "610003",
            "610004",
            "610005",
            "610006",
            "610007",
            "610008",
            "610009",
            "610010",
            "610012",
            "610013",
            "610014",
            "610015",
            "610016",
            "610017",
            "610018",
            "610019",
            "610020",
            "610021",
            "610022",
            "610023",
            "610024",
            "610025",
            "610026",
            "610027",
            "610028",
            "610029",
            "610030",
            "610031",
            "610032",
            "610033",
            "610034",
            "610035",
            "610036",
            "610037",
            "610038",
            "610039",
            "610040",
            "610041",
            "610042",
            "610043",
            "610044",
            "610045",
            "610046",
            "610047",
            "610048",
            "610049",
            "610050",
            "610051",
            "610052",
            "610053",
            "610054",
            "610055",
            "610056",
            "610057",
            "610058",
            "610059",
            "610060",
            "610061",
            "610062",
            "610063",
            "610064",
            "610065",
            "610066",
            "610067",
            "610068",
            "610069",
            "610070",
            "610071",
            "610072",
            "610073",
            "610074",
            "610075",
            "610076",
            "610077",
            "610078",
            "610079",
            "610080",
            "610081",
            "610082",
            "610083",
            "610084",
            "610085",
            "610086",
            "610087",
            "610088",
            "610089",
            "610090",
            "610091",
            "610092",
            "610093",
            "610094",
            "610095",
            "610096",
            "610097",
            "610098",
            "610099",
            "610100",
            "610101",
            "610102",
            "610103",
            "610104",
            "610105",
            "610106",
            "610107",
            "610108",
            "610109",
            "610110",
            "610111",
            "610112",
            "610113",
            "610114",
            "610115",
            "610116",
            "610117",
            "610118",
            "610119",
            "610120",
            "610121",
            "610122",
            "610123",
            "610124",
            "610125",
            "610126",
            "610127",
            "610128",
            "610129",
            "610130",
            "610131",
            "610132",
            "610133",
            "610134",
            "610135",
            "610136",
            "610137",
            "610138",
            "610139",
            "610140",
            "610141",
            "610142",
            "610143",
            "610144",
            "610145",
            "610146",
            "610147",
            "610148",
            "610149",
            "610150",
            "610151",
            "610152",
            "610153",
            "610154",
            "610155",
            "610156",
            "610157",
            "610158",
            "610159",
            "610160",
            "610161",
            "610162",
            "610163",
            "610164",
            "610165",
            "610166",
            "610167",
            "610168",
            "610169",
            "610170",
            "610171",
            "610172",
            "610173",
            "610174",
            "610175",
            "610176",
            "610177",
            "610178",
            "610179",
            "610180",
            "610181",
            "610182",
            "610183",
            "610184",
            "610185",
            "610186",
            "610187"});
            this.cmbFace.Location = new System.Drawing.Point(268, 258);
            this.cmbFace.Name = "cmbFace";
            this.cmbFace.Size = new System.Drawing.Size(121, 21);
            this.cmbFace.TabIndex = 22;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(485, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lookface";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFace);
            this.Controls.Add(this.cmbReplyType7);
            this.Controls.Add(this.cmbReplyType5);
            this.Controls.Add(this.cmbReplyType3);
            this.Controls.Add(this.cmbReplyType1);
            this.Controls.Add(this.cmbReplyType6);
            this.Controls.Add(this.cmbReplyType4);
            this.Controls.Add(this.cmbReplyType2);
            this.Controls.Add(this.cmbReplyType0);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtReply7);
            this.Controls.Add(this.txtReply6);
            this.Controls.Add(this.txtReply5);
            this.Controls.Add(this.txtReply4);
            this.Controls.Add(this.txtReply3);
            this.Controls.Add(this.txtReply2);
            this.Controls.Add(this.txtReply1);
            this.Controls.Add(this.txtReply0);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.numData);
            this.Controls.Add(this.numType);
            this.Controls.Add(this.numIdNextFail);
            this.Controls.Add(this.numIdNext);
            this.Controls.Add(this.numId);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIdNextFail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.NumericUpDown numIdNext;
        private System.Windows.Forms.NumericUpDown numIdNextFail;
        private System.Windows.Forms.NumericUpDown numType;
        private System.Windows.Forms.NumericUpDown numData;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtReply0;
        private System.Windows.Forms.TextBox txtReply2;
        private System.Windows.Forms.TextBox txtReply4;
        private System.Windows.Forms.TextBox txtReply6;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cmbReplyType0;
        private System.Windows.Forms.TextBox txtReply1;
        private System.Windows.Forms.TextBox txtReply3;
        private System.Windows.Forms.TextBox txtReply5;
        private System.Windows.Forms.TextBox txtReply7;
        private System.Windows.Forms.ComboBox cmbReplyType1;
        private System.Windows.Forms.ComboBox cmbReplyType2;
        private System.Windows.Forms.ComboBox cmbReplyType3;
        private System.Windows.Forms.ComboBox cmbReplyType4;
        private System.Windows.Forms.ComboBox cmbReplyType5;
        private System.Windows.Forms.ComboBox cmbReplyType6;
        private System.Windows.Forms.ComboBox cmbReplyType7;
        private System.Windows.Forms.ComboBox cmbFace;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
    }
}

