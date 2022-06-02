
namespace InterfataUtilizator
{
    partial class departmentsForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbSearchDepartment = new System.Windows.Forms.GroupBox();
            this.dgvSearchEmployee = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbShowDepartments = new System.Windows.Forms.GroupBox();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.btnShowDepartments = new System.Windows.Forms.Button();
            this.grbAddAndUpdateDepartment = new System.Windows.Forms.GroupBox();
            this.lblManagerId = new System.Windows.Forms.Label();
            this.txtManagerId = new System.Windows.Forms.TextBox();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.lblDepartmentTitle = new System.Windows.Forms.Label();
            this.txtDepartmentTitle = new System.Windows.Forms.TextBox();
            this.grbSearchDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).BeginInit();
            this.grbShowDepartments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.grbAddAndUpdateDepartment.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearchDepartment
            // 
            this.grbSearchDepartment.Controls.Add(this.dgvSearchEmployee);
            this.grbSearchDepartment.Controls.Add(this.btnSearch);
            this.grbSearchDepartment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSearchDepartment.ForeColor = System.Drawing.Color.White;
            this.grbSearchDepartment.Location = new System.Drawing.Point(281, 12);
            this.grbSearchDepartment.Name = "grbSearchDepartment";
            this.grbSearchDepartment.Size = new System.Drawing.Size(842, 202);
            this.grbSearchDepartment.TabIndex = 32;
            this.grbSearchDepartment.TabStop = false;
            this.grbSearchDepartment.Text = "Search employee";
            // 
            // dgvSearchEmployee
            // 
            this.dgvSearchEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearchEmployee.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSearchEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSearchEmployee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSearchEmployee.Location = new System.Drawing.Point(6, 64);
            this.dgvSearchEmployee.Name = "dgvSearchEmployee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearchEmployee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearchEmployee.Size = new System.Drawing.Size(828, 123);
            this.dgvSearchEmployee.TabIndex = 7;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(748, 25);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 32);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // grbShowDepartments
            // 
            this.grbShowDepartments.Controls.Add(this.btnDeleteDepartment);
            this.grbShowDepartments.Controls.Add(this.dgvDepartments);
            this.grbShowDepartments.Controls.Add(this.btnShowDepartments);
            this.grbShowDepartments.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShowDepartments.ForeColor = System.Drawing.Color.White;
            this.grbShowDepartments.Location = new System.Drawing.Point(281, 213);
            this.grbShowDepartments.Name = "grbShowDepartments";
            this.grbShowDepartments.Size = new System.Drawing.Size(842, 322);
            this.grbShowDepartments.TabIndex = 31;
            this.grbShowDepartments.TabStop = false;
            this.grbShowDepartments.Text = "Show Departments";
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepartment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartment.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepartment.Location = new System.Drawing.Point(6, 283);
            this.btnDeleteDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(86, 32);
            this.btnDeleteDepartment.TabIndex = 8;
            this.btnDeleteDepartment.Text = "Delete";
            this.btnDeleteDepartment.UseVisualStyleBackColor = false;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDepartments.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDepartments.Location = new System.Drawing.Point(6, 23);
            this.dgvDepartments.Name = "dgvDepartments";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDepartments.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDepartments.Size = new System.Drawing.Size(828, 253);
            this.dgvDepartments.TabIndex = 6;
            this.dgvDepartments.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDepartments_CellContentClick);
            // 
            // btnShowDepartments
            // 
            this.btnShowDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnShowDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowDepartments.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowDepartments.ForeColor = System.Drawing.Color.White;
            this.btnShowDepartments.Location = new System.Drawing.Point(748, 284);
            this.btnShowDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowDepartments.Name = "btnShowDepartments";
            this.btnShowDepartments.Size = new System.Drawing.Size(86, 32);
            this.btnShowDepartments.TabIndex = 5;
            this.btnShowDepartments.Text = "Show";
            this.btnShowDepartments.UseVisualStyleBackColor = false;
            this.btnShowDepartments.Click += new System.EventHandler(this.btnShowDepartments_Click);
            // 
            // grbAddAndUpdateDepartment
            // 
            this.grbAddAndUpdateDepartment.Controls.Add(this.lblManagerId);
            this.grbAddAndUpdateDepartment.Controls.Add(this.txtManagerId);
            this.grbAddAndUpdateDepartment.Controls.Add(this.btnUpdateDepartment);
            this.grbAddAndUpdateDepartment.Controls.Add(this.lblMessage);
            this.grbAddAndUpdateDepartment.Controls.Add(this.lblMesaj);
            this.grbAddAndUpdateDepartment.Controls.Add(this.btnAddDepartment);
            this.grbAddAndUpdateDepartment.Controls.Add(this.lblDepartmentTitle);
            this.grbAddAndUpdateDepartment.Controls.Add(this.txtDepartmentTitle);
            this.grbAddAndUpdateDepartment.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddAndUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.grbAddAndUpdateDepartment.Location = new System.Drawing.Point(14, 12);
            this.grbAddAndUpdateDepartment.Name = "grbAddAndUpdateDepartment";
            this.grbAddAndUpdateDepartment.Size = new System.Drawing.Size(254, 523);
            this.grbAddAndUpdateDepartment.TabIndex = 30;
            this.grbAddAndUpdateDepartment.TabStop = false;
            this.grbAddAndUpdateDepartment.Text = "Add/Update department";
            // 
            // lblManagerId
            // 
            this.lblManagerId.AutoSize = true;
            this.lblManagerId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManagerId.ForeColor = System.Drawing.Color.White;
            this.lblManagerId.Location = new System.Drawing.Point(8, 115);
            this.lblManagerId.Name = "lblManagerId";
            this.lblManagerId.Size = new System.Drawing.Size(104, 21);
            this.lblManagerId.TabIndex = 45;
            this.lblManagerId.Text = "Manager ID";
            // 
            // txtManagerId
            // 
            this.txtManagerId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtManagerId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManagerId.ForeColor = System.Drawing.Color.White;
            this.txtManagerId.Location = new System.Drawing.Point(131, 115);
            this.txtManagerId.MaxLength = 30;
            this.txtManagerId.Name = "txtManagerId";
            this.txtManagerId.Size = new System.Drawing.Size(117, 27);
            this.txtManagerId.TabIndex = 46;
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDepartment.Location = new System.Drawing.Point(12, 484);
            this.btnUpdateDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateDepartment.TabIndex = 44;
            this.btnUpdateDepartment.Text = "Update";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(7, 416);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 42;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaj.Location = new System.Drawing.Point(35, 201);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(0, 17);
            this.lblMesaj.TabIndex = 18;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(173, 484);
            this.btnAddDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(75, 32);
            this.btnAddDepartment.TabIndex = 4;
            this.btnAddDepartment.Text = "Add";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click_1);
            // 
            // lblDepartmentTitle
            // 
            this.lblDepartmentTitle.AutoSize = true;
            this.lblDepartmentTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentTitle.ForeColor = System.Drawing.Color.White;
            this.lblDepartmentTitle.Location = new System.Drawing.Point(8, 64);
            this.lblDepartmentTitle.Name = "lblDepartmentTitle";
            this.lblDepartmentTitle.Size = new System.Drawing.Size(41, 21);
            this.lblDepartmentTitle.TabIndex = 10;
            this.lblDepartmentTitle.Text = "Title";
            // 
            // txtDepartmentTitle
            // 
            this.txtDepartmentTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDepartmentTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartmentTitle.ForeColor = System.Drawing.Color.White;
            this.txtDepartmentTitle.Location = new System.Drawing.Point(66, 61);
            this.txtDepartmentTitle.MaxLength = 30;
            this.txtDepartmentTitle.Name = "txtDepartmentTitle";
            this.txtDepartmentTitle.Size = new System.Drawing.Size(184, 27);
            this.txtDepartmentTitle.TabIndex = 11;
            // 
            // departmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.grbSearchDepartment);
            this.Controls.Add(this.grbShowDepartments);
            this.Controls.Add(this.grbAddAndUpdateDepartment);
            this.Name = "departmentsForm";
            this.Size = new System.Drawing.Size(1136, 547);
            this.grbSearchDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchEmployee)).EndInit();
            this.grbShowDepartments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.grbAddAndUpdateDepartment.ResumeLayout(false);
            this.grbAddAndUpdateDepartment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearchDepartment;
        private System.Windows.Forms.DataGridView dgvSearchEmployee;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grbShowDepartments;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Button btnShowDepartments;
        private System.Windows.Forms.GroupBox grbAddAndUpdateDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Label lblDepartmentTitle;
        private System.Windows.Forms.TextBox txtDepartmentTitle;
        private System.Windows.Forms.Label lblManagerId;
        private System.Windows.Forms.TextBox txtManagerId;
    }
}
