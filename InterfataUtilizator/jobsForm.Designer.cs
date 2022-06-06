
namespace InterfataUtilizator
{
    partial class jobsForm
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
            this.grbShowRoles = new System.Windows.Forms.GroupBox();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.btnShowRoles = new System.Windows.Forms.Button();
            this.grbAddAndUpdateRole = new System.Windows.Forms.GroupBox();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblMessageRole = new System.Windows.Forms.Label();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.lblRoleTitle = new System.Windows.Forms.Label();
            this.txtRoleTitle = new System.Windows.Forms.TextBox();
            this.lblNumberOfRoles = new System.Windows.Forms.Label();
            this.grbShowRoles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.grbAddAndUpdateRole.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbShowRoles
            // 
            this.grbShowRoles.Controls.Add(this.btnDeleteRole);
            this.grbShowRoles.Controls.Add(this.dgvRoles);
            this.grbShowRoles.Controls.Add(this.btnShowRoles);
            this.grbShowRoles.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShowRoles.ForeColor = System.Drawing.Color.White;
            this.grbShowRoles.Location = new System.Drawing.Point(281, 55);
            this.grbShowRoles.Name = "grbShowRoles";
            this.grbShowRoles.Size = new System.Drawing.Size(842, 480);
            this.grbShowRoles.TabIndex = 28;
            this.grbShowRoles.TabStop = false;
            this.grbShowRoles.Text = "Show Roles";
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRole.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRole.ForeColor = System.Drawing.Color.White;
            this.btnDeleteRole.Location = new System.Drawing.Point(6, 441);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(86, 32);
            this.btnDeleteRole.TabIndex = 8;
            this.btnDeleteRole.Text = "Delete";
            this.btnDeleteRole.UseVisualStyleBackColor = false;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // dgvRoles
            // 
            this.dgvRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRoles.Location = new System.Drawing.Point(6, 23);
            this.dgvRoles.Name = "dgvRoles";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRoles.Size = new System.Drawing.Size(828, 411);
            this.dgvRoles.TabIndex = 6;
            this.dgvRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoles_CellContentClick);
            // 
            // btnShowRoles
            // 
            this.btnShowRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnShowRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowRoles.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowRoles.ForeColor = System.Drawing.Color.White;
            this.btnShowRoles.Location = new System.Drawing.Point(748, 441);
            this.btnShowRoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowRoles.Name = "btnShowRoles";
            this.btnShowRoles.Size = new System.Drawing.Size(86, 32);
            this.btnShowRoles.TabIndex = 5;
            this.btnShowRoles.Text = "Show";
            this.btnShowRoles.UseVisualStyleBackColor = false;
            this.btnShowRoles.Click += new System.EventHandler(this.btnShowRoles_Click);
            // 
            // grbAddAndUpdateRole
            // 
            this.grbAddAndUpdateRole.Controls.Add(this.btnUpdateRole);
            this.grbAddAndUpdateRole.Controls.Add(this.lblMessage);
            this.grbAddAndUpdateRole.Controls.Add(this.lblMessageRole);
            this.grbAddAndUpdateRole.Controls.Add(this.btnAddRole);
            this.grbAddAndUpdateRole.Controls.Add(this.lblRoleTitle);
            this.grbAddAndUpdateRole.Controls.Add(this.txtRoleTitle);
            this.grbAddAndUpdateRole.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddAndUpdateRole.ForeColor = System.Drawing.Color.White;
            this.grbAddAndUpdateRole.Location = new System.Drawing.Point(14, 12);
            this.grbAddAndUpdateRole.Name = "grbAddAndUpdateRole";
            this.grbAddAndUpdateRole.Size = new System.Drawing.Size(254, 189);
            this.grbAddAndUpdateRole.TabIndex = 27;
            this.grbAddAndUpdateRole.TabStop = false;
            this.grbAddAndUpdateRole.Text = "Add/Update Role";
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdateRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateRole.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateRole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateRole.Location = new System.Drawing.Point(12, 150);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateRole.TabIndex = 44;
            this.btnUpdateRole.Text = "Update";
            this.btnUpdateRole.UseVisualStyleBackColor = false;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
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
            // lblMessageRole
            // 
            this.lblMessageRole.AutoSize = true;
            this.lblMessageRole.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageRole.Location = new System.Drawing.Point(16, 114);
            this.lblMessageRole.Name = "lblMessageRole";
            this.lblMessageRole.Size = new System.Drawing.Size(0, 17);
            this.lblMessageRole.TabIndex = 18;
            // 
            // btnAddRole
            // 
            this.btnAddRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRole.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRole.ForeColor = System.Drawing.Color.White;
            this.btnAddRole.Location = new System.Drawing.Point(172, 150);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(75, 32);
            this.btnAddRole.TabIndex = 4;
            this.btnAddRole.Text = "Add";
            this.btnAddRole.UseVisualStyleBackColor = false;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // lblRoleTitle
            // 
            this.lblRoleTitle.AutoSize = true;
            this.lblRoleTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoleTitle.ForeColor = System.Drawing.Color.White;
            this.lblRoleTitle.Location = new System.Drawing.Point(8, 43);
            this.lblRoleTitle.Name = "lblRoleTitle";
            this.lblRoleTitle.Size = new System.Drawing.Size(77, 21);
            this.lblRoleTitle.TabIndex = 10;
            this.lblRoleTitle.Text = "Role title";
            // 
            // txtRoleTitle
            // 
            this.txtRoleTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtRoleTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoleTitle.ForeColor = System.Drawing.Color.White;
            this.txtRoleTitle.Location = new System.Drawing.Point(12, 70);
            this.txtRoleTitle.MaxLength = 30;
            this.txtRoleTitle.Name = "txtRoleTitle";
            this.txtRoleTitle.Size = new System.Drawing.Size(236, 27);
            this.txtRoleTitle.TabIndex = 11;
            // 
            // lblNumberOfRoles
            // 
            this.lblNumberOfRoles.AutoSize = true;
            this.lblNumberOfRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.lblNumberOfRoles.ForeColor = System.Drawing.Color.White;
            this.lblNumberOfRoles.Location = new System.Drawing.Point(274, 24);
            this.lblNumberOfRoles.Name = "lblNumberOfRoles";
            this.lblNumberOfRoles.Size = new System.Drawing.Size(70, 26);
            this.lblNumberOfRoles.TabIndex = 29;
            this.lblNumberOfRoles.Text = "label1";
            // 
            // jobsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.lblNumberOfRoles);
            this.Controls.Add(this.grbShowRoles);
            this.Controls.Add(this.grbAddAndUpdateRole);
            this.Name = "jobsForm";
            this.Size = new System.Drawing.Size(1136, 547);
            this.grbShowRoles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.grbAddAndUpdateRole.ResumeLayout(false);
            this.grbAddAndUpdateRole.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grbShowRoles;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button btnShowRoles;
        private System.Windows.Forms.GroupBox grbAddAndUpdateRole;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Label lblMessageRole;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblRoleTitle;
        private System.Windows.Forms.TextBox txtRoleTitle;
        private System.Windows.Forms.Label lblNumberOfRoles;
    }
}
