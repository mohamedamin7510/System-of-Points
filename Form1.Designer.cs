namespace PointsSystem
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
            this.dataGridView_ReadAllUsers = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.month_textbox = new System.Windows.Forms.TextBox();
            this.dataGridView_Ordering = new System.Windows.Forms.DataGridView();
            this.add_button = new System.Windows.Forms.Button();
            this.addpoint = new System.Windows.Forms.TextBox();
            this.textBox2_addtasks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView_Maxin_Tasks = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.Label();
            this.textBox1_Id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadAllUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordering)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maxin_Tasks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_ReadAllUsers
            // 
            this.dataGridView_ReadAllUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ReadAllUsers.Location = new System.Drawing.Point(10, 10);
            this.dataGridView_ReadAllUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_ReadAllUsers.Name = "dataGridView_ReadAllUsers";
            this.dataGridView_ReadAllUsers.RowHeadersWidth = 51;
            this.dataGridView_ReadAllUsers.RowTemplate.Height = 26;
            this.dataGridView_ReadAllUsers.Size = new System.Drawing.Size(633, 291);
            this.dataGridView_ReadAllUsers.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 360);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Month";
            // 
            // month_textbox
            // 
            this.month_textbox.Location = new System.Drawing.Point(86, 353);
            this.month_textbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.month_textbox.Name = "month_textbox";
            this.month_textbox.Size = new System.Drawing.Size(204, 20);
            this.month_textbox.TabIndex = 11;
            // 
            // dataGridView_Ordering
            // 
            this.dataGridView_Ordering.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Ordering.Location = new System.Drawing.Point(733, -2);
            this.dataGridView_Ordering.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Ordering.Name = "dataGridView_Ordering";
            this.dataGridView_Ordering.RowHeadersWidth = 51;
            this.dataGridView_Ordering.RowTemplate.Height = 26;
            this.dataGridView_Ordering.Size = new System.Drawing.Size(578, 303);
            this.dataGridView_Ordering.TabIndex = 12;
            // 
            // add_button
            // 
            this.add_button.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Location = new System.Drawing.Point(1043, 350);
            this.add_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(140, 89);
            this.add_button.TabIndex = 13;
            this.add_button.Text = "give";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // addpoint
            // 
            this.addpoint.Location = new System.Drawing.Point(818, 350);
            this.addpoint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addpoint.Name = "addpoint";
            this.addpoint.Size = new System.Drawing.Size(162, 20);
            this.addpoint.TabIndex = 15;
            // 
            // textBox2_addtasks
            // 
            this.textBox2_addtasks.Location = new System.Drawing.Point(818, 391);
            this.textBox2_addtasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2_addtasks.Name = "textBox2_addtasks";
            this.textBox2_addtasks.Size = new System.Drawing.Size(162, 20);
            this.textBox2_addtasks.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(737, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "AddPoints";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(740, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "AddTasks";
            // 
            // dataGridView_Maxin_Tasks
            // 
            this.dataGridView_Maxin_Tasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Maxin_Tasks.Location = new System.Drawing.Point(12, 419);
            this.dataGridView_Maxin_Tasks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView_Maxin_Tasks.Name = "dataGridView_Maxin_Tasks";
            this.dataGridView_Maxin_Tasks.RowHeadersWidth = 51;
            this.dataGridView_Maxin_Tasks.RowTemplate.Height = 26;
            this.dataGridView_Maxin_Tasks.Size = new System.Drawing.Size(544, 105);
            this.dataGridView_Maxin_Tasks.TabIndex = 19;
            this.dataGridView_Maxin_Tasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Maxin_Tasks_CellContentClick);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(740, 451);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 20;
            this.ID.Text = "ID";
            // 
            // textBox1_Id
            // 
            this.textBox1_Id.Location = new System.Drawing.Point(818, 444);
            this.textBox1_Id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1_Id.Name = "textBox1_Id";
            this.textBox1_Id.Size = new System.Drawing.Size(162, 20);
            this.textBox1_Id.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(340, 336);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 54);
            this.button2.TabIndex = 22;
            this.button2.Text = "Collection Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1_Id);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.dataGridView_Maxin_Tasks);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2_addtasks);
            this.Controls.Add(this.addpoint);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.dataGridView_Ordering);
            this.Controls.Add(this.month_textbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView_ReadAllUsers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "mnji";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ReadAllUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Ordering)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Maxin_Tasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_ReadAllUsers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox month_textbox;
        private System.Windows.Forms.DataGridView dataGridView_Ordering;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox addpoint;
        private System.Windows.Forms.TextBox textBox2_addtasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView_Maxin_Tasks;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox1_Id;
        private System.Windows.Forms.Button button2;
    }
}

