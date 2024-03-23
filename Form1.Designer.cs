using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Laborator1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NumeDoctor = new System.Windows.Forms.TextBox();
            this.SpecializareDoctor = new System.Windows.Forms.TextBox();
            this.ButonAdaugare = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.IdDoctorUpdate = new System.Windows.Forms.TextBox();
            this.NumeDoctorUpdate = new System.Windows.Forms.TextBox();
            this.FieldUpdate = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.IDDelete = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cabinet_vetDataSet21 = new Laborator1.cabinet_vetDataSet2();
            this.doctorTableAdapter2 = new Laborator1.cabinet_vetDataSet2TableAdapters.doctorTableAdapter();
            this.cabinetTableAdapter2 = new Laborator1.cabinet_vetDataSet2TableAdapters.cabinetTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cabinet_vetDataSet = new Laborator1.cabinet_vetDataSet();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cabinetTableAdapter = new Laborator1.cabinet_vetDataSetTableAdapters.cabinetTableAdapter();
            this.doctorTableAdapter = new Laborator1.cabinet_vetDataSetTableAdapters.doctorTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.TextIdDoctor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_vetDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_vetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adaugare";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Salmon;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 317);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(152, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume doctor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Salmon;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 362);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Specializare";
            // 
            // NumeDoctor
            // 
            this.NumeDoctor.BackColor = System.Drawing.Color.PeachPuff;
            this.NumeDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeDoctor.Location = new System.Drawing.Point(170, 317);
            this.NumeDoctor.Name = "NumeDoctor";
            this.NumeDoctor.Size = new System.Drawing.Size(165, 30);
            this.NumeDoctor.TabIndex = 8;
            // 
            // SpecializareDoctor
            // 
            this.SpecializareDoctor.BackColor = System.Drawing.Color.PeachPuff;
            this.SpecializareDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpecializareDoctor.Location = new System.Drawing.Point(170, 362);
            this.SpecializareDoctor.Name = "SpecializareDoctor";
            this.SpecializareDoctor.Size = new System.Drawing.Size(165, 30);
            this.SpecializareDoctor.TabIndex = 9;
            // 
            // ButonAdaugare
            // 
            this.ButonAdaugare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ButonAdaugare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonAdaugare.Location = new System.Drawing.Point(99, 398);
            this.ButonAdaugare.Name = "ButonAdaugare";
            this.ButonAdaugare.Size = new System.Drawing.Size(105, 44);
            this.ButonAdaugare.TabIndex = 10;
            this.ButonAdaugare.Text = "Adaugare";
            this.ButonAdaugare.UseVisualStyleBackColor = false;
            this.ButonAdaugare.Click += new System.EventHandler(this.ButonAdaugare_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "Update";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Salmon;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(402, 262);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(109, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "Id doctor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Salmon;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 318);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Nume doctor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Salmon;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(393, 362);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(146, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Specializare";
            // 
            // IdDoctorUpdate
            // 
            this.IdDoctorUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.IdDoctorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdDoctorUpdate.Location = new System.Drawing.Point(557, 262);
            this.IdDoctorUpdate.Name = "IdDoctorUpdate";
            this.IdDoctorUpdate.Size = new System.Drawing.Size(165, 30);
            this.IdDoctorUpdate.TabIndex = 15;
            // 
            // NumeDoctorUpdate
            // 
            this.NumeDoctorUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.NumeDoctorUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeDoctorUpdate.Location = new System.Drawing.Point(557, 316);
            this.NumeDoctorUpdate.Name = "NumeDoctorUpdate";
            this.NumeDoctorUpdate.Size = new System.Drawing.Size(165, 30);
            this.NumeDoctorUpdate.TabIndex = 16;
            // 
            // FieldUpdate
            // 
            this.FieldUpdate.BackColor = System.Drawing.Color.PeachPuff;
            this.FieldUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FieldUpdate.Location = new System.Drawing.Point(557, 362);
            this.FieldUpdate.Name = "FieldUpdate";
            this.FieldUpdate.Size = new System.Drawing.Size(165, 30);
            this.FieldUpdate.TabIndex = 17;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Location = new System.Drawing.Point(514, 398);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(122, 42);
            this.UpdateButton.TabIndex = 18;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpdateButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Lime;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(865, 196);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 34);
            this.label9.TabIndex = 19;
            this.label9.Text = "Delete";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Salmon;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(793, 263);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(109, 31);
            this.label10.TabIndex = 20;
            this.label10.Text = "Id doctor";
            // 
            // IDDelete
            // 
            this.IDDelete.BackColor = System.Drawing.Color.PeachPuff;
            this.IDDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDDelete.Location = new System.Drawing.Point(931, 264);
            this.IDDelete.Name = "IDDelete";
            this.IDDelete.Size = new System.Drawing.Size(165, 30);
            this.IDDelete.TabIndex = 21;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(865, 316);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(128, 34);
            this.DeleteButton.TabIndex = 22;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DeleteButton_MouseClick);
            // 
            // cabinet_vetDataSet21
            // 
            this.cabinet_vetDataSet21.DataSetName = "cabinet_vetDataSet2";
            this.cabinet_vetDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorTableAdapter2
            // 
            this.doctorTableAdapter2.ClearBeforeFill = true;
            // 
            // cabinetTableAdapter2
            // 
            this.cabinetTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.bindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(29, 12);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(333, 150);
            this.dataGridView3.TabIndex = 23;
            this.dataGridView3.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView3_RowHeaderMouseClick_1);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_cabinet";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_cabinet";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tip_cabinet";
            this.dataGridViewTextBoxColumn2.HeaderText = "tip_cabinet";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "cabinet";
            this.bindingSource1.DataSource = this.cabinet_vetDataSet;
            // 
            // cabinet_vetDataSet
            // 
            this.cabinet_vetDataSet.DataSetName = "cabinet_vetDataSet";
            this.cabinet_vetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView4.DataSource = this.bindingSource2;
            this.dataGridView4.Location = new System.Drawing.Point(536, 12);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 24;
            this.dataGridView4.Size = new System.Drawing.Size(560, 150);
            this.dataGridView4.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_doctor";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_doctor";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nume";
            this.dataGridViewTextBoxColumn5.HeaderText = "nume";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "specializare";
            this.dataGridViewTextBoxColumn6.HeaderText = "specializare";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_cabinet";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_cabinet";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "doctor";
            this.bindingSource2.DataSource = this.cabinet_vetDataSet;
            // 
            // cabinetTableAdapter
            // 
            this.cabinetTableAdapter.ClearBeforeFill = true;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 263);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(112, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id Doctor";
            // 
            // TextIdDoctor
            // 
            this.TextIdDoctor.BackColor = System.Drawing.Color.PeachPuff;
            this.TextIdDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextIdDoctor.Location = new System.Drawing.Point(170, 263);
            this.TextIdDoctor.Name = "TextIdDoctor";
            this.TextIdDoctor.Size = new System.Drawing.Size(165, 30);
            this.TextIdDoctor.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(902, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonRefesh);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1201, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.IDDelete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FieldUpdate);
            this.Controls.Add(this.NumeDoctorUpdate);
            this.Controls.Add(this.IdDoctorUpdate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ButonAdaugare);
            this.Controls.Add(this.SpecializareDoctor);
            this.Controls.Add(this.NumeDoctor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextIdDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_vetDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cabinet_vetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private DataGridView dataGridView1;
        private BindingSource cabinetBindingSource;
        private DataGridViewTextBoxColumn idcabinetDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipcabinetDataGridViewTextBoxColumn;
        private BindingSource doctorBindingSource;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn iddoctorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specializareDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idcabinetDataGridViewTextBoxColumn1;
        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox NumeDoctor;
        private TextBox SpecializareDoctor;
        private Button ButonAdaugare;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox IdDoctorUpdate;
        private TextBox NumeDoctorUpdate;
        private TextBox FieldUpdate;
        private Button UpdateButton;
        private Label label9;
        private Label label10;
        private TextBox IDDelete;
        private Button DeleteButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private cabinet_vetDataSet2 cabinet_vetDataSet21;
        private cabinet_vetDataSet2TableAdapters.doctorTableAdapter doctorTableAdapter2;
        private cabinet_vetDataSet2TableAdapters.cabinetTableAdapter cabinetTableAdapter2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridView dataGridView3;
        private DataGridView dataGridView4;
        private cabinet_vetDataSet cabinet_vetDataSet;
        private BindingSource bindingSource1;
        private cabinet_vetDataSetTableAdapters.cabinetTableAdapter cabinetTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private BindingSource bindingSource2;
        private cabinet_vetDataSetTableAdapters.doctorTableAdapter doctorTableAdapter;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private Label label2;
        private TextBox TextIdDoctor;
        private Button button1;
    }
}

