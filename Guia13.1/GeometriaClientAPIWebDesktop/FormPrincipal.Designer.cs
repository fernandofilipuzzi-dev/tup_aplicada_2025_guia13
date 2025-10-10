namespace GeometriaClientAPIWeb
{
    partial class FormPrincipal
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
            button1 = new Button();
            btnActualizar = new Button();
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            rbRectangulo = new RadioButton();
            rbCirculo = new RadioButton();
            tbArea = new TextBox();
            tbRadio = new TextBox();
            tbLargo = new TextBox();
            tbAncho = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(426, 60);
            button1.Name = "button1";
            button1.Size = new Size(111, 73);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnConfirmar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(438, 260);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(111, 67);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar listado";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(391, 172);
            listBox1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(tbArea);
            groupBox1.Controls.Add(tbRadio);
            groupBox1.Controls.Add(tbLargo);
            groupBox1.Controls.Add(tbAncho);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(554, 194);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alta de figura";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 159);
            label4.Name = "label4";
            label4.Size = new Size(42, 21);
            label4.TabIndex = 10;
            label4.Text = "Area";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(197, 107);
            label3.Name = "label3";
            label3.Size = new Size(50, 21);
            label3.TabIndex = 9;
            label3.Text = "Radio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 72);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 8;
            label2.Text = "Largo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 7;
            label1.Text = "Ancho";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbRectangulo);
            groupBox2.Controls.Add(rbCirculo);
            groupBox2.Location = new Point(17, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(171, 103);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tipo de figura";
            // 
            // rbRectangulo
            // 
            rbRectangulo.AutoSize = true;
            rbRectangulo.Location = new Point(25, 28);
            rbRectangulo.Name = "rbRectangulo";
            rbRectangulo.Size = new Size(106, 25);
            rbRectangulo.TabIndex = 4;
            rbRectangulo.TabStop = true;
            rbRectangulo.Text = "Rectangulo";
            rbRectangulo.UseVisualStyleBackColor = true;
            // 
            // rbCirculo
            // 
            rbCirculo.AutoSize = true;
            rbCirculo.Location = new Point(25, 59);
            rbCirculo.Name = "rbCirculo";
            rbCirculo.Size = new Size(77, 25);
            rbCirculo.TabIndex = 5;
            rbCirculo.TabStop = true;
            rbCirculo.Text = "Circulo";
            rbCirculo.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(291, 153);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(100, 29);
            tbArea.TabIndex = 3;
            // 
            // tbRadio
            // 
            tbRadio.Location = new Point(291, 104);
            tbRadio.Name = "tbRadio";
            tbRadio.Size = new Size(100, 29);
            tbRadio.TabIndex = 2;
            // 
            // tbLargo
            // 
            tbLargo.Location = new Point(291, 65);
            tbLargo.Name = "tbLargo";
            tbLargo.Size = new Size(100, 29);
            tbLargo.TabIndex = 1;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(291, 30);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 29);
            tbAncho.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 399);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Controls.Add(btnActualizar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btnActualizar;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton rbCirculo;
        private RadioButton rbRectangulo;
        private TextBox tbArea;
        private TextBox tbRadio;
        private TextBox tbLargo;
        private TextBox tbAncho;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
