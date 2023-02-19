
namespace calculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnsuma = new System.Windows.Forms.Button();
            this.btncoma = new System.Windows.Forms.Button();
            this.btnzero = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.btntres = new System.Windows.Forms.Button();
            this.btndos = new System.Windows.Forms.Button();
            this.btnuno = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnseis = new System.Windows.Forms.Button();
            this.btncinco = new System.Windows.Forms.Button();
            this.btncuatro = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnnueve = new System.Windows.Forms.Button();
            this.btnocho = new System.Windows.Forms.Button();
            this.btnsiete = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnraizcuadrada = new System.Windows.Forms.Button();
            this.btnborrarultimo = new System.Windows.Forms.Button();
            this.btnborrartodo = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtresultado
            // 
            this.txtresultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtresultado.Location = new System.Drawing.Point(19, 12);
            this.txtresultado.MaxLength = 15;
            this.txtresultado.Multiline = true;
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.ReadOnly = true;
            this.txtresultado.Size = new System.Drawing.Size(494, 126);
            this.txtresultado.TabIndex = 0;
            this.txtresultado.Text = "0";
            this.txtresultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnsuma
            // 
            this.btnsuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuma.Location = new System.Drawing.Point(397, 533);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(120, 79);
            this.btnsuma.TabIndex = 2;
            this.btnsuma.Tag = "+";
            this.btnsuma.Text = "+";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.clickoperador);
            // 
            // btncoma
            // 
            this.btncoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncoma.Location = new System.Drawing.Point(19, 533);
            this.btncoma.Name = "btncoma";
            this.btncoma.Size = new System.Drawing.Size(120, 79);
            this.btncoma.TabIndex = 3;
            this.btncoma.Text = ".";
            this.btncoma.UseVisualStyleBackColor = true;
            this.btncoma.Click += new System.EventHandler(this.btncoma_Click);
            // 
            // btnzero
            // 
            this.btnzero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnzero.Location = new System.Drawing.Point(145, 533);
            this.btnzero.Name = "btnzero";
            this.btnzero.Size = new System.Drawing.Size(120, 79);
            this.btnzero.TabIndex = 4;
            this.btnzero.Text = "0";
            this.btnzero.UseVisualStyleBackColor = true;
            this.btnzero.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnigual
            // 
            this.btnigual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnigual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnigual.Location = new System.Drawing.Point(271, 533);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(120, 79);
            this.btnigual.TabIndex = 5;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = false;
            this.btnigual.Click += new System.EventHandler(this.btnigual_Click);
            // 
            // btntres
            // 
            this.btntres.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntres.Location = new System.Drawing.Point(275, 448);
            this.btntres.Name = "btntres";
            this.btntres.Size = new System.Drawing.Size(120, 79);
            this.btntres.TabIndex = 9;
            this.btntres.Text = "3";
            this.btntres.UseVisualStyleBackColor = true;
            this.btntres.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btndos
            // 
            this.btndos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndos.Location = new System.Drawing.Point(149, 448);
            this.btndos.Name = "btndos";
            this.btndos.Size = new System.Drawing.Size(120, 79);
            this.btndos.TabIndex = 8;
            this.btndos.Text = "2";
            this.btndos.UseVisualStyleBackColor = true;
            this.btndos.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnuno
            // 
            this.btnuno.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuno.Location = new System.Drawing.Point(23, 448);
            this.btnuno.Name = "btnuno";
            this.btnuno.Size = new System.Drawing.Size(120, 79);
            this.btnuno.TabIndex = 7;
            this.btnuno.Text = "1";
            this.btnuno.UseVisualStyleBackColor = true;
            this.btnuno.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnresta
            // 
            this.btnresta.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresta.Location = new System.Drawing.Point(401, 448);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(120, 79);
            this.btnresta.TabIndex = 6;
            this.btnresta.Tag = "−";
            this.btnresta.Text = "−";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnseis
            // 
            this.btnseis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnseis.Location = new System.Drawing.Point(275, 363);
            this.btnseis.Name = "btnseis";
            this.btnseis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnseis.Size = new System.Drawing.Size(120, 79);
            this.btnseis.TabIndex = 13;
            this.btnseis.Text = "6";
            this.btnseis.UseVisualStyleBackColor = true;
            this.btnseis.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btncinco
            // 
            this.btncinco.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncinco.Location = new System.Drawing.Point(149, 363);
            this.btncinco.Name = "btncinco";
            this.btncinco.Size = new System.Drawing.Size(120, 79);
            this.btncinco.TabIndex = 12;
            this.btncinco.Text = "5";
            this.btncinco.UseVisualStyleBackColor = true;
            this.btncinco.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btncuatro
            // 
            this.btncuatro.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncuatro.Location = new System.Drawing.Point(23, 363);
            this.btncuatro.Name = "btncuatro";
            this.btncuatro.Size = new System.Drawing.Size(120, 79);
            this.btncuatro.TabIndex = 11;
            this.btncuatro.Text = "4";
            this.btncuatro.UseVisualStyleBackColor = true;
            this.btncuatro.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiplicacion.Location = new System.Drawing.Point(401, 363);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(120, 79);
            this.btnmultiplicacion.TabIndex = 10;
            this.btnmultiplicacion.Tag = "X";
            this.btnmultiplicacion.Text = "X";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            this.btnmultiplicacion.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnnueve
            // 
            this.btnnueve.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnueve.Location = new System.Drawing.Point(275, 278);
            this.btnnueve.Name = "btnnueve";
            this.btnnueve.Size = new System.Drawing.Size(120, 79);
            this.btnnueve.TabIndex = 17;
            this.btnnueve.Text = "9";
            this.btnnueve.UseVisualStyleBackColor = true;
            this.btnnueve.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnocho
            // 
            this.btnocho.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnocho.Location = new System.Drawing.Point(149, 278);
            this.btnocho.Name = "btnocho";
            this.btnocho.Size = new System.Drawing.Size(120, 79);
            this.btnocho.TabIndex = 16;
            this.btnocho.Text = "8";
            this.btnocho.UseVisualStyleBackColor = true;
            this.btnocho.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btnsiete
            // 
            this.btnsiete.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsiete.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsiete.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsiete.Location = new System.Drawing.Point(23, 278);
            this.btnsiete.Name = "btnsiete";
            this.btnsiete.Size = new System.Drawing.Size(120, 79);
            this.btnsiete.TabIndex = 15;
            this.btnsiete.Text = "7";
            this.btnsiete.UseVisualStyleBackColor = true;
            this.btnsiete.Click += new System.EventHandler(this.AgregarNumero);
            // 
            // btndivision
            // 
            this.btndivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivision.Location = new System.Drawing.Point(401, 278);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(120, 79);
            this.btndivision.TabIndex = 14;
            this.btndivision.Tag = "/";
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            this.btndivision.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnraizcuadrada
            // 
            this.btnraizcuadrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnraizcuadrada.Location = new System.Drawing.Point(275, 193);
            this.btnraizcuadrada.Name = "btnraizcuadrada";
            this.btnraizcuadrada.Size = new System.Drawing.Size(120, 79);
            this.btnraizcuadrada.TabIndex = 21;
            this.btnraizcuadrada.Tag = "√";
            this.btnraizcuadrada.Text = "√";
            this.btnraizcuadrada.UseVisualStyleBackColor = true;
            this.btnraizcuadrada.Click += new System.EventHandler(this.clickoperador);
            // 
            // btnborrarultimo
            // 
            this.btnborrarultimo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnborrarultimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrarultimo.Location = new System.Drawing.Point(149, 193);
            this.btnborrarultimo.Name = "btnborrarultimo";
            this.btnborrarultimo.Size = new System.Drawing.Size(120, 79);
            this.btnborrarultimo.TabIndex = 20;
            this.btnborrarultimo.Text = "CE";
            this.btnborrarultimo.UseVisualStyleBackColor = false;
            this.btnborrarultimo.Click += new System.EventHandler(this.btnborrarultimo_Click);
            // 
            // btnborrartodo
            // 
            this.btnborrartodo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnborrartodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrartodo.Location = new System.Drawing.Point(23, 193);
            this.btnborrartodo.Name = "btnborrartodo";
            this.btnborrartodo.Size = new System.Drawing.Size(120, 79);
            this.btnborrartodo.TabIndex = 19;
            this.btnborrartodo.Text = "C";
            this.btnborrartodo.UseVisualStyleBackColor = false;
            this.btnborrartodo.Click += new System.EventHandler(this.btnborrartodo_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.BackColor = System.Drawing.Color.Red;
            this.btnborrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrar.Location = new System.Drawing.Point(401, 193);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(120, 79);
            this.btnborrar.TabIndex = 22;
            this.btnborrar.Text = "<=";
            this.btnborrar.UseVisualStyleBackColor = false;
            this.btnborrar.Click += new System.EventHandler(this.btnborrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 624);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnraizcuadrada);
            this.Controls.Add(this.btnborrarultimo);
            this.Controls.Add(this.btnborrartodo);
            this.Controls.Add(this.btnnueve);
            this.Controls.Add(this.btnocho);
            this.Controls.Add(this.btnsiete);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnseis);
            this.Controls.Add(this.btncinco);
            this.Controls.Add(this.btncuatro);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btntres);
            this.Controls.Add(this.btndos);
            this.Controls.Add(this.btnuno);
            this.Controls.Add(this.btnresta);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnzero);
            this.Controls.Add(this.btncoma);
            this.Controls.Add(this.btnsuma);
            this.Controls.Add(this.txtresultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CALCULADORA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btncoma;
        private System.Windows.Forms.Button btnzero;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.Button btntres;
        private System.Windows.Forms.Button btndos;
        private System.Windows.Forms.Button btnuno;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnseis;
        private System.Windows.Forms.Button btncinco;
        private System.Windows.Forms.Button btncuatro;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnnueve;
        private System.Windows.Forms.Button btnocho;
        private System.Windows.Forms.Button btnsiete;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnraizcuadrada;
        private System.Windows.Forms.Button btnborrarultimo;
        private System.Windows.Forms.Button btnborrartodo;
        private System.Windows.Forms.Button btnborrar;
    }
}

