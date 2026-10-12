using System;
using System.Drawing;
using System.Windows.Forms;

namespace Desing_calculator
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

            // Настройка формы
            this.Text = "Калькулятор";
            this.Size = new Size(320, 480);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void InitializeComponent()
        {
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.percentbtm = new System.Windows.Forms.Button();
            this.CEbtm = new System.Windows.Forms.Button();
            this.Clearbtm = new System.Windows.Forms.Button();
            this.Backspacebtm = new System.Windows.Forms.Button();
            this.inversebtm = new System.Windows.Forms.Button();
            this.squarebtm = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.devidebtm = new System.Windows.Forms.Button();
            this.btm7 = new System.Windows.Forms.Button();
            this.btm8 = new System.Windows.Forms.Button();
            this.btm9 = new System.Windows.Forms.Button();
            this.multiplybtm = new System.Windows.Forms.Button();
            this.btm4 = new System.Windows.Forms.Button();
            this.btm5 = new System.Windows.Forms.Button();
            this.btm6 = new System.Windows.Forms.Button();
            this.minusbtm = new System.Windows.Forms.Button();
            this.btm1 = new System.Windows.Forms.Button();
            this.btm2 = new System.Windows.Forms.Button();
            this.btm3 = new System.Windows.Forms.Button();
            this.plusbtm = new System.Windows.Forms.Button();
            this.plusminusbtm = new System.Windows.Forms.Button();
            this.btm0 = new System.Windows.Forms.Button();
            this.tochkabtm = new System.Windows.Forms.Button();
            this.ravnobtm = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtDisplay.Location = new System.Drawing.Point(0, 0);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(304, 40);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "Введите число";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ravnobtm, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.tochkabtm, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btm0, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.plusminusbtm, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.plusbtm, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btm2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btm1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.minusbtm, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.btm6, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btm5, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btm4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.multiplybtm, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btm9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btm8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btm7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.devidebtm, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.inversebtm, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Backspacebtm, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Clearbtm, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.CEbtm, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.percentbtm, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.squarebtm, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btm3, 2, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(304, 401);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // percentbtm
            // 
            this.percentbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.percentbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentbtm.Location = new System.Drawing.Point(3, 3);
            this.percentbtm.Name = "percentbtm";
            this.percentbtm.Size = new System.Drawing.Size(70, 60);
            this.percentbtm.TabIndex = 0;
            this.percentbtm.Text = "%";
            this.percentbtm.UseVisualStyleBackColor = true;
            this.percentbtm.Click += new System.EventHandler(this.button1_Click);
            // 
            // CEbtm
            // 
            this.CEbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CEbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CEbtm.Location = new System.Drawing.Point(79, 3);
            this.CEbtm.Name = "CEbtm";
            this.CEbtm.Size = new System.Drawing.Size(70, 60);
            this.CEbtm.TabIndex = 1;
            this.CEbtm.Text = "CE";
            this.CEbtm.UseVisualStyleBackColor = true;
            // 
            // Clearbtm
            // 
            this.Clearbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Clearbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clearbtm.Location = new System.Drawing.Point(155, 3);
            this.Clearbtm.Name = "Clearbtm";
            this.Clearbtm.Size = new System.Drawing.Size(70, 60);
            this.Clearbtm.TabIndex = 20;
            this.Clearbtm.Text = "C";
            this.Clearbtm.UseVisualStyleBackColor = true;
            // 
            // Backspacebtm
            // 
            this.Backspacebtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Backspacebtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Backspacebtm.Location = new System.Drawing.Point(231, 3);
            this.Backspacebtm.Name = "Backspacebtm";
            this.Backspacebtm.Size = new System.Drawing.Size(70, 60);
            this.Backspacebtm.TabIndex = 21;
            this.Backspacebtm.Text = "←";
            this.Backspacebtm.UseVisualStyleBackColor = true;
            // 
            // inversebtm
            // 
            this.inversebtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inversebtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inversebtm.Location = new System.Drawing.Point(3, 69);
            this.inversebtm.Name = "inversebtm";
            this.inversebtm.Size = new System.Drawing.Size(70, 60);
            this.inversebtm.TabIndex = 22;
            this.inversebtm.Text = "1/x";
            this.inversebtm.UseVisualStyleBackColor = true;
            // 
            // squarebtm
            // 
            this.squarebtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.squarebtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squarebtm.Location = new System.Drawing.Point(79, 69);
            this.squarebtm.Name = "squarebtm";
            this.squarebtm.Size = new System.Drawing.Size(70, 60);
            this.squarebtm.TabIndex = 23;
            this.squarebtm.Text = "x²";
            this.squarebtm.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(155, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(70, 60);
            this.button7.TabIndex = 24;
            this.button7.Text = "√x";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // devidebtm
            // 
            this.devidebtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devidebtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.devidebtm.Location = new System.Drawing.Point(231, 69);
            this.devidebtm.Name = "devidebtm";
            this.devidebtm.Size = new System.Drawing.Size(70, 60);
            this.devidebtm.TabIndex = 25;
            this.devidebtm.Text = "/";
            this.devidebtm.UseVisualStyleBackColor = true;
            // 
            // btm7
            // 
            this.btm7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm7.Location = new System.Drawing.Point(3, 135);
            this.btm7.Name = "btm7";
            this.btm7.Size = new System.Drawing.Size(70, 60);
            this.btm7.TabIndex = 26;
            this.btm7.Text = "7";
            this.btm7.UseVisualStyleBackColor = true;
            // 
            // btm8
            // 
            this.btm8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm8.Location = new System.Drawing.Point(79, 135);
            this.btm8.Name = "btm8";
            this.btm8.Size = new System.Drawing.Size(70, 60);
            this.btm8.TabIndex = 27;
            this.btm8.Text = "8";
            this.btm8.UseVisualStyleBackColor = true;
            // 
            // btm9
            // 
            this.btm9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm9.Location = new System.Drawing.Point(155, 135);
            this.btm9.Name = "btm9";
            this.btm9.Size = new System.Drawing.Size(70, 60);
            this.btm9.TabIndex = 28;
            this.btm9.Text = "9";
            this.btm9.UseVisualStyleBackColor = true;
            // 
            // multiplybtm
            // 
            this.multiplybtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiplybtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplybtm.Location = new System.Drawing.Point(231, 135);
            this.multiplybtm.Name = "multiplybtm";
            this.multiplybtm.Size = new System.Drawing.Size(70, 60);
            this.multiplybtm.TabIndex = 29;
            this.multiplybtm.Text = "*";
            this.multiplybtm.UseVisualStyleBackColor = true;
            // 
            // btm4
            // 
            this.btm4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm4.Location = new System.Drawing.Point(3, 201);
            this.btm4.Name = "btm4";
            this.btm4.Size = new System.Drawing.Size(70, 60);
            this.btm4.TabIndex = 30;
            this.btm4.Text = "4";
            this.btm4.UseVisualStyleBackColor = true;
            // 
            // btm5
            // 
            this.btm5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm5.Location = new System.Drawing.Point(79, 201);
            this.btm5.Name = "btm5";
            this.btm5.Size = new System.Drawing.Size(70, 60);
            this.btm5.TabIndex = 31;
            this.btm5.Text = "5";
            this.btm5.UseVisualStyleBackColor = true;
            // 
            // btm6
            // 
            this.btm6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm6.Location = new System.Drawing.Point(155, 201);
            this.btm6.Name = "btm6";
            this.btm6.Size = new System.Drawing.Size(70, 60);
            this.btm6.TabIndex = 32;
            this.btm6.Text = "6";
            this.btm6.UseVisualStyleBackColor = true;
            // 
            // minusbtm
            // 
            this.minusbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minusbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusbtm.Location = new System.Drawing.Point(231, 201);
            this.minusbtm.Name = "minusbtm";
            this.minusbtm.Size = new System.Drawing.Size(70, 60);
            this.minusbtm.TabIndex = 33;
            this.minusbtm.Text = "-";
            this.minusbtm.UseVisualStyleBackColor = true;
            // 
            // btm1
            // 
            this.btm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm1.Location = new System.Drawing.Point(3, 267);
            this.btm1.Name = "btm1";
            this.btm1.Size = new System.Drawing.Size(70, 60);
            this.btm1.TabIndex = 34;
            this.btm1.Text = "1";
            this.btm1.UseVisualStyleBackColor = true;
            // 
            // btm2
            // 
            this.btm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm2.Location = new System.Drawing.Point(79, 267);
            this.btm2.Name = "btm2";
            this.btm2.Size = new System.Drawing.Size(70, 60);
            this.btm2.TabIndex = 35;
            this.btm2.Text = "2";
            this.btm2.UseVisualStyleBackColor = true;
            // 
            // btm3
            // 
            this.btm3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm3.Location = new System.Drawing.Point(155, 267);
            this.btm3.Name = "btm3";
            this.btm3.Size = new System.Drawing.Size(70, 60);
            this.btm3.TabIndex = 36;
            this.btm3.Text = "3";
            this.btm3.UseVisualStyleBackColor = true;
            // 
            // plusbtm
            // 
            this.plusbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusbtm.Location = new System.Drawing.Point(231, 267);
            this.plusbtm.Name = "plusbtm";
            this.plusbtm.Size = new System.Drawing.Size(70, 60);
            this.plusbtm.TabIndex = 37;
            this.plusbtm.Text = "+";
            this.plusbtm.UseVisualStyleBackColor = true;
            // 
            // plusminusbtm
            // 
            this.plusminusbtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plusminusbtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusminusbtm.Location = new System.Drawing.Point(3, 333);
            this.plusminusbtm.Name = "plusminusbtm";
            this.plusminusbtm.Size = new System.Drawing.Size(70, 65);
            this.plusminusbtm.TabIndex = 38;
            this.plusminusbtm.Text = "+/-";
            this.plusminusbtm.UseVisualStyleBackColor = true;
            // 
            // btm0
            // 
            this.btm0.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btm0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btm0.Location = new System.Drawing.Point(79, 333);
            this.btm0.Name = "btm0";
            this.btm0.Size = new System.Drawing.Size(70, 65);
            this.btm0.TabIndex = 39;
            this.btm0.Text = "0";
            this.btm0.UseVisualStyleBackColor = true;
            // 
            // tochkabtm
            // 
            this.tochkabtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tochkabtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tochkabtm.Location = new System.Drawing.Point(155, 333);
            this.tochkabtm.Name = "tochkabtm";
            this.tochkabtm.Size = new System.Drawing.Size(70, 65);
            this.tochkabtm.TabIndex = 40;
            this.tochkabtm.Text = ".";
            this.tochkabtm.UseVisualStyleBackColor = true;
            // 
            // ravnobtm
            // 
            this.ravnobtm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ravnobtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ravnobtm.Location = new System.Drawing.Point(231, 333);
            this.ravnobtm.Name = "ravnobtm";
            this.ravnobtm.Size = new System.Drawing.Size(70, 65);
            this.ravnobtm.TabIndex = 41;
            this.ravnobtm.Text = "=";
            this.ravnobtm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txtDisplay);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox txtDisplay;
        private TableLayoutPanel tableLayoutPanel1;
        private Button CEbtm;
        private Button percentbtm;
        private Button plusbtm;
        private Button btm3;
        private Button btm2;
        private Button btm1;
        private Button minusbtm;
        private Button btm6;
        private Button btm5;
        private Button btm4;
        private Button multiplybtm;
        private Button btm9;
        private Button btm8;
        private Button btm7;
        private Button devidebtm;
        private Button button7;
        private Button inversebtm;
        private Button Backspacebtm;
        private Button Clearbtm;
        private Button squarebtm;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private Button ravnobtm;
        private Button tochkabtm;
        private Button btm0;
        private Button plusminusbtm;
    }
}