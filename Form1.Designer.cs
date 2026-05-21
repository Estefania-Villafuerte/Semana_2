namespace CalculadoraPaneles
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.panelDisplay = new System.Windows.Forms.Panel();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.panelOperations = new System.Windows.Forms.Panel();
            this.btnC = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            // number buttons
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // panelDisplay
            // 
            this.panelDisplay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDisplay.Height = 80;
            this.panelDisplay.Padding = new Padding(10);
            // 
            // txtPantalla
            // 
            this.txtPantalla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPantalla.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPantalla.ReadOnly = true;
            this.txtPantalla.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.TabIndex = 0;
            this.panelDisplay.Controls.Add(this.txtPantalla);
            // 
            // panelOperations
            // 
            this.panelOperations.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelOperations.Width = 120;
            this.panelOperations.Padding = new Padding(10);
            // add operation buttons to panelOperations
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Text = "+";
            this.btnPlus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlus.Height = 60;
            this.btnPlus.Click += new System.EventHandler(this.seleccionarOperacion);
            this.panelOperations.Controls.Add(this.btnPlus);

            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Text = "-";
            this.btnMinus.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMinus.Height = 60;
            this.btnMinus.Click += new System.EventHandler(this.seleccionarOperacion);
            this.panelOperations.Controls.Add(this.btnMinus);

            this.btnMul.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMul.Text = "*";
            this.btnMul.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMul.Height = 60;
            this.btnMul.Click += new System.EventHandler(this.seleccionarOperacion);
            this.panelOperations.Controls.Add(this.btnMul);

            this.btnDiv.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDiv.Text = "/";
            this.btnDiv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiv.Height = 60;
            this.btnDiv.Click += new System.EventHandler(this.seleccionarOperacion);
            this.panelOperations.Controls.Add(this.btnDiv);

            // 
            // panelNumbers
            // 
            this.panelNumbers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNumbers.Padding = new Padding(10);
            // arrange number buttons in grid-like positions
            int btnW = 80, btnH = 60, margin = 10;

            // first row: 7 8 9
            this.btn7.Text = "7"; this.btn8.Text = "8"; this.btn9.Text = "9";
            this.btn4.Text = "4"; this.btn5.Text = "5"; this.btn6.Text = "6";
            this.btn1.Text = "1"; this.btn2.Text = "2"; this.btn3.Text = "3";
            this.btn0.Text = "0";

            Button[] nums = new Button[] { this.btn7, this.btn8, this.btn9, this.btn4, this.btn5, this.btn6, this.btn1, this.btn2, this.btn3, this.btn0 };
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i].Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                nums[i].Size = new System.Drawing.Size(btnW, btnH);
                nums[i].Click += new System.EventHandler(this.agregarNumero);
                this.panelNumbers.Controls.Add(nums[i]);
            }

            // position numbers manually
            this.btn7.Location = new System.Drawing.Point(margin, margin);
            this.btn8.Location = new System.Drawing.Point(margin + (btnW + margin), margin);
            this.btn9.Location = new System.Drawing.Point(margin + 2 * (btnW + margin), margin);

            this.btn4.Location = new System.Drawing.Point(margin, margin + (btnH + margin));
            this.btn5.Location = new System.Drawing.Point(margin + (btnW + margin), margin + (btnH + margin));
            this.btn6.Location = new System.Drawing.Point(margin + 2 * (btnW + margin), margin + (btnH + margin));

            this.btn1.Location = new System.Drawing.Point(margin, margin + 2 * (btnH + margin));
            this.btn2.Location = new System.Drawing.Point(margin + (btnW + margin), margin + 2 * (btnH + margin));
            this.btn3.Location = new System.Drawing.Point(margin + 2 * (btnW + margin), margin + 2 * (btnH + margin));

            this.btn0.Location = new System.Drawing.Point(margin, margin + 3 * (btnH + margin));
            this.btn0.Size = new System.Drawing.Size(btnW, btnH);

            // clear and equal buttons
            this.btnC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.Text = "C";
            this.btnC.Size = new System.Drawing.Size(btnW, btnH);
            this.btnC.Location = new System.Drawing.Point(margin + 2 * (btnW + margin), margin + 3 * (btnH + margin));
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            this.panelNumbers.Controls.Add(this.btnC);
            // decimal button
            this.btnDecimal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDecimal.Text = ".";
            this.btnDecimal.Size = new System.Drawing.Size(btnW, btnH);
            this.btnDecimal.Location = new System.Drawing.Point(margin + (btnW + margin), margin + 3 * (btnH + margin));
            this.btnDecimal.Click += new System.EventHandler(this.agregarNumero);
            this.panelNumbers.Controls.Add(this.btnDecimal);

            // place equal button in operations panel at bottom
            this.btnIgual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIgual.Text = "=";
            this.btnIgual.Height = btnH;
            this.btnIgual.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            this.panelOperations.Controls.Add(this.btnIgual);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 380);
            this.Controls.Add(this.panelNumbers);
            this.Controls.Add(this.panelOperations);
            this.Controls.Add(this.panelDisplay);
            this.Name = "Form1";
            this.Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.Panel panelDisplay;
        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Panel panelOperations;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
    }
}
