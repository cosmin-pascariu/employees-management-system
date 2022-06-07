
namespace InterfataUtilizator
{
    partial class employeeInDepartmentForm
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
            this.grbAsignEmployee = new System.Windows.Forms.GroupBox();
            this.rdbN = new System.Windows.Forms.RadioButton();
            this.rdbY = new System.Windows.Forms.RadioButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployeeStatus = new System.Windows.Forms.Label();
            this.lblEmployeeStopDate = new System.Windows.Forms.Label();
            this.dtpEmployeeStopDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployeeStartDate = new System.Windows.Forms.Label();
            this.dtpEmployeeStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.grbShowEmployees = new System.Windows.Forms.GroupBox();
            this.btnDeleteEmployee = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnShowEmployees = new System.Windows.Forms.Button();
            this.grbAsignEmployee.SuspendLayout();
            this.grbShowEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAsignEmployee
            // 
            this.grbAsignEmployee.Controls.Add(this.rdbN);
            this.grbAsignEmployee.Controls.Add(this.rdbY);
            this.grbAsignEmployee.Controls.Add(this.cmbRole);
            this.grbAsignEmployee.Controls.Add(this.cmbDepartment);
            this.grbAsignEmployee.Controls.Add(this.btnUpdateEmployee);
            this.grbAsignEmployee.Controls.Add(this.lblMessage);
            this.grbAsignEmployee.Controls.Add(this.cmbEmployee);
            this.grbAsignEmployee.Controls.Add(this.lblEmployeeStatus);
            this.grbAsignEmployee.Controls.Add(this.lblEmployeeStopDate);
            this.grbAsignEmployee.Controls.Add(this.dtpEmployeeStopDate);
            this.grbAsignEmployee.Controls.Add(this.lblEmployeeStartDate);
            this.grbAsignEmployee.Controls.Add(this.dtpEmployeeStartDate);
            this.grbAsignEmployee.Controls.Add(this.lblRole);
            this.grbAsignEmployee.Controls.Add(this.lblMesaj);
            this.grbAsignEmployee.Controls.Add(this.btnAddEmployee);
            this.grbAsignEmployee.Controls.Add(this.lblDepartment);
            this.grbAsignEmployee.Controls.Add(this.lblEmployee);
            this.grbAsignEmployee.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAsignEmployee.ForeColor = System.Drawing.Color.White;
            this.grbAsignEmployee.Location = new System.Drawing.Point(16, 7);
            this.grbAsignEmployee.Name = "grbAsignEmployee";
            this.grbAsignEmployee.Size = new System.Drawing.Size(254, 523);
            this.grbAsignEmployee.TabIndex = 25;
            this.grbAsignEmployee.TabStop = false;
            this.grbAsignEmployee.Text = " Asign Employee";
            // 
            // rdbN
            // 
            this.rdbN.AutoSize = true;
            this.rdbN.Location = new System.Drawing.Point(148, 397);
            this.rdbN.Name = "rdbN";
            this.rdbN.Size = new System.Drawing.Size(42, 26);
            this.rdbN.TabIndex = 48;
            this.rdbN.TabStop = true;
            this.rdbN.Text = "N";
            this.rdbN.UseVisualStyleBackColor = true;
            // 
            // rdbY
            // 
            this.rdbY.AutoSize = true;
            this.rdbY.Location = new System.Drawing.Point(103, 397);
            this.rdbY.Name = "rdbY";
            this.rdbY.Size = new System.Drawing.Size(39, 26);
            this.rdbY.TabIndex = 47;
            this.rdbY.TabStop = true;
            this.rdbY.Text = "Y";
            this.rdbY.UseVisualStyleBackColor = true;
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbRole.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cmbRole.ForeColor = System.Drawing.Color.White;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "Custodian",
            "Shopping cart attendant",
            "Cashier",
            "food preparation workers",
            "Bagger",
            "Floral assistant",
            "Assistant store manager",
            "Stock clerk",
            "Butcher",
            "Inventory control specialist",
            "Seafood specialist",
            "Customer service representative",
            "Store manager"});
            this.cmbRole.Location = new System.Drawing.Point(10, 191);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(236, 27);
            this.cmbRole.TabIndex = 46;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDepartment.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cmbDepartment.ForeColor = System.Drawing.Color.White;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(11, 119);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(236, 27);
            this.cmbDepartment.TabIndex = 45;
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(10, 484);
            this.btnUpdateEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(75, 32);
            this.btnUpdateEmployee.TabIndex = 44;
            this.btnUpdateEmployee.Text = "Update";
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(16, 441);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 42;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEmployee.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.cmbEmployee.ForeColor = System.Drawing.Color.White;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(11, 51);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(236, 27);
            this.cmbEmployee.TabIndex = 39;
            // 
            // lblEmployeeStatus
            // 
            this.lblEmployeeStatus.AutoSize = true;
            this.lblEmployeeStatus.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeStatus.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeStatus.Location = new System.Drawing.Point(8, 397);
            this.lblEmployeeStatus.Name = "lblEmployeeStatus";
            this.lblEmployeeStatus.Size = new System.Drawing.Size(67, 21);
            this.lblEmployeeStatus.TabIndex = 36;
            this.lblEmployeeStatus.Text = "Active:";
            // 
            // lblEmployeeStopDate
            // 
            this.lblEmployeeStopDate.AutoSize = true;
            this.lblEmployeeStopDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeStopDate.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeStopDate.Location = new System.Drawing.Point(7, 308);
            this.lblEmployeeStopDate.Name = "lblEmployeeStopDate";
            this.lblEmployeeStopDate.Size = new System.Drawing.Size(82, 21);
            this.lblEmployeeStopDate.TabIndex = 35;
            this.lblEmployeeStopDate.Text = "Hire date";
            // 
            // dtpEmployeeStopDate
            // 
            this.dtpEmployeeStopDate.Location = new System.Drawing.Point(11, 332);
            this.dtpEmployeeStopDate.MaxDate = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            this.dtpEmployeeStopDate.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.dtpEmployeeStopDate.Name = "dtpEmployeeStopDate";
            this.dtpEmployeeStopDate.Size = new System.Drawing.Size(235, 31);
            this.dtpEmployeeStopDate.TabIndex = 34;
            this.dtpEmployeeStopDate.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // lblEmployeeStartDate
            // 
            this.lblEmployeeStartDate.AutoSize = true;
            this.lblEmployeeStartDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeStartDate.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeStartDate.Location = new System.Drawing.Point(7, 236);
            this.lblEmployeeStartDate.Name = "lblEmployeeStartDate";
            this.lblEmployeeStartDate.Size = new System.Drawing.Size(91, 21);
            this.lblEmployeeStartDate.TabIndex = 33;
            this.lblEmployeeStartDate.Text = "Start date";
            // 
            // dtpEmployeeStartDate
            // 
            this.dtpEmployeeStartDate.Location = new System.Drawing.Point(10, 260);
            this.dtpEmployeeStartDate.MaxDate = new System.DateTime(2022, 5, 26, 0, 0, 0, 0);
            this.dtpEmployeeStartDate.MinDate = new System.DateTime(1922, 1, 1, 0, 0, 0, 0);
            this.dtpEmployeeStartDate.Name = "dtpEmployeeStartDate";
            this.dtpEmployeeStartDate.Size = new System.Drawing.Size(236, 31);
            this.dtpEmployeeStartDate.TabIndex = 32;
            this.dtpEmployeeStartDate.Value = new System.DateTime(2022, 5, 19, 0, 0, 0, 0);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(7, 166);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(43, 21);
            this.lblRole.TabIndex = 28;
            this.lblRole.Text = "Role";
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
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.Location = new System.Drawing.Point(173, 484);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(75, 32);
            this.btnAddEmployee.TabIndex = 4;
            this.btnAddEmployee.Text = "Add";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.ForeColor = System.Drawing.Color.White;
            this.lblDepartment.Location = new System.Drawing.Point(8, 95);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(108, 21);
            this.lblDepartment.TabIndex = 9;
            this.lblDepartment.Text = "Department";
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.Color.White;
            this.lblEmployee.Location = new System.Drawing.Point(10, 27);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(86, 21);
            this.lblEmployee.TabIndex = 10;
            this.lblEmployee.Text = "Employee";
            // 
            // grbShowEmployees
            // 
            this.grbShowEmployees.Controls.Add(this.btnDeleteEmployee);
            this.grbShowEmployees.Controls.Add(this.dgvEmployees);
            this.grbShowEmployees.Controls.Add(this.btnShowEmployees);
            this.grbShowEmployees.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbShowEmployees.ForeColor = System.Drawing.Color.White;
            this.grbShowEmployees.Location = new System.Drawing.Point(276, 7);
            this.grbShowEmployees.Name = "grbShowEmployees";
            this.grbShowEmployees.Size = new System.Drawing.Size(842, 523);
            this.grbShowEmployees.TabIndex = 26;
            this.grbShowEmployees.TabStop = false;
            this.grbShowEmployees.Text = "Show Employees";
            // 
            // btnDeleteEmployee
            // 
            this.btnDeleteEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnDeleteEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEmployee.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEmployee.ForeColor = System.Drawing.Color.White;
            this.btnDeleteEmployee.Location = new System.Drawing.Point(6, 484);
            this.btnDeleteEmployee.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteEmployee.Name = "btnDeleteEmployee";
            this.btnDeleteEmployee.Size = new System.Drawing.Size(86, 32);
            this.btnDeleteEmployee.TabIndex = 8;
            this.btnDeleteEmployee.Text = "Delete";
            this.btnDeleteEmployee.UseVisualStyleBackColor = false;
            this.btnDeleteEmployee.Click += new System.EventHandler(this.btnDeleteEmployee_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.Location = new System.Drawing.Point(6, 23);
            this.dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmployees.Size = new System.Drawing.Size(828, 442);
            this.dgvEmployees.TabIndex = 6;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellContentClick);
            // 
            // btnShowEmployees
            // 
            this.btnShowEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnShowEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEmployees.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowEmployees.ForeColor = System.Drawing.Color.White;
            this.btnShowEmployees.Location = new System.Drawing.Point(748, 484);
            this.btnShowEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowEmployees.Name = "btnShowEmployees";
            this.btnShowEmployees.Size = new System.Drawing.Size(86, 32);
            this.btnShowEmployees.TabIndex = 5;
            this.btnShowEmployees.Text = "Show";
            this.btnShowEmployees.UseVisualStyleBackColor = false;
            this.btnShowEmployees.Click += new System.EventHandler(this.btnShowEmployees_Click);
            // 
            // employeeInDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.grbShowEmployees);
            this.Controls.Add(this.grbAsignEmployee);
            this.Name = "employeeInDepartmentForm";
            this.Size = new System.Drawing.Size(1136, 547);
            this.grbAsignEmployee.ResumeLayout(false);
            this.grbAsignEmployee.PerformLayout();
            this.grbShowEmployees.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAsignEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label lblEmployeeStatus;
        private System.Windows.Forms.Label lblEmployeeStopDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeStopDate;
        private System.Windows.Forms.Label lblEmployeeStartDate;
        private System.Windows.Forms.DateTimePicker dtpEmployeeStartDate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.RadioButton rdbN;
        private System.Windows.Forms.RadioButton rdbY;
        private System.Windows.Forms.GroupBox grbShowEmployees;
        private System.Windows.Forms.Button btnDeleteEmployee;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnShowEmployees;
    }
}
