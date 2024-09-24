namespace projPRG455
{
    partial class welcomePage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(welcomePage));
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxMin = new System.Windows.Forms.PictureBox();
            this.listBoxAccomodationType = new System.Windows.Forms.ListBox();
            this.vacationDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projEmreBaserDataSet1 = new projPRG455.projEmreBaserDataSet1();
            this.projEmreBaserDataSet = new projPRG455.projEmreBaserDataSet();
            this.vacationDataTableAdapter = new projPRG455.projEmreBaserDataSetTableAdapters.VacationDataTableAdapter();
            this.vacationDataTableAdapter1 = new projPRG455.projEmreBaserDataSet1TableAdapters.VacationDataTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.buttonProceedToCheckout = new System.Windows.Forms.Button();
            this.labelCostPerNight = new System.Windows.Forms.Label();
            this.labelDateAvailableTo = new System.Windows.Forms.Label();
            this.labelDateAvailableFrom = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelAccomodationType = new System.Windows.Forms.Label();
            this.pictureBoxAccomodationType = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projEmreBaserDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projEmreBaserDataSet)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccomodationType)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxExit.Image")));
            this.pictureBoxExit.Location = new System.Drawing.Point(598, 12);
            this.pictureBoxExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(43, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 0;
            this.pictureBoxExit.TabStop = false;
            // 
            // pictureBoxMin
            // 
            this.pictureBoxMin.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMin.Image")));
            this.pictureBoxMin.Location = new System.Drawing.Point(547, 12);
            this.pictureBoxMin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxMin.Name = "pictureBoxMin";
            this.pictureBoxMin.Size = new System.Drawing.Size(43, 40);
            this.pictureBoxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMin.TabIndex = 1;
            this.pictureBoxMin.TabStop = false;
            // 
            // listBoxAccomodationType
            // 
            this.listBoxAccomodationType.DataSource = this.vacationDataBindingSource1;
            this.listBoxAccomodationType.DisplayMember = "AccommodationType";
            this.listBoxAccomodationType.FormattingEnabled = true;
            this.listBoxAccomodationType.ItemHeight = 25;
            this.listBoxAccomodationType.Location = new System.Drawing.Point(25, 74);
            this.listBoxAccomodationType.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxAccomodationType.Name = "listBoxAccomodationType";
            this.listBoxAccomodationType.Size = new System.Drawing.Size(258, 154);
            this.listBoxAccomodationType.TabIndex = 2;
            this.listBoxAccomodationType.ValueMember = "RentalID";
            this.listBoxAccomodationType.SelectedIndexChanged += new System.EventHandler(this.listBoxAccomodationType_SelectedIndexChanged);
            // 
            // vacationDataBindingSource1
            // 
            this.vacationDataBindingSource1.DataMember = "VacationData";
            this.vacationDataBindingSource1.DataSource = this.projEmreBaserDataSet1;
            // 
            // projEmreBaserDataSet1
            // 
            this.projEmreBaserDataSet1.DataSetName = "projEmreBaserDataSet1";
            this.projEmreBaserDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projEmreBaserDataSet
            // 
            this.projEmreBaserDataSet.DataSetName = "projEmreBaserDataSet";
            this.projEmreBaserDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacationDataTableAdapter
            // 
            this.vacationDataTableAdapter.ClearBeforeFill = true;
            // 
            // vacationDataTableAdapter1
            // 
            this.vacationDataTableAdapter1.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Indigo;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Plum;
            this.textBox1.Location = new System.Drawing.Point(25, 19);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 49);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select Desired Accomadation and Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.Indigo;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.Thistle;
            this.buttonSearch.Location = new System.Drawing.Point(79, 234);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(141, 50);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "SEARCH";
            this.buttonSearch.UseVisualStyleBackColor = false;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.buttonProceedToCheckout);
            this.panelSearch.Controls.Add(this.labelCostPerNight);
            this.panelSearch.Controls.Add(this.labelDateAvailableTo);
            this.panelSearch.Controls.Add(this.labelDateAvailableFrom);
            this.panelSearch.Controls.Add(this.labelLocation);
            this.panelSearch.Controls.Add(this.labelAccomodationType);
            this.panelSearch.Controls.Add(this.pictureBoxAccomodationType);
            this.panelSearch.Location = new System.Drawing.Point(12, 320);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Padding = new System.Windows.Forms.Padding(10);
            this.panelSearch.Size = new System.Drawing.Size(668, 253);
            this.panelSearch.TabIndex = 5;
            // 
            // buttonProceedToCheckout
            // 
            this.buttonProceedToCheckout.BackColor = System.Drawing.Color.Indigo;
            this.buttonProceedToCheckout.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProceedToCheckout.ForeColor = System.Drawing.Color.Thistle;
            this.buttonProceedToCheckout.Location = new System.Drawing.Point(335, 184);
            this.buttonProceedToCheckout.Name = "buttonProceedToCheckout";
            this.buttonProceedToCheckout.Size = new System.Drawing.Size(278, 42);
            this.buttonProceedToCheckout.TabIndex = 6;
            this.buttonProceedToCheckout.Text = "Proceed To Checkout";
            this.buttonProceedToCheckout.UseVisualStyleBackColor = false;
            // 
            // labelCostPerNight
            // 
            this.labelCostPerNight.AutoSize = true;
            this.labelCostPerNight.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCostPerNight.Location = new System.Drawing.Point(368, 133);
            this.labelCostPerNight.Name = "labelCostPerNight";
            this.labelCostPerNight.Size = new System.Drawing.Size(53, 26);
            this.labelCostPerNight.TabIndex = 11;
            this.labelCostPerNight.Text = "Cost";
            // 
            // labelDateAvailableTo
            // 
            this.labelDateAvailableTo.AutoSize = true;
            this.labelDateAvailableTo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAvailableTo.Location = new System.Drawing.Point(298, 96);
            this.labelDateAvailableTo.Name = "labelDateAvailableTo";
            this.labelDateAvailableTo.Size = new System.Drawing.Size(181, 26);
            this.labelDateAvailableTo.TabIndex = 10;
            this.labelDateAvailableTo.Text = "Date Available To";
            // 
            // labelDateAvailableFrom
            // 
            this.labelDateAvailableFrom.AutoSize = true;
            this.labelDateAvailableFrom.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateAvailableFrom.Location = new System.Drawing.Point(298, 58);
            this.labelDateAvailableFrom.Name = "labelDateAvailableFrom";
            this.labelDateAvailableFrom.Size = new System.Drawing.Size(194, 26);
            this.labelDateAvailableFrom.TabIndex = 9;
            this.labelDateAvailableFrom.Text = "Date Availble From";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLocation.Location = new System.Drawing.Point(368, 29);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(93, 26);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Location";
            // 
            // labelAccomodationType
            // 
            this.labelAccomodationType.AutoSize = true;
            this.labelAccomodationType.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccomodationType.Location = new System.Drawing.Point(13, 10);
            this.labelAccomodationType.Name = "labelAccomodationType";
            this.labelAccomodationType.Size = new System.Drawing.Size(149, 26);
            this.labelAccomodationType.TabIndex = 7;
            this.labelAccomodationType.Text = "Accomodation";
            // 
            // pictureBoxAccomodationType
            // 
            this.pictureBoxAccomodationType.Location = new System.Drawing.Point(13, 39);
            this.pictureBoxAccomodationType.Name = "pictureBoxAccomodationType";
            this.pictureBoxAccomodationType.Size = new System.Drawing.Size(279, 201);
            this.pictureBoxAccomodationType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAccomodationType.TabIndex = 6;
            this.pictureBoxAccomodationType.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Indigo;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Plum;
            this.textBox2.Location = new System.Drawing.Point(347, 133);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(299, 95);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "The Vacation You Need is a few Click Away From You!!";
            // 
            // welcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(692, 598);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBoxAccomodationType);
            this.Controls.Add(this.pictureBoxMin);
            this.Controls.Add(this.pictureBoxExit);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "welcomePage";
            this.Load += new System.EventHandler(this.welcomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacationDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projEmreBaserDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projEmreBaserDataSet)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAccomodationType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.PictureBox pictureBoxMin;
        private System.Windows.Forms.ListBox listBoxAccomodationType;
        private projEmreBaserDataSet projEmreBaserDataSet;
        private projEmreBaserDataSetTableAdapters.VacationDataTableAdapter vacationDataTableAdapter;
        private projEmreBaserDataSet1 projEmreBaserDataSet1;
        private System.Windows.Forms.BindingSource vacationDataBindingSource1;
        private projEmreBaserDataSet1TableAdapters.VacationDataTableAdapter vacationDataTableAdapter1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBoxAccomodationType;
        private System.Windows.Forms.Label labelAccomodationType;
        private System.Windows.Forms.Button buttonProceedToCheckout;
        private System.Windows.Forms.Label labelCostPerNight;
        private System.Windows.Forms.Label labelDateAvailableTo;
        private System.Windows.Forms.Label labelDateAvailableFrom;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.TextBox textBox2;
    }
}

