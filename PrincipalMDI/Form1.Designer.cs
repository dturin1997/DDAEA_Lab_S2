namespace manUsuario
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
            panel1 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            fecha = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 178);
            panel1.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(341, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(310, 23);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(341, 57);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(310, 23);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 124);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(582, 23);
            textBox4.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(69, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(68, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(68, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(341, 20);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(284, 94);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(269, 57);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 5;
            label6.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(217, 23);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha Nacimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 124);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 3;
            label4.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 96);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 2;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 62);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 26);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellido, telefono, direccion, email, fecha });
            dataGridView1.Location = new Point(12, 259);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(776, 179);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(272, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(373, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "Modificar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(478, 208);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 4;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(588, 208);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 5;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dni
            // 
            dni.HeaderText = "dni";
            dni.Name = "dni";
            // 
            // nombre
            // 
            nombre.HeaderText = "nombre";
            nombre.Name = "nombre";
            // 
            // apellido
            // 
            apellido.HeaderText = "apellido";
            apellido.Name = "apellido";
            // 
            // telefono
            // 
            telefono.HeaderText = "telefono";
            telefono.Name = "telefono";
            // 
            // direccion
            // 
            direccion.HeaderText = "direccion";
            direccion.Name = "direccion";
            // 
            // email
            // 
            email.HeaderText = "email";
            email.Name = "email";
            // 
            // fecha
            // 
            fecha.HeaderText = "fecha";
            fecha.Name = "fecha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn fecha;
    }
}