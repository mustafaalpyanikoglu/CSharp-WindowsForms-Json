namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.getAllBtn = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.txtResponce = new System.Windows.Forms.RichTextBox();
            this.getBtn = new System.Windows.Forms.Button();
            this.postBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.jobTextBox = new System.Windows.Forms.TextBox();
            this.putBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.colorIdTextBox = new System.Windows.Forms.TextBox();
            this.brandIdTextBox = new System.Windows.Forms.TextBox();
            this.dailyPriceTextBox = new System.Windows.Forms.TextBox();
            this.modelYearTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // getAllBtn
            // 
            this.getAllBtn.Location = new System.Drawing.Point(12, 37);
            this.getAllBtn.Name = "getAllBtn";
            this.getAllBtn.Size = new System.Drawing.Size(164, 73);
            this.getAllBtn.TabIndex = 0;
            this.getAllBtn.Text = "Get All";
            this.getAllBtn.UseVisualStyleBackColor = true;
            this.getAllBtn.Click += new System.EventHandler(this.getAllBtn_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(182, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(177, 27);
            this.idTextBox.TabIndex = 1;
            // 
            // txtResponce
            // 
            this.txtResponce.Location = new System.Drawing.Point(12, 263);
            this.txtResponce.Name = "txtResponce";
            this.txtResponce.Size = new System.Drawing.Size(1161, 387);
            this.txtResponce.TabIndex = 2;
            this.txtResponce.Text = "";
            // 
            // getBtn
            // 
            this.getBtn.Location = new System.Drawing.Point(182, 70);
            this.getBtn.Name = "getBtn";
            this.getBtn.Size = new System.Drawing.Size(177, 40);
            this.getBtn.TabIndex = 3;
            this.getBtn.Text = "Get";
            this.getBtn.UseVisualStyleBackColor = true;
            this.getBtn.Click += new System.EventHandler(this.getBtn_Click);
            // 
            // postBtn
            // 
            this.postBtn.Location = new System.Drawing.Point(694, 37);
            this.postBtn.Name = "postBtn";
            this.postBtn.Size = new System.Drawing.Size(131, 73);
            this.postBtn.TabIndex = 5;
            this.postBtn.Text = "Post";
            this.postBtn.UseVisualStyleBackColor = true;
            this.postBtn.Click += new System.EventHandler(this.postBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(511, 43);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(177, 27);
            this.nameTextBox.TabIndex = 4;
            // 
            // jobTextBox
            // 
            this.jobTextBox.Location = new System.Drawing.Point(511, 83);
            this.jobTextBox.Name = "jobTextBox";
            this.jobTextBox.Size = new System.Drawing.Size(177, 27);
            this.jobTextBox.TabIndex = 6;
            // 
            // putBtn
            // 
            this.putBtn.Location = new System.Drawing.Point(831, 37);
            this.putBtn.Name = "putBtn";
            this.putBtn.Size = new System.Drawing.Size(131, 73);
            this.putBtn.TabIndex = 7;
            this.putBtn.Text = "Put";
            this.putBtn.UseVisualStyleBackColor = true;
            this.putBtn.Click += new System.EventHandler(this.putBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(968, 37);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(131, 73);
            this.deleteBtn.TabIndex = 8;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // colorIdTextBox
            // 
            this.colorIdTextBox.Location = new System.Drawing.Point(1116, 77);
            this.colorIdTextBox.Name = "colorIdTextBox";
            this.colorIdTextBox.Size = new System.Drawing.Size(177, 27);
            this.colorIdTextBox.TabIndex = 10;
            // 
            // brandIdTextBox
            // 
            this.brandIdTextBox.Location = new System.Drawing.Point(1116, 37);
            this.brandIdTextBox.Name = "brandIdTextBox";
            this.brandIdTextBox.Size = new System.Drawing.Size(177, 27);
            this.brandIdTextBox.TabIndex = 9;
            // 
            // dailyPriceTextBox
            // 
            this.dailyPriceTextBox.Location = new System.Drawing.Point(1116, 164);
            this.dailyPriceTextBox.Name = "dailyPriceTextBox";
            this.dailyPriceTextBox.Size = new System.Drawing.Size(177, 27);
            this.dailyPriceTextBox.TabIndex = 12;
            // 
            // modelYearTextBox
            // 
            this.modelYearTextBox.Location = new System.Drawing.Point(1116, 124);
            this.modelYearTextBox.Name = "modelYearTextBox";
            this.modelYearTextBox.Size = new System.Drawing.Size(177, 27);
            this.modelYearTextBox.TabIndex = 11;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(1116, 209);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(177, 27);
            this.descriptionTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 850);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.dailyPriceTextBox);
            this.Controls.Add(this.modelYearTextBox);
            this.Controls.Add(this.colorIdTextBox);
            this.Controls.Add(this.brandIdTextBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.putBtn);
            this.Controls.Add(this.jobTextBox);
            this.Controls.Add(this.postBtn);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.getBtn);
            this.Controls.Add(this.txtResponce);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.getAllBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button getAllBtn;
        private TextBox idTextBox;
        private RichTextBox txtResponce;
        private Button getBtn;
        private Button postBtn;
        private TextBox nameTextBox;
        private TextBox jobTextBox;
        private Button putBtn;
        private Button deleteBtn;
        private TextBox colorIdTextBox;
        private TextBox brandIdTextBox;
        private TextBox dailyPriceTextBox;
        private TextBox modelYearTextBox;
        private TextBox descriptionTextBox;
    }
}