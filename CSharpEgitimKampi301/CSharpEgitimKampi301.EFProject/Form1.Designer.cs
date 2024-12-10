namespace CSharpEgitimKampi301.EFProject
{
    partial class Form1
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
            this.lblGuideId = new System.Windows.Forms.Label();
            this.tbxRGuideId = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.tbxGuideName = new System.Windows.Forms.TextBox();
            this.lblGuideName = new System.Windows.Forms.Label();
            this.tbxGuideSurname = new System.Windows.Forms.TextBox();
            this.lblGuideSurname = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGuideId
            // 
            this.lblGuideId.AutoSize = true;
            this.lblGuideId.Location = new System.Drawing.Point(35, 30);
            this.lblGuideId.Name = "lblGuideId";
            this.lblGuideId.Size = new System.Drawing.Size(57, 13);
            this.lblGuideId.TabIndex = 0;
            this.lblGuideId.Text = "Rehber Id:";
            // 
            // tbxRGuideId
            // 
            this.tbxRGuideId.Location = new System.Drawing.Point(94, 30);
            this.tbxRGuideId.Name = "tbxRGuideId";
            this.tbxRGuideId.Size = new System.Drawing.Size(181, 20);
            this.tbxRGuideId.TabIndex = 1;
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(94, 143);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(181, 33);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // dgvList
            // 
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Location = new System.Drawing.Point(297, 30);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(491, 302);
            this.dgvList.TabIndex = 3;
            // 
            // tbxGuideName
            // 
            this.tbxGuideName.Location = new System.Drawing.Point(94, 66);
            this.tbxGuideName.Name = "tbxGuideName";
            this.tbxGuideName.Size = new System.Drawing.Size(181, 20);
            this.tbxGuideName.TabIndex = 5;
            // 
            // lblGuideName
            // 
            this.lblGuideName.AutoSize = true;
            this.lblGuideName.Location = new System.Drawing.Point(29, 66);
            this.lblGuideName.Name = "lblGuideName";
            this.lblGuideName.Size = new System.Drawing.Size(63, 13);
            this.lblGuideName.TabIndex = 4;
            this.lblGuideName.Text = "Rehber Adı:";
            // 
            // tbxGuideSurname
            // 
            this.tbxGuideSurname.Location = new System.Drawing.Point(94, 104);
            this.tbxGuideSurname.Name = "tbxGuideSurname";
            this.tbxGuideSurname.Size = new System.Drawing.Size(181, 20);
            this.tbxGuideSurname.TabIndex = 7;
            // 
            // lblGuideSurname
            // 
            this.lblGuideSurname.AutoSize = true;
            this.lblGuideSurname.Location = new System.Drawing.Point(12, 104);
            this.lblGuideSurname.Name = "lblGuideSurname";
            this.lblGuideSurname.Size = new System.Drawing.Size(80, 13);
            this.lblGuideSurname.TabIndex = 6;
            this.lblGuideSurname.Text = "Rehber Soyadı:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(94, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(181, 33);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(181, 33);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 260);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(181, 33);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGetById
            // 
            this.btnGetById.Location = new System.Drawing.Point(94, 299);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(181, 33);
            this.btnGetById.TabIndex = 11;
            this.btnGetById.Text = "Id\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = true;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbxGuideSurname);
            this.Controls.Add(this.lblGuideSurname);
            this.Controls.Add(this.tbxGuideName);
            this.Controls.Add(this.lblGuideName);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.tbxRGuideId);
            this.Controls.Add(this.lblGuideId);
            this.Name = "Form1";
            this.Text = "Rehber İşlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuideId;
        private System.Windows.Forms.TextBox tbxRGuideId;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TextBox tbxGuideName;
        private System.Windows.Forms.Label lblGuideName;
        private System.Windows.Forms.TextBox tbxGuideSurname;
        private System.Windows.Forms.Label lblGuideSurname;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGetById;
    }
}

