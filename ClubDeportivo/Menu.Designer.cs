﻿namespace ClubDeportivo
{
    partial class FrmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            lblIngreso = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            btnPagarCuota = new Button();
            btnListar = new Button();
            btnReimprimir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(73, 32);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(34, 15);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "USER";
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(669, 32);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(73, 136);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(231, 48);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "REGISTRAR CLIENTE";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnPagarCuota
            // 
            btnPagarCuota.Location = new Point(513, 136);
            btnPagarCuota.Name = "btnPagarCuota";
            btnPagarCuota.Size = new Size(231, 48);
            btnPagarCuota.TabIndex = 3;
            btnPagarCuota.Text = "PAGAR CUOTA";
            btnPagarCuota.UseVisualStyleBackColor = true;
            btnPagarCuota.Click += btnPagarCuota_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(73, 265);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(231, 48);
            btnListar.TabIndex = 4;
            btnListar.Text = "LISTAR CLIENTES MOROSOS";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListarMorosos_click;
            // 
            // btnReimprimir
            // 
            btnReimprimir.Location = new Point(513, 265);
            btnReimprimir.Name = "btnReimprimir";
            btnReimprimir.Size = new Size(231, 48);
            btnReimprimir.TabIndex = 5;
            btnReimprimir.Text = "REIMPRIMIR CARNET";
            btnReimprimir.UseVisualStyleBackColor = true;
            btnReimprimir.Click += btnReimprimir_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(9, 179, 179);
            ClientSize = new Size(800, 450);
            Controls.Add(btnListar);
            Controls.Add(btnReimprimir);
            Controls.Add(btnPagarCuota);
            Controls.Add(btnRegistrar);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VENTANA PRINCIPAL";
            Load += frmMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnSalir;
        private Button btnRegistrar;
        private Button btnPagarCuota;
        private Button btnListar;
        private Button btnReimprimir;
    }
}