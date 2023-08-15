namespace To_Do_List
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.txtname = new System.Windows.Forms.TextBox();
      this.txtaddress = new System.Windows.Forms.TextBox();
      this.txtwork = new System.Windows.Forms.TextBox();
      this.btnadd = new System.Windows.Forms.Button();
      this.btnedit = new System.Windows.Forms.Button();
      this.btndel = new System.Windows.Forms.Button();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sal = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.work = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.skills = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label6 = new System.Windows.Forms.Label();
      this.txtsal = new System.Windows.Forms.NumericUpDown();
      this.txtskills = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtsal)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtskills)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Tw Cen MT", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.Yellow;
      this.label1.Location = new System.Drawing.Point(541, 9);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(216, 58);
      this.label1.TabIndex = 0;
      this.label1.Text = "To Do List";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(65, 104);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(85, 31);
      this.label2.TabIndex = 1;
      this.label2.Text = "Name:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(65, 167);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(107, 31);
      this.label3.TabIndex = 1;
      this.label3.Text = "Address:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(65, 228);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(93, 31);
      this.label4.TabIndex = 1;
      this.label4.Text = "Salary:";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(65, 289);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(82, 31);
      this.label5.TabIndex = 1;
      this.label5.Text = "Work:";
      // 
      // txtname
      // 
      this.txtname.BackColor = System.Drawing.Color.White;
      this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtname.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.txtname.Location = new System.Drawing.Point(192, 101);
      this.txtname.Margin = new System.Windows.Forms.Padding(4);
      this.txtname.Name = "txtname";
      this.txtname.Size = new System.Drawing.Size(300, 43);
      this.txtname.TabIndex = 1;
      this.txtname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtaddress
      // 
      this.txtaddress.BackColor = System.Drawing.Color.White;
      this.txtaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.txtaddress.Location = new System.Drawing.Point(192, 165);
      this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
      this.txtaddress.Name = "txtaddress";
      this.txtaddress.Size = new System.Drawing.Size(300, 43);
      this.txtaddress.TabIndex = 2;
      this.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // txtwork
      // 
      this.txtwork.BackColor = System.Drawing.Color.White;
      this.txtwork.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtwork.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.txtwork.Location = new System.Drawing.Point(192, 287);
      this.txtwork.Margin = new System.Windows.Forms.Padding(4);
      this.txtwork.Name = "txtwork";
      this.txtwork.Size = new System.Drawing.Size(300, 43);
      this.txtwork.TabIndex = 4;
      this.txtwork.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // btnadd
      // 
      this.btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnadd.ForeColor = System.Drawing.Color.White;
      this.btnadd.Location = new System.Drawing.Point(804, 148);
      this.btnadd.Name = "btnadd";
      this.btnadd.Size = new System.Drawing.Size(178, 50);
      this.btnadd.TabIndex = 6;
      this.btnadd.Text = "Add";
      this.btnadd.UseVisualStyleBackColor = true;
      this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
      // 
      // btnedit
      // 
      this.btnedit.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnedit.ForeColor = System.Drawing.Color.Lime;
      this.btnedit.Location = new System.Drawing.Point(1064, 148);
      this.btnedit.Name = "btnedit";
      this.btnedit.Size = new System.Drawing.Size(178, 50);
      this.btnedit.TabIndex = 7;
      this.btnedit.Text = "Edit";
      this.btnedit.UseVisualStyleBackColor = true;
      this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
      // 
      // btndel
      // 
      this.btndel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btndel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btndel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.btndel.Location = new System.Drawing.Point(804, 240);
      this.btndel.Name = "btndel";
      this.btndel.Size = new System.Drawing.Size(438, 50);
      this.btndel.TabIndex = 8;
      this.btndel.Text = "Delete";
      this.btndel.UseVisualStyleBackColor = true;
      this.btndel.Click += new System.EventHandler(this.btndel_Click);
      // 
      // dgv
      // 
      this.dgv.AllowUserToAddRows = false;
      this.dgv.AllowUserToDeleteRows = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.Silver;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Silver;
      this.dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
      this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.address,
            this.sal,
            this.work,
            this.skills});
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Tw Cen MT", 16F);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Aqua;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
      this.dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgv.Location = new System.Drawing.Point(0, 422);
      this.dgv.Name = "dgv";
      this.dgv.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Tw Cen MT", 16F);
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
      this.dgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
      this.dgv.RowTemplate.Height = 24;
      this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgv.Size = new System.Drawing.Size(1304, 271);
      this.dgv.TabIndex = 9;
      this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
      // 
      // name
      // 
      this.name.HeaderText = "Name";
      this.name.Name = "name";
      this.name.ReadOnly = true;
      // 
      // address
      // 
      this.address.HeaderText = "Address";
      this.address.Name = "address";
      this.address.ReadOnly = true;
      // 
      // sal
      // 
      this.sal.HeaderText = "Salary";
      this.sal.Name = "sal";
      this.sal.ReadOnly = true;
      // 
      // work
      // 
      this.work.HeaderText = "Work";
      this.work.Name = "work";
      this.work.ReadOnly = true;
      // 
      // skills
      // 
      this.skills.HeaderText = "Skills";
      this.skills.Name = "skills";
      this.skills.ReadOnly = true;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(65, 350);
      this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 31);
      this.label6.TabIndex = 5;
      this.label6.Text = "Skills:";
      // 
      // txtsal
      // 
      this.txtsal.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.txtsal.Location = new System.Drawing.Point(192, 224);
      this.txtsal.Name = "txtsal";
      this.txtsal.Size = new System.Drawing.Size(300, 43);
      this.txtsal.TabIndex = 3;
      this.txtsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtsal.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // txtskills
      // 
      this.txtskills.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.txtskills.Location = new System.Drawing.Point(192, 346);
      this.txtskills.Name = "txtskills";
      this.txtskills.Size = new System.Drawing.Size(300, 43);
      this.txtskills.TabIndex = 5;
      this.txtskills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.txtskills.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
      this.ClientSize = new System.Drawing.Size(1304, 693);
      this.Controls.Add(this.txtskills);
      this.Controls.Add(this.txtsal);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.btndel);
      this.Controls.Add(this.btnedit);
      this.Controls.Add(this.btnadd);
      this.Controls.Add(this.txtwork);
      this.Controls.Add(this.txtaddress);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtname);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Font = new System.Drawing.Font("Tw Cen MT", 16F);
      this.ForeColor = System.Drawing.Color.Aqua;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.Name = "Form1";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "To Do List";
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtsal)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtskills)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txtname;
    private System.Windows.Forms.TextBox txtaddress;
    private System.Windows.Forms.TextBox txtwork;
    private System.Windows.Forms.Button btnadd;
    private System.Windows.Forms.Button btnedit;
    private System.Windows.Forms.Button btndel;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.DataGridViewTextBoxColumn name;
    private System.Windows.Forms.DataGridViewTextBoxColumn address;
    private System.Windows.Forms.DataGridViewTextBoxColumn sal;
    private System.Windows.Forms.DataGridViewTextBoxColumn work;
    private System.Windows.Forms.DataGridViewTextBoxColumn skills;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.NumericUpDown txtsal;
    private System.Windows.Forms.NumericUpDown txtskills;
  }
}

